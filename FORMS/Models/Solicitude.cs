using System;
using System.Collections.Generic;

namespace seguridad_barrios_privados.Models;

public partial class Solicitude
{
    public int IdSolicitud { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdVisitante { get; set; }

    public DateTime? Fecha { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }

    public virtual Visitante? IdVisitanteNavigation { get; set; }

    public virtual ICollection<Ingreso> Ingresos { get; set; } = new List<Ingreso>();
}
