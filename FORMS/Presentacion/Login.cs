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

            Form menuInicio = new MainForm();
            menuInicio.Show();
            this.Hide();
            lbError.Text = "ERROR";
            lbError.Visible = true;
            ErrorIcon.Visible = true;

        }

        private void msgError(string msg)
        {
            lbError.Text = msg;
            lbError.Visible = true;
            ErrorIcon.Visible = true;
        }
    }
}
