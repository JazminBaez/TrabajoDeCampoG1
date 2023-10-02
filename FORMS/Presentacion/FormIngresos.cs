using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using seguridad_barrios_privados.Controls;
using seguridad_barrios_privados.Logica;
using seguridad_barrios_privados.Models;
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

        public FormIngresos()
        {
            InitializeComponent();
            usuariosRepositorio = new UsuariosRepositorio();
            solicitudesRepositorio = new SolicitudesRepositorio();
            validaciones = new Validaciones();

            cbPropietarios.DataSource = usuariosRepositorio.ObtenerUsuariosPorId(1);
            cbPropietarios.DisplayMember = "Datos";
            cbPropietarios.ValueMember = "IdUsuario";

            CargarSolicitudes();
            cbPropietarios.SelectedIndex = -1;
        }

        private void LRegistrarUsuario_Click(object sender, EventArgs e)
        {

        }
        private void CargarSolicitudes()
        {
            List<Solicitude> solicitudes = solicitudesRepositorio.ObtenerSolicitudes();
            dgSolicitudes.Rows.Clear();
            dgSolicitudes.Refresh();
            var fechaHoy = DateTime.Today;
            foreach (Solicitude solicitud in solicitudes)
            {
                if (solicitud.Estado == false && solicitud.Fecha == fechaHoy)
                {
                    dgSolicitudes.Rows.Add(solicitud.IdSolicitud, solicitud.IdUsuarioNavigation.NombreCompleto, solicitud.IdVisitanteNavigation.NombreCompleto, solicitud.IdVisitanteNavigation.Dni, solicitud.Fecha, "Aceptar");

                }
            }
        }

        private void number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                // Si no es una letra ni Backspace, ignorar la tecla presionada
                e.Handled = true;
            }
        }

        private void lbFiltrarUsuarios_Click(object sender, EventArgs e)
        {
        }

        private void dtFechaMovimeintos_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            var visitante = new Visitante()
            {
                Nombre = tbNombre.Texts,
                Apellido = tbApellido.Texts,
                Dni = tbDni.Texts
            };


            if (validaciones.RegistrarSolicitud(visitante, cbPropietarios, lbError, ErrorIcon, dgSolicitudes))
            {

                MessageBox.Show("Solicitud realizada con exito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarSolicitudes();
                RestablecerFormulario(lbError, ErrorIcon, tbApellido, tbNombre, tbDni);
                cbPropietarios.SelectedIndex = -1;

            }

           

        }

        private void tbApellido__TextChanged(object sender, EventArgs e)
        {
        }

        private void TBDireccion__TextChanged(object sender, EventArgs e)
        {
        }

        private void tbNombre__TextChanged(object sender, EventArgs e)
        {
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            {
                // Si no es una letra ni Backspace, ignorar la tecla presionada
                e.Handled = true;
            }
        }

        private void tbApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            {
                // Si no es una letra ni Backspace, ignorar la tecla presionada
                e.Handled = true;
            }
        }

        private void TBDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Validaciones.CamposCompletos(tbBuscarSolicitud))
            {
                //buscar usuario
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            validaciones.AceptarSolicitud(dgSolicitudes);
            MessageBox.Show("Ingreso registrado", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarSolicitudes();
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
    }
}
