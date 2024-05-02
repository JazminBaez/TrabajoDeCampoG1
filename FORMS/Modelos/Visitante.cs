using System;
using System.Collections.Generic;

namespace seguridad_barrios_privados.Modelos;

public partial class Visitante
{
    public int IdVisitante { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Dni { get; set; } = null!;

    public virtual ICollection<Solicitud> Solicituds { get; set; } = new List<Solicitud>();
    public string NombreCompleto => $"{Nombre} {Apellido}";
}
