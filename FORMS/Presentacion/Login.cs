using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;
using seguridad_barrios_privados.Logica;
using seguridad_barrios_privados.Models;
using seguridad_barrios_privados.Repositorio;
using System.Security.Cryptography;
using seguridad_barrios_privados.Properties;

namespace seguridad_barrios_privados.Presentacion
{


    public partial class Login : Form
    {
        private UsuariosRepositorio usuariosRepositorio;
        private Validaciones validaciones;
        public Login()
        {
            InitializeComponent();
            this.usuariosRepositorio = new UsuariosRepositorio();
            tbCorreo.KeyPress += TextBox_KeyPress;
            tbContrasena.KeyPress += TextBox_KeyPress;

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btIniciarSesion.PerformClick();
            }
        }

        private void btIniciarSesion_Click(object sender, EventArgs e)
        {
            if (!(Validaciones.CamposCompletos(tbCorreo, tbContrasena)))
            {
                Validaciones.MostrarError("Complete todos los campos", lbError, ErrorIcon);
                Validaciones.MostrarError("Complete todos los campos", lbError, ErrorIcon);
                return;
            }
            else
            {
                
                var usuario = usuariosRepositorio.getUsuarioByEmail(tbCorreo.Texts);

                if (usuario != null)
                {

                    if (VerifyPassword(tbContrasena.Texts, usuario.Contrasena))
                    {
                        if(usuario.Estado == 1)
                        {
                            this.msgError("Usuario no registrado");
                        }
                        else
                        {
                            AppState.UsuarioActual = usuario;
                            Form menuInicio = new MainForm();
                            menuInicio.Show();
                            this.Hide();
                        }
                        
                    }
                    else
                    {
                        this.msgError("Contraseña incorrecta.");
                     
                    }


                }
                else
                {
                  
                    this.msgError("Usuario no registrado");
                }
            }

        }

        private void msgError(string msg)
        {
            lbError.Text = msg;
            lbError.Visible = true;
            ErrorIcon.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        static bool VerifyPassword(string password, string hashedPassword)
        {
            string hashedInputPassword = HashPasswordSHA256(password);
            return string.Equals(hashedInputPassword, hashedPassword, StringComparison.OrdinalIgnoreCase);
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

        private void loader_Click(object sender, EventArgs e)
        {

        }
    }
}
