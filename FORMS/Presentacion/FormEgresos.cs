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
        private EgresosRepositorio egresosRepositorio;
        private IngresosRepositorio ingresosRepositorio;
        private Ingreso ingreso;
        public FormEgresos()
        {
            InitializeComponent();
            solicitudesRepositorio = new SolicitudesRepositorio();
            egresosRepositorio = new EgresosRepositorio();
            ingresosRepositorio = new IngresosRepositorio();
            CargarIngresos();
        }

        private void CargarIngresos()
        {
            List<Egreso> egresos = egresosRepositorio.ObtenerEgresos();
            List<Ingreso> ingresos = ingresosRepositorio.ObtenerIngresos();
            dgSolicitudes.Rows.Clear();
            dgSolicitudes.Refresh();
            var fechaHoy = DateTime.Today;

            foreach (Ingreso ingreso in ingresos)
            {
               //por cada ingreso debe verificar si en la lista de egresos hay alguno cuya IdIngreso sea igual a la IdIngreso del ingreso (la lista de egresos puede ser nula)
            if (!(egresos.Any(egreso => egreso.IdIngreso == ingreso.IdIngreso)))
             {
                    //agregelo al datagridview
                    dgSolicitudes.Rows.Add(ingreso.IdIngreso, ingreso.IdSolicitudNavigation.IdVisitanteNavigation.NombreCompleto, ingreso.IdSolicitudNavigation.IdVisitanteNavigation.NombreCompleto, ingreso.IdSolicitudNavigation.IdVisitanteNavigation.Dni, ingreso.IdSolicitudNavigation.Fecha);
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
    }
}
