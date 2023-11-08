using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seguridad_barrios_privados.Models
{
    public class Movimiento
    {
        public string TipoMovimiento { get; set; }
        public string NombreUsuario { get; set; }
        public string NombreVisitante { get; set; }
        public string DniVisitante { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
