using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conexao = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BD_Agenda;Data Source=LAB31-MICRO13\MORATOSERVER");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            conexao.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TB_Agenda", conexao);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand= cmd;
            da.Fill(ds);

            dgAgenda.DataSource = ds.Tables[0];

            conexao.Close();

        //    DataTable dt = new DataTable();
        }

        private  SqlConnection Conectar() 
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

        private void btninserir_Click(object sender, EventArgs e)
        {
            conexao.Open();

            string comandoSql = string.Format("Insert into TB_Agenda values ('{0}' , '{1}', '{2}', '{3}')", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

            SqlCommand cmd = new SqlCommand(comandoSql, conexao);

            cmd.ExecuteNonQuery();

            conexao.Close();
        }





    }
}
