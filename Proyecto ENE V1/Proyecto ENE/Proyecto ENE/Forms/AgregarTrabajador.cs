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
    public partial class AgregarTrabajador : Form
    {
        private ListaTrabajadores lista = new ListaTrabajadores();
        private TrabajadorService trabajadorService = new TrabajadorService();

        private void Limpiar()
        {
            txt_rut.Clear();
            txt_nombre.Clear();
            txt_direccion.Clear();
            txt_telefono.Clear();
            txt_valorHora.Clear();
            txt_valorHoraExtra.Clear();
        }



        public AgregarTrabajador()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Trabajador trabajadorCapa1 = new Trabajador
            {
                Rut = txt_rut.Text,
                Nombre = txt_nombre.Text,
                Direccion = txt_direccion.Text,
                Telefono = txt_telefono.Text,
                ValorHora = txt_valorHora.Text,
                ValorHoraExtra = txt_valorHoraExtra.Text,

            };
            try
            {
                trabajadorService.AgregarTrabajador(trabajadorCapa1);
                MessageBox.Show("Trabajador ingresado exitosamente");


                Limpiar();

                lista.CargarRutEnCombobox();

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void calcularSueldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AgregarTrabajador_Load(object sender, EventArgs e)
        {

        }

        private void listaTrabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListaTrabajadores f = new ListaTrabajadores();
            f.Show();
            this.Hide();
        }

        private void txt_rut_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_valorHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_valorHoraExtra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
