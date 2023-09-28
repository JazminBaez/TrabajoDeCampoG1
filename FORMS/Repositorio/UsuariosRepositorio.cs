using Microsoft.EntityFrameworkCore;
using seguridad_barrios_privados.Models;
using seguridad_barrios_privados.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using seguridad_barrios_privados.Logica;
using FontAwesome.Sharp;
using seguridad_barrios_privados.Presentacion;

namespace seguridad_barrios_privados.Repositorio
{

    public class UsuariosRepositorio
    {
        private DbBarriosPrivadosContext barriosPrivadosContext;

        public UsuariosRepositorio() {
            barriosPrivadosContext = Contexto.dbBarriosPrivadosContext!;
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return barriosPrivadosContext.Usuarios.Include(usuario=>usuario.Rol).ToList();
        }

        public bool ExisteUsuario(string email)
        {
            return barriosPrivadosContext.Usuarios.Any(u => u.Email == email);
        }
            
        


    }
}
