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

    }
}
