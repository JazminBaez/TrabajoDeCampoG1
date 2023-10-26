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
using System.Data;

namespace seguridad_barrios_privados.Repositorio
{

    public class UsuariosRepositorio
    {
        private DbBarriosPrivadosContext barriosPrivadosContext;

        public UsuariosRepositorio()
        {
            barriosPrivadosContext = Contexto.dbBarriosPrivadosContext!;
        }

        public void InsertarUsuario(Usuario user)
        {
            barriosPrivadosContext.Usuarios.Add(user);
            barriosPrivadosContext.SaveChanges();
        }

        /*public void InsertarRol()
        {
            Console.WriteLine("NUEVO ROL");
            Role role = new Role();
            role.Descripcion = "Hello";

            barriosPrivadosContext.Roles.Add(role);
            barriosPrivadosContext.SaveChanges();
        }*/

        public List<Usuario> ObtenerUsuarios()
        {

            return barriosPrivadosContext.Usuarios.Include(usuario => usuario.Rol).ToList();
        }

        public bool ExisteUsuario(string email)
        {

            /*barriosPrivadosContext.ChangeTracker.Clear();*/
            return barriosPrivadosContext.Usuarios.Any(u => u.Email == email);
        }

        public async Task<Usuario> ObtenerUsuario(string correo, string contrasena)
        {
            // Consulta LINQ para buscar un usuario por correo y contraseña
            var usuario = await barriosPrivadosContext.Usuarios
                .Where(u => u.Email == correo && u.Contrasena == contrasena)
                .FirstOrDefaultAsync();

            return usuario;
        }

        public List<Usuario> ObtenerUsuariosPorRol(int id)
        {
            return barriosPrivadosContext.Usuarios.Where(u => u.IdRol == id).ToList();
        }

        public Usuario getUsuarioByEmail(string email)
        {
            return barriosPrivadosContext.Usuarios.FirstOrDefault(u => u.Email == email);
        }

        public Usuario ObtenerUsuarioPorId(int id)
        {
            return barriosPrivadosContext.Usuarios.FirstOrDefault(u => u.IdUsuario == id);
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            barriosPrivadosContext.Usuarios.Update(usuario);
            barriosPrivadosContext.SaveChanges();
        }

    }
}
