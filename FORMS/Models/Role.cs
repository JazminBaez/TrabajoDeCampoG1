using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace seguridad_barrios_privados.Models;

public partial class Role
{
    public int IdRol { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();

    public string rolcompleto => $"{IdRol} - {Descripcion}";
}
