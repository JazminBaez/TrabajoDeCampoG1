using seguridad_barrios_privados.Logica;
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
    public partial class FormSolicitudes : Form
    {
        public FormSolicitudes()
        {
            InitializeComponent();
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
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                // Si no es una letra ni Backspace, ignorar la tecla presionada
                e.Handled = true;
            }
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            if (!(Validaciones.CamposCompletos(tbNombre, tbApellido, tbDni)))
            {
                Validaciones.MostrarError("Complete todos los campos", lbError, ErrorIcon);
            }

        }

        private void lbError_Click(object sender, EventArgs e)
        {

        }
    }
}
