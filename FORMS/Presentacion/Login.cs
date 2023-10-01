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
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btIniciarSesion_Click(object sender, EventArgs e)
        {





            if (!(Validaciones.CamposCompletos(tbCorreo, tbContrasena)))
            {
                //Validaciones.MostrarError("Complete todos los campos", lbError, ErrorIcon);
                Validaciones.MostrarError("Complete todos los campos", lbError, ErrorIcon);
                return;
            }
            else
            {
                
                
                
                /*if (validaciones.LogearUsuario(tbCorreo.Texts, tbContrasena.Texts))
                {
                    var usuario = validaciones.LogearUsuario(tbCorreo.Texts, tbContrasena.Texts);


                    // Puedes almacenar el modelo de vista en TempData para pasarlo a la vista
                    TempData["UsuarioViewModel"] = new Usuario();

                    return RedirectToAction("Index", "Home"); // Redirige a la página principal
                    Form menuInicio = new MainForm();
                    menuInicio.Show();
                    this.Hide();
                }
                */



                Form menuInicio = new MainForm();
                menuInicio.Show();
                this.Hide();
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
    }
}
