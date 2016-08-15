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

namespace Cadastro_Agenda
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        SqlConnection conexao = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDAgenda;Data Source=ARTURCECILIO");

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            conexao.Open();

            string comandoSql = string.Format("UPDATE TB_Agenda SET nome =  '{0}', fixo = '{1}',celular =  '{2}'  WHERE ID = '{3}'", textBox2.Text, textBox3.Text, textBox4.Text, textBox1.Text);

            SqlCommand cmd = new SqlCommand(comandoSql, conexao);

            cmd.ExecuteNonQuery();

            conexao.Close();

            ConsultaTabela();
        }

        private void ConsultaTabela ()
        {
            DataSet ds = new DataSet();
            conexao.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TB_Agenda", conexao);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);

            dgAgenda.DataSource = ds.Tables[0];

            conexao.Close();
        }
    

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            conexao.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TB_Agenda", conexao);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds);

            dgAgenda.DataSource = ds.Tables[0];

            conexao.Close();
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
                conexao.Open();

                string comandoSql = string.Format("Insert into TB_Agenda values ( '{0}', '{1}', '{2}')", textBox2.Text, textBox3.Text, textBox4.Text);

                SqlCommand cmd = new SqlCommand(comandoSql, conexao);

                cmd.ExecuteNonQuery();

                conexao.Close();

                ConsultaTabela();
            
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            conexao.Open();

            string comandoSql = string.Format("Delete from TB_Agenda WHERE ID = '{0}'", textBox1.Text);

            SqlCommand cmd = new SqlCommand(comandoSql, conexao);

            cmd.ExecuteNonQuery();

         

            conexao.Close();



            ConsultaTabela();
            
        }
           
        }
    }


