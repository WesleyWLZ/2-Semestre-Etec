using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_03Dez
{
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
        }
        SqlConnection conexao = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDControleEstoque;Data Source=LAB31-MICRO16\MORATOSERVER");

        private void btnCadastroFuncionario_Click(object sender, EventArgs e)
        {
            conexao.Open();


            string comandoSql = string.Format("Insert into TabelaFuncionario values ( '{0}', '{1}', '{2}')", txtNomeFuncionario.Text, txtCPFFuncionario.Text, txtCargoFuncionario.Text);

            SqlCommand cmd = new SqlCommand(comandoSql, conexao);

            cmd.ExecuteNonQuery();

            conexao.Close();

            ConsultaTabela();
        }
        private SqlConnection Conectar()
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
            return conexao;
        }

        private void Desconectar()
        {

        }
        private void ConsultaTabela()
        {
            DataSet ds = new DataSet();
            conexao.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TabelaFuncionario", conexao);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);

            GridCadastroFuncionario.DataSource = ds.Tables[0];

            conexao.Close();
        }
    }
}
