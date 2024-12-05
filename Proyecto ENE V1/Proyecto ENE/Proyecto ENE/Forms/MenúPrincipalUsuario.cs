using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_ENE.Forms
{
    public partial class MenúPrincipalUsuario : Form
    {
        public MenúPrincipalUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListaTrabajadorSueldo f = new ListaTrabajadorSueldo();
            f.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();    
        }
    }
}
