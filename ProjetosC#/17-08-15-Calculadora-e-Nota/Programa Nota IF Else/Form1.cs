using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_Nota_IF_Else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double nota1, nota2, media;
            nota1 = Convert.ToDouble(txtNota1.Text);
            nota2 = Convert.ToDouble(txtNota2.Text);
            media = (nota1 + nota2) / 2;
            if (media >= 6)
            {
                MessageBox.Show(" Parabéns, Aprovado... \n Aprovado com Nota: "   + media.ToString());
            }

            else if (media == 5)
            {
                MessageBox.Show(" Recuperação... \n Recuperação com Nota: " + media.ToString());
            }
            else
            {
                MessageBox.Show(" Reprovado... \n Reprovado com Nota:  " + media.ToString());
            }



        }
    }
}



    
