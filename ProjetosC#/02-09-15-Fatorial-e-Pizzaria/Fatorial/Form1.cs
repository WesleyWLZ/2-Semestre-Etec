using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatorial2
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

        private void btnFatorial_Click(object sender, EventArgs e)
        {
            double fatorial = 1;
            int num;
            try
            {
                num = Convert.ToInt32(txtFatorial.Text);
            }
            catch (Exception message)
            {

                MessageBox.Show(message.Message);
                return;
            }


            for (int i = 1; i <= num; i++)
            {
                fatorial *= i;

            }
            lblResultado.Text = fatorial.ToString();
        }
    }
}
