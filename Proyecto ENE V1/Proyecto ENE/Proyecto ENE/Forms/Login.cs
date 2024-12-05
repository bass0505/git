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

namespace Proyecto_ENE.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            UsuarioService usuarioService = new UsuarioService();

            string usuariotxt = txt_usuario.Text;
            string clavetxt = txt_clave.Text;

            if (string.IsNullOrWhiteSpace(usuariotxt) || string.IsNullOrWhiteSpace(clavetxt))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            try
            {
                Usuario usuarioInstancia = usuarioService.ObtenerUsuarioPorUsuario(usuariotxt);

                if (usuarioInstancia == null)
                {
                    MessageBox.Show("El usuario no está registrado.");
                    return;
                }


                string nombreUsuario = usuarioInstancia.usuario;
                string clave = usuarioInstancia.clave;
                string tipo = usuarioInstancia.tipo;

                if (usuariotxt == nombreUsuario && clave == clavetxt)
                {
                    if (tipo == "Administrador")
                    {
                        MenúPrincipal f = new MenúPrincipal();
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MenúPrincipalUsuario f = new MenúPrincipalUsuario();
                        f.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("el usuario o la clave no son correcta");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar usuario " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarUsuario f = new AgregarUsuario();
            this.Hide();
            f.Show();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
