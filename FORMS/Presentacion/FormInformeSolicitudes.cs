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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seguridad_barrios_privados.Presentacion
{
    public partial class FormInformeSolicitudes : Form
    {
        private UsuariosRepositorio usuariosRepositorio;
        private Validaciones validaciones;
        private SolicitudesRepositorio solicitudesRepositorio;
        private EgresosRepositorio egresosRepositorio;
        private IngresosRepositorio ingresosRepositorio;
        private VisitantesRepositorio visitantesRepositorio;
        //private List<Ingreso> ingresos;
        //private List<Solicitude> solicitudes;
        //private List<Egreso> egresos;
        private List<Solicitude> Solicitudes;
        private List<Solicitude> ListaSolicitudes;
        private List<Solicitude> solicitudesBackUp;
        private string orden;
        public FormInformeSolicitudes()
        {
            InitializeComponent();
            solicitudesRepositorio = new SolicitudesRepositorio();
            egresosRepositorio = new EgresosRepositorio();
            ingresosRepositorio = new IngresosRepositorio();


            Solicitudes = solicitudesRepositorio.ObtenerSolicitudes();
            ListaSolicitudes = Solicitudes;
            solicitudesBackUp = ListaSolicitudes;
            orden = "descendente";
            CargarSolicitudes();
        }



        private void CargarSolicitudes()
        {
            dgSolicitudes.Rows.Clear();
            dgSolicitudes.Refresh();
            foreach (Solicitude solicitud in ListaSolicitudes)
            {

                if (solicitud.Baja != true)
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
                            dgSolicitudes.Rows.Add(solicitud.IdSolicitud, estadoSolicitud, solicitud.IdUsuarioNavigation.NombreCompleto,solicitud.IdUsuarioNavigation.Dni ,solicitud.IdVisitanteNavigation.NombreCompleto, solicitud.IdVisitanteNavigation.Dni, solicitud.Fecha);

                            Color colorOscuro = Color.FromArgb(25, 46, 71);
                            Color colorTexto = Color.FromArgb(45, 66, 91);
                            dgSolicitudes.Rows[dgSolicitudes.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.LightGray; // Configura el color del texto
                            dgSolicitudes.Rows[dgSolicitudes.Rows.Count - 1].DefaultCellStyle.BackColor = colorOscuro;

                            continue;

                      }
                         dgSolicitudes.Rows.Add(solicitud.IdSolicitud, estadoSolicitud, solicitud.IdUsuarioNavigation.NombreCompleto, solicitud.IdUsuarioNavigation.Dni, solicitud.IdVisitanteNavigation.NombreCompleto, solicitud.IdVisitanteNavigation.Dni, solicitud.Fecha);

                }

            }
        }

        private void dtFechaMovimeintos_ValueChanged(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            dtFechaHasta.Value = DateTime.Now;
            dtFechaDesde.Value = DateTime.Now;
          
            Solicitudes = solicitudesRepositorio.ObtenerSolicitudes();
            ListaSolicitudes = Solicitudes;
            solicitudesBackUp = ListaSolicitudes;
            cbFiltraSolicitudes.SelectedIndex = -1;
            cbFiltraSolicitudes.Text = "Estado";
            CargarSolicitudes();
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

            if (orden == "descendente")
            {
                orden = "ascendente";
                ListaSolicitudes = ListaSolicitudes.OrderBy(m => m.Fecha).ToList();
                iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ArrowUpWideShort;
            }
            else
            {
                orden = "descendente";
                ListaSolicitudes = ListaSolicitudes.OrderByDescending(m => m.Fecha).ToList();
                iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ArrowDownWideShort;
            }

            CargarSolicitudes();
        }

        private void cbFiltrarSolicitudes_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Solicitude>? SolicitudesFiltrar = solicitudesBackUp;
            int estadoSeleccionado = cbFiltraSolicitudes.SelectedIndex;
            if (estadoSeleccionado != -1)
            {
                //que guarde en usuariosFiltrar todos los usuarios de usuariosFiltrar que tengan el rol seleccionado en el comboBox
                SolicitudesFiltrar = SolicitudesFiltrar?.Where(s => s.Estado == estadoSeleccionado).ToList();
            }

            ListaSolicitudes = SolicitudesFiltrar;
            Solicitudes = SolicitudesFiltrar;
            CargarSolicitudes();
        }

        private void tbBuscarUsuario__TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbBuscarUsuario.Texts))
            {
                if (Regex.IsMatch(tbBuscarUsuario.Texts, @"^\d+$"))
                {
                    ListaSolicitudes = Solicitudes?.Where(s => s.IdUsuarioNavigation.Dni.Contains(tbBuscarUsuario.Texts!)).ToList();
                }
                else
                {
                    ListaSolicitudes = Solicitudes?.Where(s => s.IdUsuarioNavigation.Nombre.ToLowerInvariant().Contains(tbBuscarUsuario.Texts!.ToLowerInvariant()) || s.IdUsuarioNavigation.Apellido.ToLowerInvariant().Contains(tbBuscarUsuario.Texts!.ToLowerInvariant())).ToList();

                }
            }
            else
            {
                ListaSolicitudes = Solicitudes;
            }
            this.CargarSolicitudes();
        }

        private void dtFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            FiltrarSolicitudesPorFecha();
        }

        private void dtFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            FiltrarSolicitudesPorFecha();
        }

        private void FiltrarSolicitudesPorFecha()
        {
            DateTime fechaDesde = dtFechaDesde.Value.Date;
            DateTime fechaHasta = dtFechaHasta.Value.Date;

            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show("La fecha de inicio debe ser anterior o igual a la fecha de fin.", "Error de rango de fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListaSolicitudes = Solicitudes?.Where(s => s.Fecha >= fechaDesde && s.Fecha <= fechaHasta).ToList();

            CargarSolicitudes();
        }
    }
}

