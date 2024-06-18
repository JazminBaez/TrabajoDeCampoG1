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
using System.Windows.Media.Animation;
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
        
        private List<SolicitudConDetalle> Solicitudes;
        private List<SolicitudConDetalle> ListaBackup;
        private List<SolicitudConDetalle> ListaSolicitudes;
        private string busquedaPrevia;
        private List<Usuario> propietarios;
        private DateTime fechaHoy;

        public FormIngresos()
        {
            InitializeComponent();
            usuariosRepositorio = new UsuariosRepositorio();
            solicitudesRepositorio = new SolicitudesRepositorio();
            ingresosRepositorio = new IngresosRepositorio();
            visitantesRepositorio = new VisitantesRepositorio();
            validaciones = new Validaciones();
            propietarios = new List<Usuario>();


            propietarios = usuariosRepositorio.ObtenerUsuariosPorRol(1);
            var propietariosActivos = propietarios.Where(u => u.Estado != 1).ToList();
            cbPropietarios.DataSource = propietariosActivos;
            cbPropietarios.DisplayMember = "Datos";
            cbPropietarios.ValueMember = "IdUsuario";

            

            fechaHoy = DateTime.Today;

        


            Solicitudes = solicitudesRepositorio.ObtenerSolicitudes();
            ListaSolicitudes = Solicitudes;
            ListaBackup = ListaSolicitudes;
            busquedaPrevia = string.Empty;
            MostrarSolicitudes();
            cbPropietarios.SelectedIndex = -1;
        }

        private void LRegistrarUsuario_Click(object sender, EventArgs e)
        {

        }



        //------------------------------------------------------------------------------------------------------------------------------
        private void MostrarSolicitudes()
        {
            //crea lista de solicitudes que sean de hoy y tengan de estado 3
            var solicitudesPendientes = ListaSolicitudes.Where(s => s.solicitud_fecha.Date == fechaHoy.Date && s.solicitud_estado == 0).ToList();
            SolicitudHelper.CargarSolicitudes(dgSolicitudes, solicitudesPendientes);

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------
       
        
        
       


        //------------------------------------------------------------------------------------------------------------------
        private void btRegistrar_Click(object sender, EventArgs e)
        {

           
           var visitante = visitantesRepositorio.CrearVisitante(tbNombre.Texts, tbApellido.Texts, tbDni.Texts); ;

           validaciones.VerificarSolicitud(visitante, fechaHoy, cbPropietarios, lbError);
           ActualizarSolicitudes();
           MostrarSolicitudes();
           RestablecerFormulario(lbError, ErrorIcon, tbApellido, tbNombre, tbDni);
           cbPropietarios.SelectedIndex = -1;
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
               
            }

            //rechaza la solicitud
            if (e.RowIndex >= 0 && e.ColumnIndex == dgSolicitudes.Columns["CRechazar"].Index)
            {
                validaciones.RechazarSolicitud(solicitud);
            }


            //cancelar solicitud
            if (e.RowIndex >= 0 && e.ColumnIndex == dgSolicitudes.Columns["CCancelar"].Index)
            {

              validaciones.cancelarSolicitud(solicitud);
               
            }

            ActualizarSolicitudes();
            MostrarSolicitudes();
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
                    ListaSolicitudes = Solicitudes?.Where(s => s.usuario_dni.Contains(tbBuscarSolicitud.Texts!)).ToList();
                }
                else
                {
                    ListaSolicitudes = Solicitudes?.Where(s => s.usuario_nombre.ToLowerInvariant().Contains(tbBuscarSolicitud.Texts!.ToLowerInvariant()) ||
                    s.usuario_apellido.ToLowerInvariant().Contains(tbBuscarSolicitud.Texts!.ToLowerInvariant())).ToList();

                }
            }
            else
            {
                ListaSolicitudes = Solicitudes;
            }

            this.MostrarSolicitudes();

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
