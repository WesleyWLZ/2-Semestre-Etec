using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFastFood
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {


            try
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Usuário ou Senha Invalido!");
                }
                if (textBox1.Text == "Admin" && textBox2.Text == "Admin")
                {
                    MessageBox.Show("Bem-vindo ao Sistema");
                    Carregamento carregamento = new Carregamento();
                    carregamento.Show();
                }
                else
                {
                    MessageBox.Show("Usuario ou Senha Incorretos!");
                }
            }

            finally
            {
                this.Close();
            }
        }
    

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
