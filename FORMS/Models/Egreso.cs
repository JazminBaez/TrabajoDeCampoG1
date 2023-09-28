using System;
using System.Collections.Generic;

namespace seguridad_barrios_privados.Models;

public partial class Egreso
{
    public int IdEgreso { get; set; }

    public int? IdIngreso { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Observaciones { get; set; }

    public virtual Ingreso? IdIngresoNavigation { get; set; }
}
