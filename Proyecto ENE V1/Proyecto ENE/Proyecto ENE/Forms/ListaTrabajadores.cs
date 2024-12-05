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
    public partial class ListaTrabajadores : Form
    {
        private TrabajadorService trabajadorService = new TrabajadorService();

        public void CargarRutEnCombobox()
        {

            List<Trabajador> trabajadores = trabajadorService.ObtenerTodosTrabajadores();


            comboBox1.Items.Clear();


            comboBox1.Items.Add("TODOS");
            foreach (var trabajador in trabajadores)
            {
                comboBox1.Items.Add(trabajador.Rut);
            }
        }
        public ListaTrabajadores()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rutSeleccionado = comboBox1.SelectedItem.ToString();
            if (rutSeleccionado == "TODOS")
            {
                List<Trabajador> trabajador = trabajadorService.ObtenerTodosTrabajadores();
                dvg_resultado.DataSource = trabajador;
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
                    tabla.Columns.Add("Telefono");
                    tabla.Columns.Add("Valor Hora");
                    tabla.Columns.Add("Valor Hora Extra");
                    

                    tabla.Rows.Add(trabajador.Rut, trabajador.Nombre, trabajador.Direccion, trabajador.Telefono, trabajador.ValorHora, trabajador.ValorHoraExtra);


                    dvg_resultado.DataSource = tabla;
                }
            }
        }

        private void dvg_resultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvg_resultado.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dvg_resultado.SelectedRows[0];
            }

        }

        private void ListaTrabajadores_Load(object sender, EventArgs e)
        {
            CargarRutEnCombobox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void agregarTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarTrabajador f = new AgregarTrabajador();
            f.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

}
