using seguridad_barrios_privados.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seguridad_barrios_privados.Util
{
    public static class Contexto
    {
        public static DbBarriosPrivadosContext? dbBarriosPrivadosContext { get; set; }
    }
}
