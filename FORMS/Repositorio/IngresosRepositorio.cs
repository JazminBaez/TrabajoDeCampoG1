using Microsoft.EntityFrameworkCore;
using seguridad_barrios_privados.Modelos;
using seguridad_barrios_privados.Util;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seguridad_barrios_privados.Repositorio
{

    public class IngresosRepositorio
    {
        private DbBarriosPrivadosContext barriosPrivadosContext;

        public IngresosRepositorio()
        {
            barriosPrivadosContext = Contexto.dbBarriosPrivadosContext!;
        }

      
        public void RegistrarIngreso(int solicitud)
        {
            //crea el ingreso y lo vincula con la solicitud correspondiente
            var ingreso = new Ingreso()
            {
                IdSolicitud = solicitud,
                Fecha = DateTime.Today
            };

            //lo registra
            try
            {
                barriosPrivadosContext.Ingresos.Add(ingreso);
                barriosPrivadosContext.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);

            }
           
        }

        public List<IngresoConDetalle> ObtenerIngresos()
        {
            try
            {
                using (var context = new DbBarriosPrivadosContext())
                {
                    var ingresos = barriosPrivadosContext.IngresoConDetalle
                    .FromSqlRaw("exec sp_ListarIngresosConDetalles")
                    .ToList();

                    return ingresos;
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return new List<IngresoConDetalle>();
            }
        }

       
        public Ingreso ObtenerIngreso(int id)
        {
           
            var ingreso = barriosPrivadosContext.Ingresos
                .Where(i => i.IdIngreso == id)
                .FirstOrDefault();
            return ingreso;
        }


    }
}
