using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2;
            num1 = double.Parse(txtMultiplicar.Text);

            for (double i = 0; i <= 10; i++)
            {

                num2 = num1 * i;
                ltbLista.Items.Add(num1 + "x" + i + '=' + num2);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
           txtMultiplicar.Text = ("");
           ltbLista.Items.Clear();
          
            
        }

        private void ltbLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMultiplicar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
