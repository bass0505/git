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

namespace Proyecto_ENE.Forms
{
    public partial class CalcularSueldo : Form
    {
        private TrabajadorService trabajadorService = new TrabajadorService();
        ListaTrabajadorSueldo listaSueldo = new ListaTrabajadorSueldo();
        public CalcularSueldo()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            string horasTrabajadas = txt_horasTrabajadas.Text;
            string horasExtras = txt_horasextras.Text;
            string resultadoBruto = lbl_sueldoBruto.Text;
            string resultadoLiquido = lbl_sueldoLiquido.Text;
            if (cmb_afp.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una AFP.");
                return;
            }
            string seleccionAfp = cmb_afp.SelectedItem.ToString();
            if (cmb_salud.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un descuento de salud.");
                return;
            }
            string seleccionSalud = cmb_salud.SelectedItem.ToString();
            int horasTrabajadasInt = int.Parse(horasTrabajadas);
            int horasExtrasInt = int.Parse(horasExtras);

            int sueldoBruto = (horasTrabajadasInt * 5000) + (horasExtrasInt * 7000);

            resultadoBruto = sueldoBruto.ToString();

            double descuentoAfp = 0;
            double descuentoSalud = 0;

            switch (seleccionAfp)
            {
                case "CUPRUM":
                    descuentoAfp = 7;
                    break;
                case "MODELO":
                    descuentoAfp = 9;
                    break;
                case "CAPITAL":
                    descuentoAfp = 12;
                    break;
                case "PROVIDA":
                    descuentoAfp = 13;
                    break;
            }

            switch (seleccionSalud)
            {
                case "FONASA":
                    descuentoSalud = 12;
                    break;
                case "CONSALUD":
                    descuentoSalud = 13;
                    break;
                case "MASVIDA":
                    descuentoSalud = 14;
                    break;
                case "BANMEDICA":
                    descuentoSalud = 15;
                    break;
            }

            double sueldoLiquido = sueldoBruto - (sueldoBruto * descuentoAfp / 100) - (sueldoBruto * descuentoSalud / 100);

            resultadoLiquido = sueldoLiquido.ToString();
            lbl_sueldoBruto.Text = ("$" + resultadoBruto);
            lbl_sueldoLiquido.Text = ("$" + resultadoLiquido);
        }

        private void lbl_sueldoBruto_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            listaSueldo.SetSueldo(lbl_sueldoLiquido.Text);

        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            listaSueldo.Show();
            this.Hide();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_horasTrabajadas.Clear();
            txt_horasextras.Clear();
            cmb_afp.SelectedItem = null;
            cmb_salud.SelectedItem = null;
            lbl_sueldoBruto.Text = "$0";
            lbl_sueldoLiquido.Text = "$0";
        }

        private void txt_horasTrabajadas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_horasTrabajadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_horasextras_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_horasextras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
