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

namespace seguridad_barrios_privados.Presentacion
{
    public partial class FormGestionarUsuarios : Form
    {
        public FormGestionarUsuarios()
        {
            InitializeComponent();


        }


        private void lbFiltrarUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //buscar usuario
        }

        private void tbApellido__TextChanged(object sender, EventArgs e)
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

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                // Si no es una letra ni Backspace, ignorar la tecla presionada
                e.Handled = true;
            }
        }

        private void tbCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
           
            if (Validaciones.CamposCompletos(lbError, ErrorIcon, tbNombre, tbApellido, tbTelefono, tbDireccion, tbCorreo, tbContrasena, tbRepetirContrasena))
            {

                if (Validaciones.CoincideContrasena(tbContrasena, tbRepetirContrasena, lbError) && Validaciones.CorreoValido(tbCorreo, lbError, ErrorIcon) && Validaciones.ContrasenaValida(tbContrasena, lbError, ErrorIcon))
                {
                  
                    MessageBox.Show("Usuario registrado con éxito.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgUsuarios.Rows.Add(false,"1",tbNombre.Texts, tbApellido.Texts, tbTelefono.Texts, tbDireccion.Texts, tbCorreo.Texts, "eliminar");
                    Validaciones.RestablecerFormulario(tbNombre, tbApellido, tbTelefono, tbDireccion, tbCorreo, tbContrasena, tbRepetirContrasena);
                }
            }

        }


    }
}
