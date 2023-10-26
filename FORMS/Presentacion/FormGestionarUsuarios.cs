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

            cbRol.DisplayMember = "rolcompleto";

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

                if (usuario.Estado == 1)
                {
                    dgUsuarios.Rows.Add(usuario.IdUsuario, usuario.Nombre, usuario.Apellido, usuario.Telefono, usuario.Direccion, usuario.Email, "Activar","Modificar");
                    dgUsuarios.Rows[dgUsuarios.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightGray;
                }
                dgUsuarios.Rows.Add(usuario.IdUsuario, usuario.Nombre, usuario.Apellido, usuario.Telefono, usuario.Direccion, usuario.Email, "Eliminar", "Modificar");
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


            Role rol = (Role)cbRol.SelectedItem;

            var usuario = new Usuario()
            {
                Nombre = tbNombre.Texts,
                Apellido = tbApellido.Texts,
                Telefono = tbTelefono.Texts,
                Direccion = tbDireccion.Texts,
                Email = tbCorreo.Texts,
                Contrasena = tbContrasena.Texts,
                Estado = 0,
                IdRol = rol != null ? rol.IdRol : null,

            };

            if (validaciones.RegistrarUsuario(usuario, tbRepetirContrasena.Texts, lbError, ErrorIcon, dgUsuarios))
            {
                usuario.Contrasena = HashPasswordSHA256(tbContrasena.Texts);
                this.usuariosRepositorio.InsertarUsuario(usuario);
                MessageBox.Show("Usuario registrado con exito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarUsuarios();
                RestablecerFormulario(lbError, ErrorIcon, tbNombre, tbApellido, tbTelefono, tbDireccion, tbContrasena, tbRepetirContrasena, tbCorreo);
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
        static string HashPasswordSHA256(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {

                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                byte[] hashBytes = sha256.ComputeHash(passwordBytes);


                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    stringBuilder.Append(hashBytes[i].ToString("x2")); // "x2" para formato hexadecimal
                }

                return stringBuilder.ToString();
            }
        }

        private void dgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgUsuarios.Columns["CDarBaja"].Index)
            {

                var usuario = usuariosRepositorio.ObtenerUsuarioPorId(Convert.ToInt32(dgUsuarios.Rows[e.RowIndex].Cells[0].Value));
                usuario.Estado = 0;
                usuariosRepositorio.ActualizarUsuario(usuario);
                MessageBox.Show("Usuario dado de baja con exito", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarUsuarios();
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == dgUsuarios.Columns["CModificar"].Index)
            {
                var usuario = usuariosRepositorio.ObtenerUsuarioPorId(Convert.ToInt32(dgUsuarios.Rows[e.RowIndex].Cells[0].Value));
                //rellene todos los textBox con la informacion obtenida en la variable usuario
                tbNombre.Texts = usuario.Nombre;
                tbApellido.Texts = usuario.Apellido;
                tbTelefono.Texts = usuario.Telefono;
                tbDireccion.Texts = usuario.Direccion;
                tbCorreo.Texts = usuario.Email;
                //los campos de contrasena y repetirContrasena deben estar desabilitados
                tbContrasena.Enabled = false;
                tbRepetirContrasena.Enabled = false;
                cbRol.SelectedItem = usuario.Rol;
                //cambie el texto del boton registrar por modificar
                btRegistrar.Text = "Modificar";
                //cambie el evento click del boton registrar por modificar
                btRegistrar.Click -= btRegistrar_Click;
                btRegistrar.Click += btModificar_Click;
                //haz visible el boton cancelar
                btCancelar.Visible = true;


            }
        }


        private void btModificar_Click(object sender, EventArgs e)
        {
            Role rol = (Role)cbRol.SelectedItem;
            var usuario = new Usuario()
            {
                Nombre = tbNombre.Texts,
                Apellido = tbApellido.Texts,
                Telefono = tbTelefono.Texts,
                Direccion = tbDireccion.Texts,
                Email = tbCorreo.Texts,
                Contrasena = tbContrasena.Texts,
                Estado = 0,
                IdRol = rol != null ? rol.IdRol : null,
            };
            if (validaciones.ModificarUsuario(usuario, tbRepetirContrasena.Texts, lbError, ErrorIcon, dgUsuarios))
            {
                usuariosRepositorio.ActualizarUsuario(usuario);
                MessageBox.Show("Usuario Actualizado con exito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarUsuarios();
                RestablecerFormulario(lbError, ErrorIcon, tbNombre, tbApellido, tbTelefono, tbDireccion, tbContrasena, tbRepetirContrasena, tbCorreo);
                cbRol.SelectedIndex = -1;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            RestablecerFormulario(lbError, ErrorIcon, tbNombre, tbApellido, tbTelefono, tbDireccion, tbContrasena, tbRepetirContrasena, tbCorreo);
            cbRol.SelectedIndex = -1;
        }
    }
}
