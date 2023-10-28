using seguridad_barrios_privados.Models;
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

        public bool RegistrarIngreso(int solicitud)
        {
            var ingreso = new Ingreso()
            {
                IdSolicitud = solicitud,
                Fecha = DateTime.Today
            };

            //agrega ese ingreso a la base de datos
            barriosPrivadosContext.Ingresos.Add(ingreso);
            barriosPrivadosContext.SaveChanges();
            return true;
        }

        public List<Visitante> prueba()
        {


            return barriosPrivadosContext.Visitantes.ToList();
        }

        public List<Solicitude> pruebaDos()
        {
            return barriosPrivadosContext.Solicitudes.ToList();
        }

        public List<Ingreso> ObtenerIngresos()
        {
            var solicitudes = pruebaDos();
            var visitantes = prueba();
            var ingresos = barriosPrivadosContext.Ingresos.Include(i => i.IdSolicitudNavigation.IdUsuarioNavigation).ToList();
            foreach (Ingreso ingreso in ingresos)
            {
                foreach (Solicitude solicitud in solicitudes)
                {
                    if (ingreso.IdSolicitud == solicitud.IdSolicitud)
                    {
                        ingreso.IdSolicitudNavigation = solicitud;
                    }
                }

            }
            return ingresos;
        }

        //obtenerIngresoPorId
        public Ingreso ObtenerIngreso(int id)
        {
            var ingreso = barriosPrivadosContext.Ingresos.Include(i => i.IdSolicitudNavigation.IdUsuarioNavigation).FirstOrDefault(i => i.IdIngreso == id);
            return ingreso;
        }


    }
}
