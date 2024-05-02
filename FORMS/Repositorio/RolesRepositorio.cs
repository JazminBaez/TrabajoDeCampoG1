using seguridad_barrios_privados.Modelos;
using seguridad_barrios_privados.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seguridad_barrios_privados.Repositorio
{
    public class RolesRepositorio
    {
        private DbBarriosPrivadosContext barriosPrivadosContext;

        public RolesRepositorio()
        {
            barriosPrivadosContext = Contexto.dbBarriosPrivadosContext!;
        }

        public List<Rol> ObtenerRoles()
        {
            return barriosPrivadosContext.Roles.ToList();
        }
    }
}
