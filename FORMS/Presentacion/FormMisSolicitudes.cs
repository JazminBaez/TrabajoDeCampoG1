using seguridad_barrios_privados.Logica;
using seguridad_barrios_privados.Modelos;
using seguridad_barrios_privados.Presentacion;
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
    public partial class FormMisSolicitudes : Form
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
        private List<SolicitudConDetalle> Solicitudes;
        private List<SolicitudConDetalle> ListaSolicitudes;
        private List<SolicitudConDetalle> solicitudesBackUp;
        private string orden;
        public FormMisSolicitudes()
        {
            InitializeComponent();
            solicitudesRepositorio = new SolicitudesRepositorio();
            egresosRepositorio = new EgresosRepositorio();
            ingresosRepositorio = new IngresosRepositorio();


            Solicitudes = solicitudesRepositorio.ObtenerSolicitudes();
            ListaSolicitudes = Solicitudes;
            solicitudesBackUp = ListaSolicitudes;
            orden = "descendente";
            MostarSolicitudes();
        }




        private void MostarSolicitudes()
        {
            Solicitudes = Solicitudes.Where(s => s.id_usuario == AppState.UsuarioActual.IdUsuario).ToList();

            SolicitudHelper.CargarSolicitudes(dgSolicitudes, Solicitudes);
        }



        private void dtFechaMovimeintos_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ReestablecerFiltros(object sender, EventArgs e)
        {

            dtFechaHasta.Value = DateTime.Now;
            dtFechaDesde.Value = DateTime.Now;

            Solicitudes = solicitudesRepositorio.ObtenerSolicitudes();
            ListaSolicitudes = Solicitudes;
            solicitudesBackUp = ListaSolicitudes;
            cbFiltraSolicitudes.SelectedIndex = -1;
            cbFiltraSolicitudes.Text = "Estado";
            MostarSolicitudes();
        }

        private void OrdenarPorFecha(object sender, EventArgs e)
        {

            if (orden == "descendente")
            {
                orden = "ascendente";
                Solicitudes = Solicitudes.OrderBy(m => m.solicitud_fecha).ToList();
                iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ArrowUpWideShort;
            }
            else
            {
                orden = "descendente";
                Solicitudes = Solicitudes.OrderByDescending(m => m.solicitud_fecha).ToList();
                iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ArrowDownWideShort;
            }

            MostarSolicitudes();
        }

        private void FiltrarPorEstado(object sender, EventArgs e)
        {
            var solicitudesFiltrar = solicitudesBackUp;
            int estadoSeleccionado = cbFiltraSolicitudes.SelectedIndex;
            if (estadoSeleccionado != -1)
            {
                solicitudesFiltrar = solicitudesFiltrar?.Where(s => s.solicitud_estado == estadoSeleccionado).ToList();
            }

            ListaSolicitudes = solicitudesFiltrar;
            Solicitudes = solicitudesFiltrar;
            MostarSolicitudes();
        }

        private void FiltrarPorUsuario(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbBuscarUsuario.Texts))
            {
                if (Regex.IsMatch(tbBuscarUsuario.Texts, @"^\d+$"))
                {
                    ListaSolicitudes = Solicitudes?.Where(s => s.usuario_dni.Contains(tbBuscarUsuario.Texts!)).ToList();
                }
                else
                {
                    ListaSolicitudes = Solicitudes?.Where(s => s.usuario_nombre.ToLowerInvariant().Contains(tbBuscarUsuario.Texts!.ToLowerInvariant()) ||
                    s.usuario_apellido.ToLowerInvariant().Contains(tbBuscarUsuario.Texts!.ToLowerInvariant())).ToList();

                }
            }
            else
            {
                ListaSolicitudes = Solicitudes;
            }
            this.MostarSolicitudes();
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

            ListaSolicitudes = Solicitudes?.Where(s => s.solicitud_fecha >= fechaDesde && s.solicitud_fecha <= fechaHasta).ToList();

            MostarSolicitudes();
        }
    }
}
