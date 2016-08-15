using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procedimentos_Funções
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public string Somar (string v1, string v2)
    {
        return (double.Parse(v1) + double.Parse(v2)).ToString();
    }

        public string Subtrair(string v1, string v2)
        {
            return (double.Parse(v1) - double.Parse(v2)).ToString();
        }
        public string multiplicar (string v1, string v2)
        {
            return (double.Parse(v1) * double.Parse(v2)).ToString();
        }
        public string Dividir(string v1, string v2)
        {
            return (double.Parse(v1) / double.Parse(v2)).ToString();
        }
        public void Limpar()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = String.Empty;
                    txtVal1.Focus();
                }

            }
        }
        
        

    







        private void btnSomar_Click(object sender, EventArgs e)
        {
            txtVal3.Text = Somar(txtVal1.Text, txtVal2.Text);
       
    }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            txtVal3.Text = Subtrair(txtVal1.Text, txtVal2.Text);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            txtVal3.Text = multiplicar(txtVal1.Text, txtVal2.Text);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            txtVal3.Text = Dividir(txtVal1.Text, txtVal2.Text);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }



    }
}
