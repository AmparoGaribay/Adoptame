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
    public partial class Form1 : Form
    {

        intAdministrador admin = new intAdministrador();
        intUsuario usuario = new intUsuario();
        formPersona pers = new formPersona();
        
            
        public void vacio()
        {
            txtUsuario.Text="";
            txtPassw.Text = "";
        }

       

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           pers.ShowDialog();

          //  admin.ShowDialog();    completo
          // usuario.ShowDialog(); completo

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        ///////////////////////////////
    }
}
