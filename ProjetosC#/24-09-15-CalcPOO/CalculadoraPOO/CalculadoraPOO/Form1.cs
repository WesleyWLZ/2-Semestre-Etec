using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CalculadoraOOP ObjetoDaCalculadora = new CalculadoraOOP();
        private void btnSomar_Click(object sender, EventArgs e)
        {
            ObjetoDaCalculadora.Valor1 = double.Parse(txtValor1.Text);
            ObjetoDaCalculadora.Valor2 = double.Parse(txtValor2.Text);

            txtResultado.Text = ObjetoDaCalculadora.Somar().ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Quer deletar?", "Aviso", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                txtResultado.Text = "";
                txtValor1.Text = "";
                txtValor2.Text = "";
            }
            
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            ObjetoDaCalculadora.Valor1 = double.Parse(txtValor1.Text);
            ObjetoDaCalculadora.Valor2 = double.Parse(txtValor2.Text);

            txtResultado.Text = ObjetoDaCalculadora.Subtrair().ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ObjetoDaCalculadora.Valor1 = double.Parse(txtValor1.Text);
            ObjetoDaCalculadora.Valor2 = double.Parse(txtValor2.Text);

            txtResultado.Text = ObjetoDaCalculadora.Multiplicar().ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            ObjetoDaCalculadora.Valor1 = double.Parse(txtValor1.Text);
            ObjetoDaCalculadora.Valor2 = double.Parse(txtValor2.Text);

            txtResultado.Text = ObjetoDaCalculadora.Dividir().ToString();
        }

        private void btnQuadrado_Click(object sender, EventArgs e)
        {
            ObjetoDaCalculadora.Valor1 = double.Parse(txtValor1.Text);

            txtResultado.Text = ObjetoDaCalculadora.Quadrado().ToString();
        }

        private void btnRetangulo_Click(object sender, EventArgs e)
        {
            ObjetoDaCalculadora.Valor1 = double.Parse(txtValor1.Text);
            ObjetoDaCalculadora.Valor2 = double.Parse(txtValor2.Text);

            txtResultado.Text = ObjetoDaCalculadora.Retangulo().ToString();
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            ObjetoDaCalculadora.Valor1 = double.Parse(txtValor1.Text);
            
            txtResultado.Text = ObjetoDaCalculadora.Circulo().ToString();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Fomulário_2 obj = new Fomulário_2();
            //obj.Show(); Abre Varios Formulários
            //obj.ShowDialog(); Abre Apenas 1 Formulário
            obj.ShowDialog();
            obj.MdiParent = this;



         //  string[] vetor = new string[10];
          //  vetor[0] = "Artur";
          // vetor[1] = "Weelington";

            //double[] vetorNumeros = new double[1000];
            //Fomulário_2[] vetorFormularios = new Fomulário_2[10000];

            //string funcaoSubstring = string.Empty;

            //string funcaoSubstring = "";

           //    MessageBox.Show("PREDA".Substring(2,3));
            

        }
    }
}
// Declaração de Vetor
//string[] vetor = new string[10];
//vetor[0]= " Artur ";
