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

namespace seguridad_barrios_privados.Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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
                Validaciones.MostrarError("Complete todos los campos", lbError, ErrorIcon);
                return;
            }
            Form menuInicio = new MainForm();
            menuInicio.Show();
            this.Hide();


        }

        private void msgError(string msg)
        {
            lbError.Text = msg;
            lbError.Visible = true;
            ErrorIcon.Visible = true;
        }
    }
}
