using seguridad_barrios_privados.Logica;
using seguridad_barrios_privados.Modelos;
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
        private BackupRepositorio backupRepositorio;
        private Ingreso ingreso;
        private List<Ingreso> ListaIngresos;
        private List<Ingreso> ListaBackup;
        private List<Ingreso> Ingresos;
        private List<Egreso> Egresos;
        private List<Solicitud> Solicitudes;
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
            backupRepositorio = new BackupRepositorio();


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
            TopPropietariosPorSemana();
            CargarTargetas();

            btnRestoreBuscar.Visible = false;
            btnRestoreDatabase.Visible = false;

        }

        private void CargarTargetas()
        {

         var cantidadDePropietarios = usuariosRepositorio.ObtenerUsuarios().Where(u => u.IdRol == 1 && u.Estado != 1).Count();
           tgUsuarios.Text = cantidadDePropietarios.ToString() + "\r\nPROPIETARIOS";

            var catidadDeGuardias = usuariosRepositorio.ObtenerUsuarios().Where(u => u.IdRol == 3 && u.Estado != 1).Count();
            tgVisitantes.Text = catidadDeGuardias.ToString() + "\r\nGUARDIAS";

           var promedioIngresosPorDia = ingresosRepositorio.ObtenerIngresos().GroupBy(i => i.Fecha.Date).Select(g => new { Fecha = g.Key, Cantidad = g.Count() }).Average(i => i.Cantidad);
            promedioIngresosPorDia = Math.Round(promedioIngresosPorDia, 1);
            tgPromedioDiario.Text = "PROMEDIO DIARIO DE INGRESOS: " + promedioIngresosPorDia.ToString();

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
            DistribucionMovimientos.ChartAreas[0].AxisX.LabelStyle.Angle = -90;


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
            DistribucionMovimientos.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
        }

        private void TopPropietariosPorSemana()
        {
            var visitasPorPropietarioYSemana = movimientos
                .Where(m => m.TipoMovimiento == "Ingreso")
                .GroupBy(m => new { m.NombreUsuario, Semana = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(m.Fecha, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday) })
                .Select(g => new
                {
                    Propietario = g.Key.NombreUsuario,
                    Semana = g.Key.Semana,
                    Visitas = g.Count()
                });

            Console.WriteLine("Agrupar por Propietario y Semana:\r\nAgrupa los movimientos por el propietario y la semana.\r\nCalcula la cantidad de visitas para cada propietario en cada semana.");
            foreach (var item in visitasPorPropietarioYSemana)
            {
                Console.WriteLine(item);
            }

            var promedioPorPropietario = visitasPorPropietarioYSemana
                .GroupBy(v => v.Propietario)
                .Select(g => new
                {
                    Propietario = g.Key,
                    PromedioVisitas = g.Average(v => v.Visitas)
                });

            Console.WriteLine("Calcular Promedio por Propietario:\r\nCalcula el promedio de visitas por semana para cada propietario.");
            foreach (var item in promedioPorPropietario)
            {
                Console.WriteLine(item);
            }

            var top3Propietarios = promedioPorPropietario
                .OrderByDescending(p => p.PromedioVisitas)
                .Take(3);

            Console.WriteLine("Top 3 Propietarios:\r\nOrdena los propietarios por el promedio de visitas por semana de forma descendente.\r\nToma los primeros 3 propietarios.");
            foreach (var item in top3Propietarios)
            {
                Console.WriteLine(item);
            }

            topPropietarios.Series.Clear();
            var propietarios = new Series("Promedio visitas \r\n por semana");
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
        }


        private void topPropietarios_Click(object sender, EventArgs e)
        {

        }

        private void btnBackupBuscar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbUbicacion.Texts = dlg.SelectedPath;

            }
        }

        private void btnRestoreBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Backup files (*.bak)|*.bak";
            dlg.Title = "Seleccionar archivo";
            dlg.RestoreDirectory = true;
            dlg.CheckFileExists = true;
            dlg.CheckPathExists = true;
            dlg.Multiselect = false;
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbUbicacion.Texts = dlg.FileName;
            }
        }

        private async void btnBackup_Click(object sender, EventArgs e)
        {
            if (tbUbicacion.Texts != string.Empty)
            {

                await backupRepositorio.Backup(tbUbicacion.Texts);

            }
            else
            {
                MessageBox.Show("Debe seleccionar una ubicación", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tbUbicacion.Texts = string.Empty;
        }

        private async void btnRestore_Click(object sender, EventArgs e)
        {
            if (tbUbicacion.Text != string.Empty)
            {
                btnBackupBuscar.Enabled = false;
                btnBackupDatabase.Enabled = false;
                await backupRepositorio.Restore(tbUbicacion.Texts);
                btnBackupBuscar.Enabled = true;
                btnBackupDatabase.Enabled = true;

            }
            else
            {
                MessageBox.Show("Debe seleccionar un archivo", "Restore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbBaseDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBaseDatos.SelectedIndex == 0)
            {
                btnRestoreDatabase.Visible = false;
                btnRestoreBuscar.Visible = false;

                btnBackupDatabase.Visible = true;
                btnBackupBuscar.Visible = true;
                lBaseDatos.Text = "BACKUP";

            }
            else
            {
                btnRestoreDatabase.Visible = true;
                btnRestoreBuscar.Visible = true;

                btnBackupDatabase.Visible = false;
                btnBackupBuscar.Visible = false;
                lBaseDatos.Text = "RESTORE";
            }
        }

        private void tgIngresosHoy_Click(object sender, EventArgs e)
        {

        }
    }




}
