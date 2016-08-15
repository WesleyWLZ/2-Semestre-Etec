using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResul.Text = (double.Parse(txtVal1.Text) -
              double.Parse(txtVal2.Text)).ToString();
        }

        private void txtval1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblval1_Click(object sender, EventArgs e)
        {

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            txtResul.Text = (double.Parse(txtVal1.Text)+
             double.Parse(txtVal2.Text)).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            txtResul.Text = (double.Parse(txtVal1.Text) /
             double.Parse(txtVal2.Text)).ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            txtResul.Text = (double.Parse(txtVal1.Text) *
             double.Parse(txtVal2.Text)).ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResul.Clear();
            txtVal1.Clear();
            txtVal2.Clear();
        }
    }
}
