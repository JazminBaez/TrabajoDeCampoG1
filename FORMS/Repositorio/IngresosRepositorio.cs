using seguridad_barrios_privados.Models;
using seguridad_barrios_privados.Util;
using System;
using System.Collections.Generic;
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
            var ingreso = new Ingreso()
            {
                IdSolicitud = solicitud,

                Fecha = DateTime.Today
            };

            barriosPrivadosContext.Ingresos.Add(ingreso);
            barriosPrivadosContext.SaveChanges();

        }

    }
}
