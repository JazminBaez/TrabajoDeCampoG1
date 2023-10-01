using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using seguridad_barrios_privados.Controls;
using static System.Runtime.InteropServices.JavaScript.JSType;
using seguridad_barrios_privados.Logica;
using System.Drawing.Text;
using seguridad_barrios_privados.Repositorio;
using seguridad_barrios_privados.Models;
using FontAwesome.Sharp;
using System.Security.Cryptography;

namespace seguridad_barrios_privados.Presentacion
{
    public partial class FormGestionarUsuarios : Form
    {
        private UsuariosRepositorio usuariosRepositorio;
        private RolesRepositorio rolesRepositorio;
        private Validaciones validaciones;
        public FormGestionarUsuarios()
        {

            InitializeComponent();
            usuariosRepositorio = new UsuariosRepositorio();
            rolesRepositorio = new RolesRepositorio();
            validaciones = new Validaciones();

            cbRol.DisplayMember = "Descripcion";

            foreach (Role rol in rolesRepositorio.ObtenerRoles())
            {
                cbRol.Items.Add(rol);
            }



            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            List<Usuario> usuarios = usuariosRepositorio.ObtenerUsuarios();
            dgUsuarios.Rows.Clear();
            dgUsuarios.Refresh();
            foreach (Usuario usuario in usuarios)
            {
                dgUsuarios.Rows.Add(usuario.IdUsuario, usuario.Nombre, usuario.Apellido, usuario.Telefono, usuario.Direccion, usuario.Email, "Eliminar");
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Validaciones.CamposCompletos(tbBuscarUsuario))
            {
                //buscar usuario
            }
        }


        private void string_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            {
                // Si no es una letra ni Backspace, ignorar la tecla presionada
                e.Handled = true;
            }
        }

        private void number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                // Si no es una letra ni Backspace, ignorar la tecla presionada
                e.Handled = true;
            }
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {

            Role rol = (Role) cbRol.SelectedItem;

            var usuario = new Usuario()
            {
                Nombre = tbNombre.Texts,
                Apellido = tbApellido.Texts,
                Telefono = tbTelefono.Texts,
                Direccion = tbDireccion.Texts,
                Email = tbCorreo.Texts,
                Contrasena = tbContrasena.Texts,
                IdRol = rol.IdRol
            };

            if (validaciones.RegistrarUsuario(usuario, tbRepetirContrasena.Texts, lbError, ErrorIcon, dgUsuarios))
            {

                
                this.usuariosRepositorio.InsertarUsuario(usuario);
                RestablecerFormulario(lbError, ErrorIcon, tbNombre, tbApellido, tbTelefono, tbDireccion, tbContrasena, tbRepetirContrasena);
                cbRol.SelectedIndex = -1;
            }




        }

        private static void RestablecerFormulario(Label error, IconPictureBox errorIcon, params RJTextBox[] campos)
        {
            foreach (var campo in campos)
            {
                campo.Texts = string.Empty;
                campo.BorderColor = SystemColors.Window;
            }
            error.Visible = false;
            errorIcon.Visible = false;

        }

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
