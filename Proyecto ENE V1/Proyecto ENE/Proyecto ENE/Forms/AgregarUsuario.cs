using Proyecto_ENE.DataAccess;
using Proyecto_ENE.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_ENE.Forms
{
    public partial class AgregarUsuario : Form
    {
        private UsuarioService usuarioService = new UsuarioService();
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Usuario instanciaUsuario = new Usuario
            {
                clave = txt_clave.Text,
                tipo = cbx_Tipo.Text,
                usuario = txt_usuario.Text

            };
            try
            {
                usuarioService.AgregarUsuario(instanciaUsuario);
                MessageBox.Show("usuario ingresado correctamente");

                txt_usuario.Clear();
                txt_clave.Clear();
                cbx_Tipo.Text = "";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();    
            f.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
