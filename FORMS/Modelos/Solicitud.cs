using System;
using System.Collections.Generic;

namespace seguridad_barrios_privados.Modelos;

public partial class Solicitud
{
    public int IdSolicitud { get; set; }

    public int IdUsuario { get; set; }

    public int IdVisitante { get; set; }

    public int Estado { get; set; }

    public DateTime Fecha { get; set; }

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;

    public virtual Visitante IdVisitanteNavigation { get; set; } = null!;

    public virtual ICollection<Ingreso> Ingresos { get; set; } = new List<Ingreso>();
}
