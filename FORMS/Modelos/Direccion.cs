using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace seguridad_barrios_privados.Modelos;

public partial class Direccion
{
    public int IdDireccion { get; set; }

    public string Calle { get; set; } = null!;

    public string Altura { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();

    public string direccionCompleta=> $"{Calle} {Altura}";
}
