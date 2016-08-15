using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double qtdCalabresa = Convert.ToDouble(txtQtdCalabresa.Text);
            double qtdMussarela = Convert.ToDouble(txtQtdMussarela.Text);
            double qtdMarguerita = Convert.ToDouble(txtQtdMarguerita.Text);
            double qtdAtumI = Convert.ToDouble(txtQtdAtumI.Text);
            double qtdAtumII = Convert.ToDouble(txtQtdAtumII.Text);
            double qtdPortuguesa = Convert.ToDouble(txtQtdPortuguesa.Text);
            double qtdPernambucana = Convert.ToDouble(txtQtdPernambucana.Text);
            double qtdFrangoI = Convert.ToDouble(txtQtdFrangoI.Text);
            double qtdFrangoII = Convert.ToDouble(txtQtdFrangoII.Text);
            double qtdToscana = Convert.ToDouble(txtQtdToscana.Text);
            double qtdCarne = Convert.ToDouble(txtCarne.Text);
            double qtdQueijo = Convert.ToDouble(txtQueijo.Text);
            double qtdCalabresa1 = Convert.ToDouble(txtCalabresa1.Text);
            double qtdFrango = Convert.ToDouble(txtFrango.Text);
            double qtdChocolate = Convert.ToDouble(txtChocolate.Text);
            double qtdLeite = Convert.ToDouble(txtDocedeLeite.Text);
            double qtdCoca = Convert.ToDouble(txtCoca.Text);
            double qtdFanta1 = Convert.ToDouble(txtFanta1.Text);
            double qtdFanta2 = Convert.ToDouble(txtFanta2.Text);
            double qtdBrahma = Convert.ToDouble(txtBrahma.Text);
            double qtdItaipava = Convert.ToDouble(txtItaipava.Text);
            double qtdSkol = Convert.ToDouble(txtSkol.Text);







            double pizza1 = 0, pizza2 = 0, pizza3 = 0, pizza4 = 0, pizza5 = 0, pizza6 = 0, pizza7 = 0, pizza8 = 0, pizza9 = 0, pizza10 = 0,
                   esfiha1 = 0, esfiha2 = 0, esfiha3 = 0, esfiha4 = 0, esfiha5 = 0, esfiha6 = 0, bebida1 = 0, bebida2 = 0, bebida3 = 0, bebida4 = 0, bebida5 = 0, bebida6 = 0;

            if (checkCalabresa.Checked == true)
            {
                pizza1 = qtdCalabresa * 21.00;
            }
            if (checkMussarela.Checked == true)
            {
                pizza2 = qtdMussarela * 21.00;
            }
            if (checkMarguerita.Checked == true)
            {
                pizza3 = qtdMarguerita * 25.00;
            }
            if (checkAtumI.Checked == true)
            {
                pizza4 = qtdAtumI * 24.00;
            }
            if (checkAtumII.Checked == true)
            {
                pizza5 = qtdAtumII * 26.00;
            }
            if (checkPortuguesa.Checked == true)
            {
                pizza6 = qtdPortuguesa * 23.00;
            }
            if (checkPernambucana.Checked == true)
            {
                pizza7 = qtdPernambucana * 24.00;
            }
            if (checkFrangoI.Checked == true)
            {
                pizza8 = qtdFrangoI * 25.00;
            }
            if (checkFrangoII.Checked == true)
            {
                pizza9 = qtdFrangoII * 26.00;
            }
            if (checkToscana.Checked == true)
            {
                pizza10 = qtdToscana * 23.00;
            }
            if (checkCarne.Checked ==true)
            {
                esfiha1 = qtdCarne * 1.40;
            }
            if (checkQueijo.Checked ==true)
            {
                esfiha2 = qtdQueijo * 1.40;
            }
            if (checkCalabresa1.Checked ==true)
            {
                esfiha3 = qtdCalabresa1 * 1.20;
            }
            if ( checkFrango.Checked  ==true)
            {
                esfiha4 = qtdFrango * 1.50;
            }
            if (checkChocolate.Checked  ==true)
            {
                esfiha5 = qtdChocolate * 1.70;
            }
            if (checkDocedeLeite.Checked =true)
            {
                esfiha6 = qtdLeite * 1.60;
            }
            if (checkCocaCola.Checked ==true)
            {
                bebida1 = qtdCoca * 7.00;
            }
            if (checkFantaUva.Checked ==true)
            {
                bebida2 = qtdFanta1 * 6.00;
            }
            if (checkFantaLaranja.Checked == true)
            {
                bebida3 = qtdFanta2 * 6.00;
            }
            if (checkBrahma.Checked ==true)
            {
                bebida4 = qtdBrahma * 3.50;
            }

            if (checkItaipava.Checked ==true)
            {
                bebida5 = qtdItaipava * 3.50;
            }
            if (checkSkol.Checked ==true)
            {
                bebida6 = qtdSkol * 3.50;
            }

            // Pagamento
            if (radioButton1.Checked )
            {
                MessageBox.Show("Pagamento Concluido");
            }
            if (radioButton2.Checked)
            {
                MessageBox.Show("Pagamento Concluido");
            }







            double Resultado = pizza1 + pizza2 + pizza3 + pizza4 + pizza5 + pizza6 + pizza7 + pizza8 + pizza9 + pizza10
                   + esfiha1 + esfiha2 + esfiha3 + esfiha4 + esfiha5 + esfiha6 + bebida1 + bebida2 + bebida3 + bebida4 + bebida5 + bebida6;
            txtTotal.Text = Convert.ToString(Resultado);



        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtQtdCalabresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPreçoChocolate_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            checkCalabresa.Checked = false;
            checkMussarela.Checked = false;
            checkMarguerita.Checked = false;
            checkAtumI.Checked = false;
            checkAtumII.Checked = false;
            checkPortuguesa.Checked = false;
            checkPernambucana.Checked = false;
            checkFrangoI.Checked = false;
            checkFrangoII.Checked = false;
            checkToscana.Checked = false;
            checkCarne.Checked = false;
            checkQueijo.Checked = false;
            checkCalabresa1.Checked = false;
            checkFrango.Checked = false;
            checkChocolate.Checked = false;
            checkDocedeLeite.Checked = false;
            checkCocaCola.Checked = false;
            checkFantaUva.Checked = false;
            checkFantaLaranja.Checked = false;
            checkBrahma.Checked = false;
            checkItaipava.Checked = false;
            checkSkol.Checked = false;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtTotal.Clear();






        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}