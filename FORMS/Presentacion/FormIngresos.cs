using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seguridad_barrios_privados.Presentacion
{
    public partial class FormIngresos : Form
    {
        public FormIngresos()
        {
            InitializeComponent();
        }

        private void LRegistrarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void lbFiltrarUsuarios_Click(object sender, EventArgs e)
        {
        }

        private void dtFechaMovimeintos_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
        }

        private void tbApellido__TextChanged(object sender, EventArgs e)
        {
        }

        private void TBDireccion__TextChanged(object sender, EventArgs e)
        {
        }

        private void tbNombre__TextChanged(object sender, EventArgs e)
        {
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            {
                // Si no es una letra ni Backspace, ignorar la tecla presionada
                e.Handled = true;
            }
        }

        private void tbApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            {
                // Si no es una letra ni Backspace, ignorar la tecla presionada
                e.Handled = true;
            }
        }

        private void TBDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
