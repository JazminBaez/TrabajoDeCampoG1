using seguridad_barrios_privados.Logica;
using seguridad_barrios_privados.Models;
using seguridad_barrios_privados.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
        private List<Movimiento> movimientos;
        private List<Usuario> usuarios;
        public FormReportesAdmin()
        {
            InitializeComponent();
            solicitudesRepositorio = new SolicitudesRepositorio();
            egresosRepositorio = new EgresosRepositorio();
            ingresosRepositorio = new IngresosRepositorio();
            usuariosRepositorio = new UsuariosRepositorio();


            ListaIngresos = new List<Ingreso>();
            ListaBackup = new List<Ingreso>();
            Ingresos = new List<Ingreso>();
            Egresos = new List<Egreso>();
            usuarios = new List<Usuario>();
            Ingresos = ingresosRepositorio.ObtenerIngresos();
            ListaIngresos = Ingresos;
            ListaBackup = ListaIngresos;
            busquedaPrevia = string.Empty;
            usuarios = usuariosRepositorio.ObtenerUsuarios();
            Solicitudes = solicitudesRepositorio.ObtenerSolicitudes();
            Egresos = egresosRepositorio.ObtenerEgresos();
            movimientos = new List<Movimiento>();
            movimientos = egresosRepositorio.ObtenerMovimientos().Union(ingresosRepositorio.ObtenerMovimientos()).OrderByDescending(m => m.Fecha).ToList();

            MovimientosPorDia();
            TopPropietarios();
            CargarTargetas();
        }

        private void CargarTargetas()
        {

            var cantidadDePropietarios = usuariosRepositorio.ObtenerUsuarios().Where(u => u.IdRol == 1 && u.Estado != 1).Count();
            tgUsuarios.Text = cantidadDePropietarios.ToString() + "\r\nPROPIETARIOS";

            var catidadDeGuardias = usuariosRepositorio.ObtenerUsuarios().Where(u => u.IdRol == 2 && u.Estado != 1).Count();
            tgVisitantes.Text = catidadDeGuardias.ToString() + "\r\nGUARDIAS";

            var promedioIngresosPorDia = ingresosRepositorio.ObtenerIngresos().GroupBy(i => i.Fecha.Date).Select(g => new { Fecha = g.Key, Cantidad = g.Count() }).Average(i => i.Cantidad);
            tgPromedioDiario.Text = "PROMEDIO DIARIO DE INGRESOS: " + promedioIngresosPorDia.ToString() +;

            var ingresosDeHoy = ingresosRepositorio.ObtenerIngresos().Where(i => i.Fecha.Date == DateTime.Today).Count();
            tgIngresosHoy.Text = ingresosDeHoy.ToString() + " INGRESOS REGISTRADOS";


            if (ingresosDeHoy < promedioIngresosPorDia)
            {
                tgIngresosHoy.ForeColor = Color.SeaGreen;
                tgIngresosHoy.IconColor = Color.SeaGreen;
            }
            else
            {
                tgIngresosHoy.ForeColor = Color.Firebrick;
                tgIngresosHoy.IconColor = Color.Firebrick;
                tgIngresosHoy.Text = ingresosDeHoy.ToString() + " INGRESOS - promedio superado";
            }

        }



        private void FormReportesAdmin_Load(object sender, EventArgs e)
        {

        }

        private void cbFiltroMovimientos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltroMovimientos.SelectedIndex == 0)
            {
                MovimientosPorDia();
            }
            else
            {
                MovimientosPorMes();
            }
        }



        private void MovimientosPorMes()
        {


            var nombresMeses = new Dictionary<int, string>
                {
                    { 1, "Enero" },
                    { 2, "Febrero" },
                    { 3, "Marzo" },
                    { 4, "Abril" },
                    { 5, "Mayo" },
                    { 6, "Junio" },
                    { 7, "Julio" },
                    { 8, "Agosto" },
                    { 9, "Septiembre" },
                    { 10, "Octubre" },
                    { 11, "Noviembre" },
                    { 12, "Diciembre" }
                };

            var todosLosMeses = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames.Take(12);

            var groupedMovimientos = movimientos
                .GroupBy(m => m.Fecha.Month)
                .Select(g => new
                {
                    Mes = g.Key,
                    Ingresos = g.Count(m => m.TipoMovimiento == "Ingreso"),
                    Egresos = g.Count(m => m.TipoMovimiento == "Egreso")
                })
                .OrderBy(g => g.Mes)
                .ToDictionary(g => g.Mes, g => g);

            DistribucionMovimientos.Series.Clear();

            var seriesIngresos = new Series("Ingresos");
            var seriesEgresos = new Series("Egresos");

            foreach (var mes in todosLosMeses)
            {

                int numeroMes = DateTime.ParseExact(mes, "MMMM", CultureInfo.CurrentCulture).Month;


                if (groupedMovimientos.TryGetValue(numeroMes, out var grupo))
                {
                    seriesIngresos.Points.AddXY(numeroMes, grupo.Ingresos);
                    seriesIngresos.Points.Last().AxisLabel = nombresMeses[numeroMes];
                    seriesEgresos.Points.AddXY(numeroMes, grupo.Egresos);

                }
                else
                {

                    seriesIngresos.Points.AddXY(numeroMes, 0);
                    seriesIngresos.Points.Last().AxisLabel = nombresMeses[numeroMes];
                    seriesEgresos.Points.AddXY(numeroMes, 0);
                }
            }

            DistribucionMovimientos.Series.Add(seriesIngresos);
            DistribucionMovimientos.Series.Add(seriesEgresos);

            DistribucionMovimientos.ChartAreas[0].AxisX.Interval = 1;
            DistribucionMovimientos.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            DistribucionMovimientos.ChartAreas[0].AxisX.Title = "Mes del año";
            DistribucionMovimientos.ChartAreas[0].AxisY.Title = "Cantidad";
            DistribucionMovimientos.ChartAreas[0].AxisX.LabelStyle.Angle = 45;


        }


        private void MovimientosPorDia()
        {
            var nombresDias = new Dictionary<DayOfWeek, string>
                {
                    { DayOfWeek.Sunday, "Domingo" },
                    { DayOfWeek.Monday, "Lunes" },
                    { DayOfWeek.Tuesday, "Martes" },
                    { DayOfWeek.Wednesday, "Miércoles" },
                    { DayOfWeek.Thursday, "Jueves" },
                    { DayOfWeek.Friday, "Viernes" },
                    { DayOfWeek.Saturday, "Sábado" }
                };
            var todosLosDias = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>();
            foreach (var item in todosLosDias)
            {
                Console.WriteLine(item);
            }
            var groupedMovimientos = movimientos
                .GroupBy(m => m.Fecha.DayOfWeek)
                .Select(g => new
                {
                    DiaSemana = g.Key,
                    Ingresos = g.Count(m => m.TipoMovimiento == "Ingreso"),
                    Egresos = g.Count(m => m.TipoMovimiento == "Egreso")
                })
                .OrderBy(g => g.DiaSemana)
                .ToDictionary(g => g.DiaSemana, g => g);

            foreach (var item in groupedMovimientos)
            {
                Console.WriteLine(item);
            }

            DistribucionMovimientos.Series.Clear();

            var seriesIngresos = new Series("Ingresos");
            var seriesEgresos = new Series("Egresos");

            foreach (var dia in todosLosDias)
            {
                if (groupedMovimientos.TryGetValue(dia, out var grupo))
                {
                    seriesIngresos.Points.AddXY((int)dia, grupo.Ingresos);

                    seriesIngresos.Points.Last().AxisLabel = nombresDias[dia];

                    seriesEgresos.Points.AddXY((int)dia, grupo.Egresos);
                    seriesEgresos.Points.Last().Label = grupo.Egresos.ToString();
                }
                else
                {
                    seriesIngresos.Points.AddXY((int)dia, 0);
                    seriesIngresos.Points.Last().AxisLabel = nombresDias[dia];
                    seriesEgresos.Points.AddXY((int)dia, 0);
                }


            }

            DistribucionMovimientos.Series.Add(seriesIngresos);
            DistribucionMovimientos.Series.Add(seriesEgresos);

            DistribucionMovimientos.ChartAreas[0].AxisX.Interval = 1;
            DistribucionMovimientos.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            DistribucionMovimientos.ChartAreas[0].AxisX.Title = "Día de la semana";
            DistribucionMovimientos.ChartAreas[0].AxisY.Title = "Cantidad";
            DistribucionMovimientos.ChartAreas[0].AxisX.LabelStyle.Angle = 45;
        }

        private void TopPropietarios()
        {
            var visitasPorPropietarioYDia = movimientos
            .Where(m => m.TipoMovimiento == "Ingreso")
            .GroupBy(m => new { m.NombreUsuario, Dia = m.Fecha.Date })
            .Select(g => new
            {
                Propietario = g.Key.NombreUsuario,
                Dia = g.Key.Dia,
                Visitas = g.Count()
            });

            //imprime  esto por consola
            //ponle titulo
            Console.WriteLine("Agrupar por Propietario y Día:\r\nAgrupa los movimientos por el propietario y el día.\r\nCalcula la cantidad de visitas para cada propietario en cada día.");
            foreach (var item in visitasPorPropietarioYDia)
            {
                Console.WriteLine(item);
            }

            var promedioPorPropietario = visitasPorPropietarioYDia
                .GroupBy(v => v.Propietario)
                .Select(g => new
                {
                    Propietario = g.Key,
                    PromedioVisitas = g.Average(v => v.Visitas)
                });

            //imprime  esto por consola
            Console.WriteLine("Calcular Promedio por Propietario:\r\nCalcula el promedio de visitas por día para cada propietario.");
            foreach (var item in promedioPorPropietario)
            {
                Console.WriteLine(item);
            }

            var top3Propietarios = promedioPorPropietario
             .OrderByDescending(p => p.PromedioVisitas)
             .Take(3);

            //imprime  esto por consola
            Console.WriteLine("Top 3 Propietarios:\r\nOrdena los propietarios por el promedio de visitas por día de forma descendente.\r\nToma los primeros 3 propietarios.");
            foreach (var item in top3Propietarios)
            {
                Console.WriteLine(item);
            }

            // Supongamos que tienes un objeto Chart llamado chartTopPropietarios en tu formulario.
            topPropietarios.Series.Clear();
            var propietarios = new Series("Promedio visitas \r\n por dia");
            propietarios.ChartType = SeriesChartType.Column;

            int desplazamientoX = 0;


            foreach (var propietario in top3Propietarios)
            {
                propietarios.Points.AddXY(desplazamientoX, propietario.PromedioVisitas);
                propietarios.Points.Last().AxisLabel = propietario.Propietario;
                desplazamientoX++;
            }
            topPropietarios.Series.Add(propietarios);
            topPropietarios.ChartAreas[0].AxisX.Interval = 1;
            topPropietarios.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            topPropietarios.ChartAreas[0].AxisX.Title = "Propietarios";
            topPropietarios.ChartAreas[0].AxisY.Title = "Promedio visitas por dia";
            //topPropietarios.ChartAreas[0].AxisX.LabelStyle.Angle = ;


        }

        private void topPropietarios_Click(object sender, EventArgs e)
        {

        }
    }




}
