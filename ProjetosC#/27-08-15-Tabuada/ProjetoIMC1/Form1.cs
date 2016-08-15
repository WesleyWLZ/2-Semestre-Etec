using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIMC1
{
    public partial class frmIMC : Form
    {
        public frmIMC()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura, peso, imc;

            altura = Convert.ToDouble(txtAltura.Text);
            peso = Convert.ToDouble(txtPeso.Text);
            imc = peso / (altura * altura);

            if ( imc <= 18.5 )
            {
            MessageBox.Show(" Você esta abaixo do peso ideal  "   + imc.ToString());

            }

            else if ( imc > 18.5 && imc  <= 24.9)
            {
            MessageBox.Show(" Você esta no peso ideal  "   + imc.ToString());

            }
           
            else if ( imc > 25 && imc <=  29.9)
            {
            MessageBox.Show(" Você esta acima do peso ideal  "   + imc.ToString());
            }
            else if ( imc > 30 && imc  <= 34.9)
            {
            MessageBox.Show(" Você esta com Obesidade Grau I "   + imc.ToString());
            }
            else if (imc > 35.0 && imc <= 39.9)
            {
                MessageBox.Show(" Você esta com Obesidade Grau II " + imc.ToString());
            }
            else if (imc > 40)
            {
                MessageBox.Show(" Você esta morrendo " + imc.ToString());
            }
        }
    }
}

