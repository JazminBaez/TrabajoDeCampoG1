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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace seguridad_barrios_privados.Presentacion
{

    public partial class FormReportesAdmin : Form
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
        private List<Egreso> Egresos;
        private List<Solicitude> Solicitudes;
        private string busquedaPrevia;
        public FormReportesAdmin()
        {
            InitializeComponent();
            solicitudesRepositorio = new SolicitudesRepositorio();
            egresosRepositorio = new EgresosRepositorio();
            ingresosRepositorio = new IngresosRepositorio();


            ListaIngresos = new List<Ingreso>();
            ListaBackup = new List<Ingreso>();
            Ingresos = new List<Ingreso>();
            Egresos = new List<Egreso>();
            Ingresos = ingresosRepositorio.ObtenerIngresos();
            ListaIngresos = Ingresos;
            ListaBackup = ListaIngresos;
            busquedaPrevia = string.Empty;

            Solicitudes = solicitudesRepositorio.ObtenerSolicitudes();
            Egresos = egresosRepositorio.ObtenerEgresos();
            MostrarGraficoIngresosPorVisitantes();


        }

        private void MostrarGraficoIngresosPorVisitantes()
        {
            var solicitudesPorEstado = Solicitudes.GroupBy(s => s.Estado)
       .Select(g => new { Estado = g.Key, Cantidad = g.Count() })
       .ToList();

            foreach (var solicitudPorEstado in solicitudesPorEstado)
            {
                MessageBox.Show(solicitudPorEstado.Estado + " : " + solicitudPorEstado.Cantidad.ToString());
            }


            var chart = new Chart();
            chart.Width = 300;
            chart.Height = 300;
          
            // Crear un área de gráfico
            var chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            // Crear la serie para el gráfico circular
            var series = new Series("Estado de Solicitudes");
            series.ChartType = SeriesChartType.Pie;

            foreach (var estado in solicitudesPorEstado)
            {
                series.Points.AddXY(estado.Estado, estado.Cantidad);
            }

            chart.Series.Add(series);

            var form = new Form();
            chart.Dock = DockStyle.Fill;
            form.Controls.Add(chart);
            form.ShowDialog();
        }



        private void FormReportesAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
