using System;
using System.Collections.Generic;

namespace seguridad_barrios_privados.Modelos;

public partial class Rol
{
    public int IdRol { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
    public string rolcompleto => $"{Descripcion}";
}
