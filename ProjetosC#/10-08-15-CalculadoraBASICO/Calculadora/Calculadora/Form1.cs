using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double num1;
            Double num2;
            Double resul;
            string resultadodasoma
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            resul = num1 + num2;
            resultadodasoma=resu.Tostring
            txtResul.Text=resultadodasoma;~;
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
