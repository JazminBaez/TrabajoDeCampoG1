using seguridad_barrios_privados.Logica;
using seguridad_barrios_privados.Models;
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
        public FormSolicitudes()
        {
            InitializeComponent();
            solicitudesRepositorio = new SolicitudesRepositorio();
            CargarSolicitudes();
        }

        private void CargarSolicitudes()
        {
            List<Solicitude> solicitudes = solicitudesRepositorio.ObtenerSolicitudes();
            dgSolicitudes.Rows.Clear();
            dgSolicitudes.Refresh();
            var fechaHoy = DateTime.Today;
            foreach (Solicitude solicitud in solicitudes)

                if (solicitud.IdUsuario == AppState.UsuarioActual.IdUsuario)
                {
                    string estadoSolicitud;
                    int estado = solicitud.Estado ?? 0;

                    switch (estado)
                    {
                        default:
                            estadoSolicitud = "pendiente";
                            break;
                        case 1:
                            estadoSolicitud = "aceptado";
                            break;
                        case 2:
                            estadoSolicitud = "rechazado";
                            break;
                    }
                    dgSolicitudes.Rows.Add(estadoSolicitud, solicitud.IdVisitanteNavigation.Nombre, solicitud.IdVisitanteNavigation.Apellido, solicitud.IdVisitanteNavigation.Dni, solicitud.Fecha, "Cancelar");

                }
        }



        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void tbApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
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
            if (!(Validaciones.CamposCompletos(tbNombre, tbApellido, tbDni)))
            {
                Validaciones.MostrarError("Complete todos los campos", lbError, ErrorIcon);
            }
        }

        private void lbError_Click(object sender, EventArgs e)
        {

        }
    }
}
