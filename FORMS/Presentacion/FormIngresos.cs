using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using seguridad_barrios_privados.Controls;
using seguridad_barrios_privados.Logica;
using seguridad_barrios_privados.Modelos;
using seguridad_barrios_privados.Repositorio;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace seguridad_barrios_privados.Presentacion
{

    public partial class FormIngresos : Form
    {
        private UsuariosRepositorio usuariosRepositorio;
        private Validaciones validaciones;
        private SolicitudesRepositorio solicitudesRepositorio;
        private VisitantesRepositorio visitantesRepositorio;
        private IngresosRepositorio ingresosRepositorio;
        private List<Solicitud> Solicitudes;
        private List<Solicitud> ListaBackup;
        private List<Solicitud> ListaSolicitudes;
        private string busquedaPrevia;
        private List<Usuario> propietarios;

        public FormIngresos()
        {
            InitializeComponent();
            usuariosRepositorio = new UsuariosRepositorio();
            solicitudesRepositorio = new SolicitudesRepositorio();
            ingresosRepositorio = new IngresosRepositorio();
            validaciones = new Validaciones();
            propietarios = new List<Usuario>();


            propietarios = usuariosRepositorio.ObtenerUsuariosPorRol(1);
            var propietariosActivos = propietarios.Where(u => u.Estado != 1).ToList();
            cbPropietarios.DataSource = propietariosActivos;
            cbPropietarios.DisplayMember = "Datos";
            cbPropietarios.ValueMember = "IdUsuario";



            ListaSolicitudes = new List<Solicitud>();
            ListaBackup = new List<Solicitud>();
            Solicitudes = new List<Solicitud>();

            Solicitudes = solicitudesRepositorio.ObtenerSolicitudes();
            ListaSolicitudes = Solicitudes;
            ListaBackup = ListaSolicitudes;
            busquedaPrevia = string.Empty;
            CargarSolicitudes();
            cbPropietarios.SelectedIndex = -1;
        }

        private void LRegistrarUsuario_Click(object sender, EventArgs e)
        {

        }



        //------------------------------------------------------------------------------------------------------------------------------
        private void CargarSolicitudes()
        {

            dgSolicitudes.Rows.Clear();
            dgSolicitudes.Refresh();
            var fechaHoy = DateTime.Today;
            foreach (Solicitud solicitud in ListaSolicitudes)
            {
                if (solicitud.Estado != 3 && solicitud.Fecha == fechaHoy && solicitud.Estado == 0)
                {
                    dgSolicitudes.Rows.Add(solicitud.IdSolicitud, solicitud.IdUsuarioNavigation.NombreCompleto, solicitud.IdVisitanteNavigation.NombreCompleto, solicitud.IdVisitanteNavigation.Dni, "Aceptar", "Rechazar", "Cancelar");
                }
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------
       
        
        
       


        //------------------------------------------------------------------------------------------------------------------
        private void btRegistrar_Click(object sender, EventArgs e)
        {
            var visitante = new Visitante()
            {
                Nombre = tbNombre.Texts,
                Apellido = tbApellido.Texts,
                Dni = tbDni.Texts
            };

            var fechaHoy = DateTime.Today;

            if (validaciones.RegistrarSolicitud(visitante, fechaHoy, cbPropietarios, lbError))
            {

               
                ActualizarSolicitudes();
                CargarSolicitudes();
                RestablecerFormulario(lbError, ErrorIcon, tbApellido, tbNombre, tbDni);
                cbPropietarios.SelectedIndex = -1;
            }
    
        }

        //---------------------------------------------------------------------------------------------------------------------------------------


        //---------------------------------------------------------------------------------------------------------------------------------------------------
        private void dgSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var solicitud = solicitudesRepositorio.ObtenerSolicitud(Convert.ToInt32(dgSolicitudes.Rows[e.RowIndex].Cells[0].Value));

            //Acepta la solicitud
            if (e.RowIndex >= 0 && e.ColumnIndex == dgSolicitudes.Columns["CAceptarSolicitud"].Index)
            {

                validaciones.AceptarSolicitud(solicitud);
                CargarSolicitudes();
            }

            //rechaza la solicitud
            if (e.RowIndex >= 0 && e.ColumnIndex == dgSolicitudes.Columns["CRechazar"].Index)
            {
                validaciones.RechazarSolicitud(solicitud);
                CargarSolicitudes();

            }


            //cancelar solicitud
            if (e.RowIndex >= 0 && e.ColumnIndex == dgSolicitudes.Columns["CCancelar"].Index)
            {

              
                CargarSolicitudes();
            }
        }


        //---------------------------------------------------------------------------------------------------------------------------------------------------




        private void ActualizarSolicitudes()
        {
            Solicitudes = solicitudesRepositorio.ObtenerSolicitudes();
            ListaSolicitudes = Solicitudes;
            ListaBackup = ListaSolicitudes;
        }



        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {

                e.Handled = true;
            }
        }

        private void tbApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {

                e.Handled = true;
            }
        }

        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Validaciones.CamposCompletos(tbBuscarSolicitud))
            {
            }
        }

        


        private static void RestablecerFormulario(Label error, IconPictureBox errorIcon, params RJTextBox[] campos)
        {
            foreach (var campo in campos)
            {
                campo.Texts = string.Empty;
                campo.BorderColor = SystemColors.Window;
            }
            error.Visible = false;
            errorIcon.Visible = false;

        }

        private void tbBuscarSolicitud__TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbBuscarSolicitud.Texts))
            {
                if (Regex.IsMatch(tbBuscarSolicitud.Texts, @"^\d+$"))
                {
                    ListaSolicitudes = Solicitudes?.Where(s => s.IdVisitanteNavigation.Dni.Contains(tbBuscarSolicitud.Texts!)).ToList();
                }
                else
                {
                    ListaSolicitudes = Solicitudes?.Where(s => s.IdVisitanteNavigation.Nombre.ToLowerInvariant().Contains(tbBuscarSolicitud.Texts!.ToLowerInvariant()) || s.IdVisitanteNavigation.Apellido.ToLowerInvariant().Contains(tbBuscarSolicitud.Texts!.ToLowerInvariant())).ToList();

                }
            }
            else
            {
                ListaSolicitudes = Solicitudes;
            }

            this.CargarSolicitudes();

        }

        private void lbSolicitudesRealizadas_Click(object sender, EventArgs e)
        {

        }




        private void number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {

                e.Handled = true;
            }
        }

        private void lbFiltrarUsuarios_Click(object sender, EventArgs e)
        {
        }

        private void dtFechaMovimeintos_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
