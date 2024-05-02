using System;
using System.Collections.Generic;

namespace seguridad_barrios_privados.Modelos;

public partial class Ingreso
{
    public int IdIngreso { get; set; }

    public int IdSolicitud { get; set; }

    public DateTime Fecha { get; set; }

    public virtual ICollection<Egreso> Egresos { get; set; } = new List<Egreso>();

    public virtual Solicitud IdSolicitudNavigation { get; set; } = null!;
}
