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

    public partial class FormEgresos : Form
    {
        private UsuariosRepositorio usuariosRepositorio;
        private Validaciones validaciones;
        private SolicitudesRepositorio solicitudesRepositorio;
        private VisitantesRepositorio visitantesRepositorio;
        private EgresosRepositorio egresosRepositorio;
        private IngresosRepositorio ingresosRepositorio;
        private Ingreso ingreso;
        private List<Ingreso> ListaIngresos;
        private List<Ingreso> ListaBackup;
        private List<Ingreso> Ingresos;
        private string busquedaPrevia;
        public FormEgresos()
        {
            InitializeComponent();
            solicitudesRepositorio = new SolicitudesRepositorio();
            egresosRepositorio = new EgresosRepositorio();
            ingresosRepositorio = new IngresosRepositorio();


            ListaIngresos = new List<Ingreso>();
            ListaBackup = new List<Ingreso>();
            Ingresos = new List<Ingreso>();
            Ingresos = ingresosRepositorio.ObtenerIngresos();
            ListaIngresos = Ingresos;
            ListaBackup = ListaIngresos;
            busquedaPrevia = string.Empty;
            CargarIngresos();
        }

        private void CargarIngresos()
        {
            List<Egreso> egresos = egresosRepositorio.ObtenerEgresos();
     
            dgSolicitudes.Rows.Clear();
            dgSolicitudes.Refresh();
            var fechaHoy = DateTime.Today;

            foreach (Ingreso ingreso in ListaIngresos)
            {
                if (!(egresos.Any(egreso => egreso.IdIngreso == ingreso.IdIngreso)))
                {
                    //agregelo al datagridview
                    dgSolicitudes.Rows.Add(ingreso.IdIngreso, ingreso.IdSolicitudNavigation.IdUsuarioNavigation.NombreCompleto, ingreso.IdSolicitudNavigation.IdVisitanteNavigation.NombreCompleto, ingreso.IdSolicitudNavigation.IdVisitanteNavigation.Dni, ingreso.IdSolicitudNavigation.Fecha);
                    continue;
                }
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
                    ListaIngresos = Ingresos?.Where(u => u.IdSolicitudNavigation.IdVisitanteNavigation.Dni.Contains(tbBuscarUsuario.Texts!)).ToList();
                }
                else
                {
                    ListaIngresos =Ingresos?.Where(u => u.IdSolicitudNavigation.IdVisitanteNavigation.Nombre.ToLowerInvariant().Contains(tbBuscarUsuario.Texts!.ToLowerInvariant()) || u.IdSolicitudNavigation.IdVisitanteNavigation.Apellido.ToLowerInvariant().Contains(tbBuscarUsuario.Texts!.ToLowerInvariant())).ToList();

                }
            }
            else
            {
                ListaIngresos =Ingresos;
            }

            this.CargarIngresos();
        }
    }
}
