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

    public partial class FormEgresos : Form
    {
        private UsuariosRepositorio usuariosRepositorio;
        private Validaciones validaciones;
        private SolicitudesRepositorio solicitudesRepositorio;
        private VisitantesRepositorio visitantesRepositorio;
        public FormEgresos()
        {
            InitializeComponent();
            solicitudesRepositorio = new SolicitudesRepositorio();
            CargarIngresos();
        }

        private void CargarIngresos()
        {
            List<Solicitude> solicitudes = solicitudesRepositorio.ObtenerSolicitudes();
            dgSolicitudes.Rows.Clear();
            dgSolicitudes.Refresh();
            var fechaHoy = DateTime.Today;
            foreach (Solicitude solicitud in solicitudes)
            {
                if (solicitud.Estado == true)
                {
                    dgSolicitudes.Rows.Add(solicitud.IdSolicitud, solicitud.IdUsuarioNavigation.NombreCompleto, solicitud.IdVisitanteNavigation.NombreCompleto, solicitud.IdVisitanteNavigation.Dni, solicitud.Fecha, "Registrar");

                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
