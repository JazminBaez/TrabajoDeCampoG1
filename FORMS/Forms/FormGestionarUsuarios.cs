using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FORMS.Controls;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FORMS.Forms
{
    public partial class FormGestionarUsuarios : Form
    {
        public FormGestionarUsuarios()
        {
            InitializeComponent();
            dgUsuarios.Rows.Add("1", "jazmin", "baez", "3773561765", "Beltran 1279", "baezdjazmin@gmail.com", "Eliminar");

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
    }
}
