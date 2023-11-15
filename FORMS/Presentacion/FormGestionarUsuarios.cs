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
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Text.RegularExpressions;

namespace seguridad_barrios_privados.Presentacion
{

    public partial class FormGestionarUsuarios : Form
    {
        private UsuariosRepositorio usuariosRepositorio;
        private RolesRepositorio rolesRepositorio;
        private Validaciones validaciones;
        private string correoOriginal;
        private int usuarioId;
        private List<Usuario> ListaUsuarios;
        private List<Usuario> ListaBackup;
        private List<Usuario> Usuarios;
        private string busquedaPrevia;

        public FormGestionarUsuarios()
        {

            InitializeComponent();
            usuariosRepositorio = new UsuariosRepositorio();
            rolesRepositorio = new RolesRepositorio();
            validaciones = new Validaciones();

            cbRol.DisplayMember = "rolcompleto";
            cbFiltrarUsuarios.DisplayMember = "rolcompleto";

            foreach (Role rol in rolesRepositorio.ObtenerRoles())
            {
                cbRol.Items.Add(rol);
                cbFiltrarUsuarios.Items.Add(rol);
            }


            ListaUsuarios = new List<Usuario>();
            ListaBackup = new List<Usuario>();
            Usuarios = new List<Usuario>();
            Usuarios = usuariosRepositorio.ObtenerUsuarios();
            ListaUsuarios = Usuarios;
            ListaBackup = ListaUsuarios;
            busquedaPrevia = string.Empty;
            CargarUsuarios();

            //que imprima por consola el tamaño del formulario 
            Console.WriteLine("el tamaño es :" + this.Size);


        }

        private void CargarUsuarios()
        {

            dgUsuarios.Rows.Clear();
            dgUsuarios.Refresh();
            foreach (Usuario usuario in ListaUsuarios)
            {

                if (usuario.Estado == 1)
                {
                    dgUsuarios.Rows.Add(usuario.IdUsuario, usuario.Rol.Descripcion, usuario.NombreCompleto, usuario.Dni, usuario.Telefono, usuario.Direccion, usuario.Email, "Activar", "Modificar");
                    Color colorOscuro = Color.FromArgb(25, 46, 71);
                    Color colorTexto = Color.FromArgb(45, 66, 91);
                    dgUsuarios.Rows[dgUsuarios.Rows.Count - 1].DefaultCellStyle.BackColor = colorOscuro;
                    dgUsuarios.Rows[dgUsuarios.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.LightGray; // Configura el color del texto

                    continue;
                }
                dgUsuarios.Rows.Add(usuario.IdUsuario, usuario.Rol.Descripcion, usuario.NombreCompleto, usuario.Dni, usuario.Telefono, usuario.Direccion, usuario.Email, "Dar Baja", "Modificar");
            }
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {



        }


        private void string_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
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
                cbRol.Text = "Rol";
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
                if (usuario.Estado == 1)
                {
                    usuario.Estado = 0;
                }
                else
                {
                    usuario.Estado = 1;
                }
                usuarioId = usuario.IdUsuario;
                usuariosRepositorio.ActualizarUsuario(usuario, usuarioId);
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
                tbContrasena.BackColor = Color.LightGray;
                tbRepetirContrasena.Enabled = false;
                tbRepetirContrasena.BackColor = Color.LightGray;
                cbRol.SelectedItem = usuario.Rol;
                //cambie el texto del boton registrar por modificar
                btRegistrar.Text = "GUARDAR";
                //cambie el evento click del boton registrar por modificar
                btRegistrar.Click -= btRegistrar_Click;
                btRegistrar.Click += btModificar_Click;
                //haz visible el boton cancelar
                btCancelar.Visible = true;

                correoOriginal = usuario.Email;
                usuarioId = usuario.IdUsuario;

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
                Estado = usuariosRepositorio.ObtenerUsuarioPorId(usuarioId).Estado,
                IdRol = rol != null ? rol.IdRol : null,
            };
            if (validaciones.ModificarUsuario(usuario, correoOriginal, lbError, ErrorIcon, dgUsuarios))
            {
                usuariosRepositorio.ActualizarUsuario(usuario, usuarioId);
                MessageBox.Show("Usuario Actualizado con exito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarUsuarios();
                RestablecerFormulario(lbError, ErrorIcon, tbNombre, tbApellido, tbTelefono, tbDireccion, tbContrasena, tbRepetirContrasena, tbCorreo);
                cbRol.SelectedIndex = -1;
                btCancelar.Visible = false;
                btRegistrar.Text = "REGISTRAR";
                tbContrasena.Enabled = true;
                tbRepetirContrasena.Enabled = true;
                tbContrasena.BackColor = Color.White;
                tbRepetirContrasena.BackColor = Color.White;
                cbRol.SelectedIndex = -1;
                cbRol.Text = "Rol";
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            RestablecerFormulario(lbError, ErrorIcon, tbNombre, tbApellido, tbTelefono, tbDireccion, tbContrasena, tbRepetirContrasena, tbCorreo);
            cbRol.SelectedIndex = -1;
            btCancelar.Visible = false;
            btRegistrar.Text = "REGISTRAR";
            tbContrasena.Enabled = false;
            tbRepetirContrasena.Enabled = false;
            tbContrasena.BackColor = Color.White;
            tbRepetirContrasena.BackColor = Color.White;

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

            RestablecerFormulario(lbError, ErrorIcon, tbNombre, tbBuscarUsuario, tbApellido, tbTelefono, tbDireccion, tbContrasena, tbRepetirContrasena, tbCorreo);
            cbRol.SelectedIndex = -1;
            cbRol.Text = "Rol";
            cbFiltrarUsuarios.SelectedIndex = -1;
            cbFiltrarUsuarios.Text = "Rol";
            Usuarios = ListaBackup;
            ListaUsuarios = Usuarios;
            CargarUsuarios();
        }

        private void cbFiltrarUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Usuario>? usuariosFiltrar = ListaBackup;
            tbBuscarUsuario.Texts = string.Empty;
            int rolSeleccionado = cbFiltrarUsuarios.SelectedIndex + 1;
            if (cbFiltrarUsuarios.SelectedText != "Rol")
            {
                //que guarde en usuariosFiltrar todos los usuarios de usuariosFiltrar que tengan el rol seleccionado en el comboBox
                usuariosFiltrar = usuariosFiltrar?.Where(u => u.IdRol == rolSeleccionado).ToList();
            }

            ListaUsuarios = usuariosFiltrar;
            Usuarios = usuariosFiltrar;
            CargarUsuarios();
        }

        private void tbBuscarUsuario__TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbBuscarUsuario.Texts))
            {
                if (Regex.IsMatch(tbBuscarUsuario.Texts, @"^\d+$"))
                {
                    ListaUsuarios = Usuarios?.Where(u => u.Dni.Contains(tbBuscarUsuario.Texts!)).ToList();
                }
                else
                {
                    ListaUsuarios = Usuarios?.Where(u => u.Nombre.ToLowerInvariant().Contains(tbBuscarUsuario.Texts!.ToLowerInvariant()) || u.Apellido.ToLowerInvariant().Contains(tbBuscarUsuario.Texts!.ToLowerInvariant())).ToList();

                }
            }
            else
            {
                ListaUsuarios = Usuarios;
            }
            this.CargarUsuarios();
        }
    }
}
