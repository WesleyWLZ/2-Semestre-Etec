using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Materiais_de_Construção
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            // Materiais de Construção
            double qtdcimento1 = Convert.ToDouble(txtCimentoCaue.Text);
            double qtdcimento2 = Convert.ToDouble(txtCimentoVotoran.Text);
            double qtdareia1 = Convert.ToDouble(txtAreiaFina.Text);
            double qtdareia2 = Convert.ToDouble(txtAreiaMedia.Text);
            double qtdpó = Convert.ToDouble(txtPódePedra.Text);

            double mt1 = 0, mt2 = 0, mt3 = 0, mt4 = 0, mt5 = 0;

            if (checkCimentoCaue.Checked == true)
            {
                mt1 = qtdcimento1 * 26.50;
            }
            if (checkCimentoVotoran.Checked == true)
            {
                mt2 = qtdcimento2 * 25.00;
            }
            if (checkAreiaFina.Checked == true)
            {
                mt3 = qtdareia1 * 89.00;
            }
            if (checkAreiaMedia.Checked == true)
            {
                mt4 = qtdareia2 * 85.00;
            }
            if (checkPodePedra.Checked == true)
            {
                mt5 = qtdpó * 94.00;
            }

            double total1 = mt1 + mt2 + mt3 + mt4 + mt5;

            txtPreço1.Text = Convert.ToString(total1);

            // eletrica
            double qtdtomada1 = Convert.ToDouble(txtTomada.Text);
            double qtdtomada2 = Convert.ToDouble(txtTomadaDupla.Text);
            double qtdfio = Convert.ToDouble(txtFio.Text);
            double qtdcanduite = Convert.ToDouble(txtCanduite.Text);
            double qtddijuntor = Convert.ToDouble(txtDijuntor.Text);

            double e1 = 0, e2 = 0, e3 = 0, e4 = 0, e5 = 0;

            if (checkTomada.Checked == true)
            {
                e1 = qtdtomada1 * 14.50;
            }
            if (checkTomadaDupla.Checked == true)
            {
                e2 = qtdtomada2 * 18.50;
            }
            if (checkFio.Checked == true)
            {
                e3 = qtdfio * 35.00;
            }
            if (checkCanduite.Checked == true)
            {
                e4 = qtdcanduite * 35.00;
            }
            if (checkDijuntor.Checked == true)
            {
                e5 = qtddijuntor * 8.50;
            }

            double total2 = e1 + e2 + e3 + e4 + e5;

            txtPreço2.Text = Convert.ToString(total2);

            // hidráulico

            double qtdcano1 = Convert.ToDouble(txtCano1.Text);
            double qtdcano2 = Convert.ToDouble(txtCano2.Text);
            double qtdsifao = Convert.ToDouble(txtSifão.Text);
            double qtdtorneira1 = Convert.ToDouble(txtTorneira1.Text);
            double qtdtorneira2 = Convert.ToDouble(txtTorneira2.Text);

            double h1 = 0, h2 = 0, h3 = 0, h4 = 0, h5 = 0;

            if (checkCano4.Checked == true)
            {
                h1 = qtdcano1 * 38.00;
            }
            if (checkCano6.Checked == true)
            {
                h2 = qtdcano2 * 40.00;
            }
            if (checkSifão.Checked == true)
            {
                h3 = qtdsifao * 15.80;
            }
            if (checkTorneira1.Checked == true)
            {
                h4 = qtdtorneira1 * 65.00;
            }
            if (checkTorneira2.Checked == true)
            {
                h5 = qtdtorneira2 * 54.00;
            }

            double total3 = h1 + h2 + h3 + h4 + h5;

            txtPreço3.Text = Convert.ToString(total3);

            // Acabamento

            double qtdpiso = Convert.ToDouble(txtPiso.Text);
            double qtdazu = Convert.ToDouble(txtAzulejo.Text);
            double qtdPorce = Convert.ToDouble(txtPorcelanato.Text);
            double qtdtinta1 = Convert.ToDouble(txtTinta1.Text);
            double qtdtinta2 = Convert.ToDouble(txtTinta2.Text);

            double t1 = 0, t2 = 0, t3 = 0, t4 = 0, t5 = 0;

            if (checkPiso.Checked == true)
            {
                t1 = qtdpiso * 12.90;
            }
            if (checkAzulejo.Checked == true)
            {
                t2 = qtdazu * 14.90;
            }
            if (checkPorcelanato.Checked == true)
            {
                t3 = qtdPorce * 35.00;
            }
            if (checkTintaCoral.Checked == true)
            {
                t4 = qtdtinta1 * 95.00;
            }
            if (checkTintaSuvinil.Checked == true)
            {
                t5 = qtdtinta2 * 120.00;
            }

            double total4 = t1 + t2 + t3 + t4 + t5;

            txtPreço4.Text = Convert.ToString(total4);


            double geral = total1 + total2 + total3 + total4;
            textBox1.Text = Convert.ToString(geral);

            if (radioButton1.Checked)
            {
                MessageBox.Show("Pagamento Concluído");
            }

            if (radioButton2.Checked)
            {
                MessageBox.Show("Pagamento Parcelado");
            }

            if (radioButton3.Checked)
            {
                MessageBox.Show("Pagamento Concluido");
            }

            if (radioButton4.Checked)
            {
                MessageBox.Show("Pagamento para 30 Dias");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            //Materiais de Construção
            checkCimentoCaue.Checked = false;
            checkCimentoVotoran.Checked = false;
            checkAreiaFina.Checked = false;
            checkAreiaMedia.Checked = false;
            checkPodePedra.Checked = false;

            // Elétrica
            checkTomada.Checked = false;
            checkTomadaDupla.Checked = false;
            checkFio.Checked = false;
            checkCanduite.Checked = false;
            checkDijuntor.Checked = false;

            //hidraúlico

            checkCano4.Checked = false;
            checkCano6.Checked = false;
            checkSifão.Checked = false;
            checkTorneira1.Checked = false;
            checkTorneira2.Checked = false;

            //Acabamento
            checkPiso.Checked = false;
            checkAzulejo.Checked = false;
            checkPorcelanato.Checked = false;
            checkTintaCoral.Checked = false;
            checkTintaSuvinil.Checked = false;

            //Forma de Pagamento
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            //Pagamento
            txtPreço1.Clear();
            txtPreço2.Clear();
            txtPreço3.Clear();
            txtPreço4.Clear();
            textBox1.Clear();

            
           


            //

            // foreach (Control item in this.Controls)
            // {
            //      if (item is TextBox)
            //      {
            //          item.Text = String.Empty;
            //      }
            //      if (item is CheckBox)
            //      {
            //           ((CheckBox)item).Checked = false;
            //     }
            //   
            //
            // if (item is GroupBox)
            //    {
            //     foreach (var item2 in item.Controls)

            //        ((CheckBox)item2).Checked = false;







        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPreço3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPreço4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPreço2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPreço1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}