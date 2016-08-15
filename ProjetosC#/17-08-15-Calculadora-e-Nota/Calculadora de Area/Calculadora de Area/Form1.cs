using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_Area
{
    public partial class frmCalcFormas : Form
    {
        public frmCalcFormas()
        {
            InitializeComponent();
        }

        private void btnCirc_Click(object sender, EventArgs e)
        {

        }

        private void lblAltura_Click(object sender, EventArgs e)
        {

        }

        private void frmCalcFormas_Load(object sender, EventArgs e)
        {

        }

        private void btnQuad_Click(object sender, EventArgs e)
        {
            double bas, area;
           
            bas = Convert.ToDouble(txtBase.Text);
            area = bas * bas;

            txtResul.Text = area.ToString();
        }

        private void btnRet_Click(object sender, EventArgs e)
        {
            double bas, alt, area;
            bas = Convert.ToDouble(txtAlt.Text);
            alt = Convert.ToDouble(txtBase.Text);
            area = bas * alt;

            txtResul.Text = area.ToString();

        }

        private void btnTri_Click(object sender, EventArgs e)
        {

        }
    }
}
