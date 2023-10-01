using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using seguridad_barrios_privados.Logica;
using seguridad_barrios_privados.Models;
using seguridad_barrios_privados.Repositorio;

namespace seguridad_barrios_privados.Presentacion
{

    public partial class FormIngresos : Form
    {
        private UsuariosRepositorio usuariosRepositorio;
        private Validaciones validaciones;
        public FormIngresos()
        {
            InitializeComponent();
            usuariosRepositorio = new UsuariosRepositorio();
            validaciones = new Validaciones();

            cbPropietarios.DisplayMember = "Nombre";
            foreach (Usuario usuario in usuariosRepositorio.ObtenerUsuariosPorId(1))
            {
                cbPropietarios.Items.Add(usuario);
            }
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
            var visitante = new Visitante()
            {
                Nombre = tbNombre.Texts,
                Apellido = tbApellido.Texts,
                Dni = tbDni.Texts
            };




            if (validaciones.RegistrarIngreso(visitante,))
            {

            }
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Validaciones.CamposCompletos(tbBuscarSolicitud))
            {
                //buscar usuario
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void usuariosRepositorioBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            
        }
    }
}
