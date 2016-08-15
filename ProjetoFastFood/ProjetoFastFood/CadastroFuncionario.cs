using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoFastFood
{
    public partial class CadastroFuncionário : Form
    {
        public CadastroFuncionário()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
    /*        String Usuario = txtNome.Text;
            String Senha = txtSenha.Text;
            String Telefone = txtTel.Text;
            String Email = txtEmail.Text;

            if (Usuario == "" || Senha == "" || Email == "" )
            {
                MessageBox.Show("Campos Invalidos!","ERRO");
                return;
            }
            String Configuracao = "server=localhost; userid=root; database=Cadastro";
            MySqlConnection conexao = new MySqlConnection(Configuracao);
            try
            {
                conexao.Open();
                MySqlCommand COMANDO = new MySqlCommand("INSERT INTO usuarios (Usuario, Senha, Email, Telefone) VALUES (" + Usuario + "," + Senha + " , " + Email + "," + Telefone + ";", conexao);
                MySqlDataReader Reader;
                Reader = COMANDO.ExecuteReader();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro de conexão ");
                throw;
            }*/
        }
    }
}
