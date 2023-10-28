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

    public class EgresosRepositorio
    {
        private DbBarriosPrivadosContext barriosPrivadosContext;

        public EgresosRepositorio()
        {
            barriosPrivadosContext = Contexto.dbBarriosPrivadosContext!;
        }

        public bool RegistrarEgreso(int ingreso, string observaciones)
        {
            var egreso = new Egreso()
            {
                IdIngreso = ingreso,
                Fecha = DateTime.Today,
                Observaciones = observaciones,
            
            };

            //agrega ese ingreso a la base de datos
            barriosPrivadosContext.Egresos.Add(egreso);
            barriosPrivadosContext.SaveChanges();
            return true;
        }

        //listar todos los egresos de la tabla egresos
        public List<Egreso> ObtenerEgresos()
        {
            var egresos = barriosPrivadosContext.Egresos.ToList();
            return egresos;
        }

    }
}
