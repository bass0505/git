using Proyecto_ENE.DataAccess;
using Proyecto_ENE.Entities;
using System;
using System.Collections;
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
    public partial class ListaTrabajadorSueldo : Form
    {
        private TrabajadorService trabajadorService = new TrabajadorService();
        public ListaTrabajadorSueldo()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            txt_rut.Clear();
            txt_nombre.Clear();
            txt_direccion.Clear();
            txt_sueldo.Clear();

        }

        public void SetSueldo(string sueldo)
        {
            txt_sueldo.Text = sueldo;
        }
        public void CargarRutEnCombobox()
        {

            List<Trabajador> trabajadores = trabajadorService.ObtenerTodosTrabajadores();


            cmb_lista.Items.Clear();


            cmb_lista.Items.Add("TODOS");
            foreach (var trabajador in trabajadores)
            {
                cmb_lista.Items.Add(trabajador.Rut);
            }

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            Trabajador trabajadorCapa1 = new Trabajador
            {
                Rut = txt_rut.Text,
                Nombre = txt_nombre.Text,
                Direccion = txt_direccion.Text,
                SueldoLiquido = txt_sueldo.Text,
            };
            try
            {
                trabajadorService.AgregarTrabajadorSueldo(trabajadorCapa1);
                MessageBox.Show("Trabajador ingresado exitosamente");


                Limpiar();

                CargarRutEnCombobox();

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmb_lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rutSeleccionado = cmb_lista.SelectedItem.ToString();
            if (rutSeleccionado == "TODOS")
            {
                List<Trabajador> trabajadores = trabajadorService.ObtenerTodosTrabajadores();
                // dvg_resultado.DataSource = trabajador;



                var tabla = new System.Data.DataTable();
                tabla.Columns.Add("Rut");
                tabla.Columns.Add("Nombre");
                tabla.Columns.Add("Direccion");
                tabla.Columns.Add("Sueldo Liquido");

                foreach (var trabajador in trabajadores)
                {
                    tabla.Rows.Add(trabajador.Rut, trabajador.Nombre, trabajador.Direccion, trabajador.SueldoLiquido);
                }


                dvg_resultado.DataSource = tabla;
            }
            else
            {
                Trabajador trabajador = trabajadorService.ObtenerTrabajadorPorRut(rutSeleccionado);

                if (trabajador != null)
                {

                    var tabla = new System.Data.DataTable();


                    tabla.Columns.Add("Rut");
                    tabla.Columns.Add("Nombre");
                    tabla.Columns.Add("Direccion");
                    tabla.Columns.Add("Sueldo Liquido");

                    tabla.Rows.Add(trabajador.Rut, trabajador.Nombre, trabajador.Direccion, trabajador.SueldoLiquido);


                    dvg_resultado.DataSource = tabla;
                }
            }
        }

        private void dvg_resultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListaTrabajadorSueldo_Load(object sender, EventArgs e)
        {
            CargarRutEnCombobox();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_calcularSueldo_Click(object sender, EventArgs e)
        {
            CalcularSueldo f = new CalcularSueldo();
            f.Show();
            this.Hide();
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (dvg_resultado.SelectedRows.Count > 0)
            {


                var row = dvg_resultado.SelectedRows[0];


                try
                {
                    trabajadorService.EditarTrabajador(txt_rut.Text, txt_nombre.Text, txt_direccion.Text, txt_sueldo.Text);
                    CargarRutEnCombobox();
                    MessageBox.Show("Trabajador modificado exitosamente");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar trabajador: " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Seleccione un trabajador para modificar.");
            }
        }

        private void dvg_resultado_SelectionChanged(object sender, EventArgs e)
        {
            if (dvg_resultado.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dvg_resultado.SelectedRows[0];

                txt_rut.Text = row.Cells["Rut"].Value.ToString();
                txt_nombre.Text = row.Cells["Nombre"].Value.ToString();
                txt_direccion.Text = row.Cells["Direccion"].Value.ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dvg_resultado.SelectedRows.Count > 0)
            {

                string rutSeleccionado = dvg_resultado.SelectedRows[0].Cells["Rut"].Value.ToString();


                if (trabajadorService.EliminarTrabajador(rutSeleccionado))
                {
                    MessageBox.Show("Trabajador eliminado exitosamente");
                    CargarRutEnCombobox();

                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el trabajador.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un trabajador para eliminar.");
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}