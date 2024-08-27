using Microsoft.EntityFrameworkCore;
using seguridad_barrios_privados.Modelos;
using seguridad_barrios_privados.Properties;
using seguridad_barrios_privados.Util;

namespace seguridad_barrios_privados.Presentacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            string stringConection = Resources.conexion;
            DbContextOptionsBuilder<DbBarriosPrivadosContext> optionsBuilder = new();
            DbBarriosPrivadosContext dbBarriosPrivadosContext = new(optionsBuilder.UseSqlServer(stringConection).Options);

            Contexto.dbBarriosPrivadosContext = dbBarriosPrivadosContext;
            Console.WriteLine("en program" + Contexto.dbBarriosPrivadosContext.Database.GetDbConnection().ConnectionString);


            Application.Run(new Login());
        }
    }
}