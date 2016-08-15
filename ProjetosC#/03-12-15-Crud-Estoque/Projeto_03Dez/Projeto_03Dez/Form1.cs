using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_03Dez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void produdoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProduto cadastro = new CadastroProduto();
            cadastro.ShowDialog();

        }

        private void cadastroFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFuncionario funcionario = new CadastroFuncionario();
            funcionario.ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaProduto consulta = new ConsultaProduto();
            consulta.ShowDialog();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaFuncionario consulta = new ConsultaFuncionario();
            consulta.ShowDialog();
        }

        private void baixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaixaEstoque baixa = new BaixaEstoque();
            baixa.ShowDialog();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaEstoque consulta = new ConsultaEstoque();
            consulta.ShowDialog();
        }
    }
}
