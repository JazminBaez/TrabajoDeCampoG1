using seguridad_barrios_privados.Modelos;
using seguridad_barrios_privados.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seguridad_barrios_privados.Repositorio
{
    public class DireccionRepositorio
    {
        private DbBarriosPrivadosContext barriosPrivadosContext;

        public DireccionRepositorio()
        {
            barriosPrivadosContext = Contexto.dbBarriosPrivadosContext!;
        }
        public Direccion RegistrarDireccion(Direccion direccion)
        {
            barriosPrivadosContext.Direcciones.Add(direccion);
            barriosPrivadosContext.SaveChanges();
            return direccion;
        }
    }
}
