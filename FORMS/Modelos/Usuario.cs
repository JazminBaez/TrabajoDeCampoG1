using System;
using System.Collections.Generic;

namespace seguridad_barrios_privados.Modelos;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Dni { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int Estado { get; set; }
    public string Contrasena { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public int IdRol { get; set; }

    public int IdDireccion { get; set; }

    public virtual Direccion IdDireccionNavigation { get; set; } = null!;

    public virtual Rol IdRolNavigation { get; set; } = null!;

    public virtual ICollection<Solicitud> Solicituds { get; set; } = new List<Solicitud>();
    public string NombreCompleto => $"{Nombre} {Apellido}";
    public string Datos => $"{Nombre} {Apellido} {Dni}";
}
