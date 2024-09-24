using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Operaciones obj = new Operaciones();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_sumar_Click(object sender, EventArgs e)
        {
            if(!obj.IsNumeric(txt_num1.Text) && !obj.IsNumeric(txt_num2.Text))
            {
                txt_resultado.Text = "ingrese un valor valido";
            }
            else
            {
                int suma = obj.suma(Convert.ToInt32(txt_num1.Text), Convert.ToInt32(txt_num2.Text));
                txt_resultado.Text = Convert.ToString(suma); 
            }
        }

        private void btn_restar_Click(object sender, EventArgs e)
        {
            if(!obj.IsNumeric(txt_num1.Text) && !obj.IsNumeric(txt_num2.Text))
            {
                txt_resultado.Text = "ingrese un valor valido";
            }
            else
            {
                int resta = obj.resta(Convert.ToInt32(txt_num1.Text), Convert.ToInt32(txt_num2.Text));
                txt_resultado.Text = Convert.ToString(resta);
            }

        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            if(!obj.IsNumeric(txt_num1.Text) && !obj.IsNumeric(txt_num2.Text))
            {
                txt_resultado.Text = "ingrese un valor valido";
            }
            else
            {
                int mult = obj.multiplicacion(Convert.ToInt32(txt_num1.Text), Convert.ToInt32(txt_num2.Text));
                txt_resultado.Text = Convert.ToString(mult);
            }
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            if(!obj.IsNumeric(txt_num1.Text) && !obj.IsNumeric(txt_num2.Text))
            {
                txt_resultado.Text = "ingrese un valor valido";
            }
            else
            {
                int division = obj.division(Convert.ToInt32(txt_num1.Text), Convert.ToInt32(txt_num2.Text));
                txt_resultado.Text = Convert.ToString(division);
            }
        }
    }
}
