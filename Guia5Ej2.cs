using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guía5Ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Double Sal = 0, Sal_Dev = 0, Desc = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Double Sal = 0, Salf = 0, Desc = 0;
                label3.Text = " " + 0 + " ";
                if (radioButton1.Checked == true)
                {
                    Sal = Double.Parse(textBox2.Text);
                    Desc = Sal * .2;
                    Salf = Sal - Desc;
                    label3.Text = "El gerente " + textBox1.Text + " cuenta con un salario total de: $"
                        + Sal.ToString() + ", al cual se le aplica \nun descuento de " +
                        Desc.ToString() + " correspondiente a un 20%, quedando un \nsueldo neto de: $" + Salf.ToString() + ".";
                }
                else if (radioButton2.Checked == true)
                {
                    Sal = Double.Parse(textBox2.Text);
                    Desc = Sal * .15;
                    Salf = Sal - Desc;
                    label3.Text = "El gerente " + textBox1.Text + " cuenta con un salario total de: $"
                        + Sal.ToString() + ", al cual se le aplica \nun descuento de " +
                        Desc.ToString() + " correspondiente a un 15%, quedando un \nsueldo neto de: $" + Salf.ToString() + ".";
                }
                else if (radioButton3.Checked == true)
                {
                    Sal = Double.Parse(textBox2.Text);
                    Desc = Sal * .05;
                    Salf = Sal - Desc;
                    label3.Text = "El gerente " + textBox1.Text + " cuenta con un salario total de: $"
                        + Sal.ToString() + ", al cual se le aplica \nun descuento de " +
                        Desc.ToString() + " correspondiente a un 5%, quedando un \nsueldo neto de: $" + Salf.ToString() + ".";
                }
            }
            catch(FormatException)
            {
                label3.Text = "Datos erróneos";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "Ingrese datos";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton3.Checked = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
