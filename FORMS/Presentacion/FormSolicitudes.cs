using FontAwesome.Sharp;
using seguridad_barrios_privados.Controls;
using seguridad_barrios_privados.Logica;
using seguridad_barrios_privados.Modelos;
using seguridad_barrios_privados.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;


namespace seguridad_barrios_privados.Presentacion
{
    public partial class FormSolicitudes : Form
    {
        private UsuariosRepositorio usuariosRepositorio;
        private Validaciones validaciones;
        private SolicitudesRepositorio solicitudesRepositorio;
        private VisitantesRepositorio visitantesRepositorio;
        private List<SolicitudConDetalle> Solicitudes;
        public FormSolicitudes()
        {
            InitializeComponent();
            solicitudesRepositorio = new SolicitudesRepositorio();
            visitantesRepositorio = new VisitantesRepositorio();
            validaciones = new Validaciones();

            Solicitudes = solicitudesRepositorio.ObtenerSolicitudes();

            MostarSolicitudes();
        
            dtFechaMovimeintos.MinDate = DateTime.Today;

        }

        private void MostarSolicitudes()
        {
            List<SolicitudConDetalle> solicitudesPendientes = Solicitudes.Where(s => s.solicitud_estado == 0).ToList();
            SolicitudHelper.CargarSolicitudes(dgSolicitudes, solicitudesPendientes);

        }

        private void dgSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == dgSolicitudes.Columns["CCancelar"].Index)
            {

                DialogResult dialogResult = MessageBox.Show("¿Estás seguro de eliminar la solicitud? El adiministrador aun podra ver su historial completo", "Confirmación", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var solicitud = solicitudesRepositorio.ObtenerSolicitud(Convert.ToInt32(dgSolicitudes.Rows[e.RowIndex].Cells[0].Value));
                    solicitud.Estado = 3;
                    solicitudesRepositorio.ActualizarSolicitud(solicitud);
                    System.Windows.Forms.MessageBox.Show("Solicitud eliminada", "Éxito");
                }

                MostarSolicitudes();
            }
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

        private void TBDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            var visitante = new Visitante()
            {
                Nombre = tbNombre.Texts,
                Apellido = tbApellido.Texts,
                Dni = tbDni.Texts
            };


            var fechaProgramada = dtFechaMovimeintos.Value;

            validaciones.VerificarSolicitud(visitante, fechaProgramada, null, lbError);
            
            MostarSolicitudes();
            RestablecerFormulario(lbError, ErrorIcon, tbApellido, tbNombre, tbDni);
            dtFechaMovimeintos.DataContext = DateTime.Today;

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
        private void lbError_Click(object sender, EventArgs e)
        {

        }

        private void lbSolicitudes_Click(object sender, EventArgs e)
        {

        }
    }
}
