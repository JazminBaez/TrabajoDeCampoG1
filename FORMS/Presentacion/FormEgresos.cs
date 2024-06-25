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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace seguridad_barrios_privados.Presentacion
{

    public partial class FormEgresos : Form
    {
        private Validaciones validaciones;
        private SolicitudesRepositorio solicitudesRepositorio;
        private VisitantesRepositorio visitantesRepositorio;
        private EgresosRepositorio egresosRepositorio;
        private IngresosRepositorio ingresosRepositorio;
        private Ingreso ingreso;
        private List<IngresoConDetalle> ListaIngresos;
        private List<IngresoConDetalle> ListaBackup;
        private List<IngresoConDetalle> Ingresos;
        private List<EgresoConDetalle> Egresos;
        private string busquedaPrevia;
        public FormEgresos()
        {
            InitializeComponent();
            solicitudesRepositorio = new SolicitudesRepositorio();
            egresosRepositorio = new EgresosRepositorio();
            ingresosRepositorio = new IngresosRepositorio();


            ListaIngresos = new List<IngresoConDetalle>();
            ListaBackup = new List<IngresoConDetalle>();
            Ingresos = new List<IngresoConDetalle>();
            Egresos = new List<EgresoConDetalle>();


            Ingresos = ingresosRepositorio.ObtenerIngresos();
            ListaIngresos = Ingresos;
            ListaBackup = ListaIngresos;
            busquedaPrevia = string.Empty;

            Egresos = egresosRepositorio.ObtenerEgresos();
            CargarIngresos();

            
        }

        private void CargarIngresos()
        {
            List<EgresoConDetalle> egresos = egresosRepositorio.ObtenerEgresos();

            List<IngresoConDetalle> ingresosSinEgreso = new List<IngresoConDetalle>();

            dgSolicitudes.Rows.Clear();
            dgSolicitudes.Refresh();
            var fechaHoy = DateTime.Today;

            foreach (IngresoConDetalle ingreso in ListaIngresos)
            {
                if (!(egresos.Any(egreso => egreso.id_ingreso == ingreso.id_ingreso)))
                {
                 
                    ingresosSinEgreso.Add(ingreso);
                    continue;
                }
            }

            ActualizarAspectoBotones(ingresosSinEgreso);

            foreach (IngresoConDetalle ingreso in ingresosSinEgreso)
            {
                dgSolicitudes.Rows.Add(ingreso.id_ingreso, ingreso.NombreCompletoUsuario, ingreso.NombreCompletoVisitante, ingreso.visitante_dni, ingreso.ingreso_fecha);
            }
            
        }

        private void ActualizarAspectoBotones(List<IngresoConDetalle> ingresosSinEgreso)
        {
            if (ingresosSinEgreso.Count == 0)
            {
                btRegistrarEgreso.Enabled = false;
                tbObservaciones.Enabled = false;
                btRegistrarEgreso.BackColor = Color.Gray;
                tbObservaciones.BackColor = Color.Gray;

            }
            else
            {
                btRegistrarEgreso.Enabled = true;
                tbObservaciones.Enabled = true;
                btRegistrarEgreso.BackColor = SystemColors.Window;
                tbObservaciones.BackColor = SystemColors.Window;
            }
        }

        private void dgSolicitudes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgSolicitudes.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["CSeleccionar"];
                checkBoxCell.Value = false;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgSolicitudes.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgSolicitudes.SelectedRows[0];
                
                ingreso = ingresosRepositorio.ObtenerIngreso(Convert.ToInt32(selectedRow.Cells[0].Value));
       
            }
        }




        private void btRegistrarEgreso_Click(object sender, EventArgs e)
        {
            if(ingreso == null)
            {
                MessageBox.Show("Seleccione un visitante a egresar", "Egreso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            if (egresosRepositorio.RegistrarEgreso(ingreso.IdIngreso, tbObservaciones.Texts))
            {
                MessageBox.Show("Egreso Registrado exitosamente", "Egreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbObservaciones.Texts = "";
            }

            CargarIngresos();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbBuscarUsuario__TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbBuscarUsuario.Texts))
            {
                if (Regex.IsMatch(tbBuscarUsuario.Texts, @"^\d+$"))
                {
                    ListaIngresos = Ingresos?.Where(u => u.visitante_dni.Contains(tbBuscarUsuario.Texts!)).ToList();
                }
                else
                {
                    ListaIngresos = Ingresos?.Where(u => u.visitante_nombre.ToLowerInvariant().Contains(tbBuscarUsuario.Texts!.ToLowerInvariant()) ||
                    u.visitante_apellido.ToLowerInvariant().Contains(tbBuscarUsuario.Texts!.ToLowerInvariant())).ToList();

                }
            }
            else
            {
                ListaIngresos = Ingresos;
            }

            this.CargarIngresos();
        }

        private void dgSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ckbFiltrarVisitas_CheckedChanged(object sender, EventArgs e)
        {
            List<IngresoConDetalle>? ingresosFiltrar = ListaBackup;
            tbBuscarUsuario.Texts = string.Empty;
            List<IngresoConDetalle> ListaIngresosSinEgreso = new List<IngresoConDetalle>();
            List<IngresoConDetalle> Listafiltrada = new List<IngresoConDetalle>();

            foreach (IngresoConDetalle ingreso in ingresosFiltrar)
            {
                if (!(Egresos.Any(egreso => egreso.id_ingreso == ingreso.id_ingreso)))
                {
                    ListaIngresosSinEgreso.Add(ingreso);
                    continue;
                }
            }

            if (ckbFiltrarVisitas.Checked)
            {

                ingresosFiltrar = ListaIngresosSinEgreso?.Where(i => i.ingreso_fecha.AddDays(3) < DateTime.Today).ToList();

            }


            ListaIngresos = ingresosFiltrar;
            Ingresos = ingresosFiltrar;

            CargarIngresos();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

            Ingresos = ingresosRepositorio.ObtenerIngresos();
            ListaIngresos = Ingresos;
            ListaBackup = ListaIngresos;
            ckbFiltrarVisitas.Checked = false;
            CargarIngresos();
        }
    }
}
