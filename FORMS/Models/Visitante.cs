using System;
using System.Collections.Generic;

namespace seguridad_barrios_privados.Models;

public partial class Visitante
{
    public int IdVisitante { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Dni { get; set; }

    public virtual ICollection<Solicitude> Solicitudes { get; set; } = new List<Solicitude>();

    public string NombreCompleto => $"{Nombre} {Apellido}";
}
