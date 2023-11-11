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
    public partial class FormInformeMovimientos : Form
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
        private List<Movimiento> movimientos;
        private List<Movimiento> ListaMovimientos;
        private List<Movimiento> movimeintosBackUp;
        private string orden;
        public FormInformeMovimientos()
        {
            InitializeComponent();
            solicitudesRepositorio = new SolicitudesRepositorio();
            egresosRepositorio = new EgresosRepositorio();
            ingresosRepositorio = new IngresosRepositorio();


            movimientos = egresosRepositorio.ObtenerMovimientos().Union(ingresosRepositorio.ObtenerMovimientos()).OrderByDescending(m => m.Fecha).ToList();
            ListaMovimientos = movimientos;
            movimeintosBackUp = ListaMovimientos;
            orden = "descendente";
            CargarMovimientos();
        }



        private void CargarMovimientos()
        {
            dgMovimientos.Rows.Clear();
            dgMovimientos.Refresh();

            foreach (Movimiento movimiento in ListaMovimientos)
            {
                string observacion = "-";
                if (movimiento.TipoMovimiento == "Egreso")
                {
                    if (movimiento.Observaciones != null)
                    {
                        observacion = movimiento.Observaciones;
                    }

                    dgMovimientos.Rows.Add(movimiento.TipoMovimiento, movimiento.NombreUsuario, movimiento.DniUsuario, movimiento.NombreVisitante, movimiento.DniVisitante, movimiento.Fecha, observacion);
                    Color colorOscuro = Color.FromArgb(25, 46, 71);
                    Color colorTexto = Color.FromArgb(45, 66, 91);
                    //quiero que el color de la columna de tipo de ingreso sea de colorOscuro, solo esa celda no toda la fila
                    dgMovimientos.Rows[dgMovimientos.Rows.Count - 1].DefaultCellStyle.BackColor = colorOscuro;

                }
                else
                {
                    dgMovimientos.Rows.Add(movimiento.TipoMovimiento, movimiento.NombreUsuario, movimiento.DniUsuario, movimiento.NombreVisitante, movimiento.DniVisitante, movimiento.Fecha, movimiento.Observaciones);

                }
            }
        }

        private void dtFechaMovimeintos_ValueChanged(object sender, EventArgs e)
        {
            FiltrarMovimientosPorFecha();
        }

        private void FiltrarMovimientosPorFecha()
        {
            DateTime fechaDesde = dtFechaDesde.Value.Date;
            DateTime fechaHasta = dtFechaHasta.Value.Date;

            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show("La fecha de inicio debe ser anterior o igual a la fecha de fin.", "Error de rango de fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListaMovimientos = movimientos?.Where(m => m.Fecha >= fechaDesde && m.Fecha <= fechaHasta).ToList();

            CargarMovimientos();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            dtFechaHasta.Value = DateTime.Now;
            dtFechaDesde.Value = DateTime.Now;
           
            movimientos = egresosRepositorio.ObtenerMovimientos().Union(ingresosRepositorio.ObtenerMovimientos()).OrderByDescending(m => m.Fecha).ToList();
            ListaMovimientos = movimientos;
            movimeintosBackUp = ListaMovimientos;
            cbFiltrarMovimientos.SelectedIndex = -1;
            cbFiltrarMovimientos.Text = "Tipo";
            
            CargarMovimientos();
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

            if (orden == "descendente")
            {
                orden = "ascendente";
                ListaMovimientos = ListaMovimientos.OrderBy(m => m.Fecha).ToList();
                iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ArrowUpWideShort;
            }
            else
            {
                orden = "descendente";
                ListaMovimientos = ListaMovimientos.OrderByDescending(m => m.Fecha).ToList();
                iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ArrowDownWideShort;
            }

            CargarMovimientos();
        }

        private void cbFiltrarMovimientos_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Movimiento>? movimientosFiltrar = movimeintosBackUp;
            string tipoSeleccionado = cbFiltrarMovimientos.SelectedItem.ToString();
            if (tipoSeleccionado != "Tipo")
            {
                //que guarde en usuariosFiltrar todos los usuarios de usuariosFiltrar que tengan el rol seleccionado en el comboBox
                movimientosFiltrar = movimientosFiltrar?.Where(m => m.TipoMovimiento == tipoSeleccionado).ToList();
            }

            ListaMovimientos = movimientosFiltrar;
            movimientos = movimientosFiltrar;
            CargarMovimientos();
        }

        private void tbBuscarUsuario__TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbBuscarUsuario.Texts))
            {
                if (Regex.IsMatch(tbBuscarUsuario.Texts, @"^\d+$"))
                {
                    ListaMovimientos = movimientos?.Where(m => m.DniVisitante.Contains(tbBuscarUsuario.Texts!)).ToList();
                }
                else
                {
                    ListaMovimientos = movimientos?.Where(m => m.NombreUsuario.ToLowerInvariant().Contains(tbBuscarUsuario.Texts!.ToLowerInvariant())).ToList();

                }
            }
            else
            {
                ListaMovimientos = movimientos;
            }
            this.CargarMovimientos();
        }

        private void dtFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            FiltrarMovimientosPorFecha();
        }
    }
}

