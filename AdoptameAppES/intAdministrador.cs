using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoptameAppES
{
    public partial class intAdministrador : Form
    {
        // nota cambiar los iconos de editar usuario  y eliminar usuario, tambien añadir el icono de generar usuario 

        public intAdministrador()
        {
            InitializeComponent();
            CBTipoUsuario.Items.Add("Administrador");
            CBTipoUsuario.Items.Add("Usuario");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eliminarUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
