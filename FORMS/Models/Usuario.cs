using System;
using System.Collections.Generic;

namespace seguridad_barrios_privados.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Email { get; set; }

    public string? Contrasena { get; set; }

    public string? Telefono { get; set; }

    public int? IdRol { get; set; }

    public string? Direccion { get; set; }

    public virtual Role? Rol { get; set; }

    public virtual ICollection<Solicitude> Solicitudes { get; set; } = new List<Solicitude>();

    public string NombreCompleto => $"{Nombre} {Apellido}";
    public string Datos => $"{Nombre} {Apellido} {Direccion}";
}
