using Proyecto_ENE.Forms;

namespace Proyecto_ENE
{
    public partial class Men�Principal : Form
    {
        public Men�Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarTrabajador f = new AgregarTrabajador();
            f.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }
    }
}
