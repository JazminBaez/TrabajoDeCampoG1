using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace seguridad_barrios_privados.Modelos
{
    public class IngresoConDetalle
    {
        [Key]
        public int id_ingreso { get; set; }
        public DateTime ingreso_fecha { get; set; }
        public int id_solicitud { get; set; }
        public int id_usuario { get; set; }
        public string usuario_nombre { get; set; }
        public string usuario_apellido { get; set; }
        public string usuario_dni { get; set; }
        public int id_visitante { get; set; }
        public string visitante_nombre { get; set; }
        public string visitante_apellido { get; set; }
        public string visitante_dni { get; set; }

        public string NombreCompletoUsuario => $"{usuario_nombre} {usuario_apellido}";
        public string NombreCompletoVisitante => $"{visitante_nombre} {visitante_apellido}";
    }

}
