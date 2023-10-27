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
    public partial class FormInformeMovimientos : Form
    {
        private UsuariosRepositorio usuariosRepositorio;
        private Validaciones validaciones;
        private SolicitudesRepositorio solicitudesRepositorio;
        private VisitantesRepositorio visitantesRepositorio;
        public FormInformeMovimientos()
        {
            InitializeComponent();
            solicitudesRepositorio = new SolicitudesRepositorio();
            CargarMovimientos();

        }

        private void CargarMovimientos()
        {
            List<Solicitude> solicitudes = solicitudesRepositorio.ObtenerSolicitudes();
            dgMovimientos.Rows.Clear();
            dgMovimientos.Refresh();
            var fechaHoy = DateTime.Today;
            foreach (Solicitude solicitud in solicitudes)
            {
                if (solicitud.Baja == false)
                {
                    dgMovimientos.Rows.Add(solicitud.IdSolicitud, "Ingreso", solicitud.IdUsuarioNavigation.NombreCompleto, solicitud.IdVisitanteNavigation.NombreCompleto, solicitud.IdVisitanteNavigation.Dni, solicitud.Fecha);
                }
            }
        }

        private void dtFechaMovimeintos_ValueChanged(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            //este boton deberia actualizar el datagrid para eliminar los filtros puestos
        }
    }
}
