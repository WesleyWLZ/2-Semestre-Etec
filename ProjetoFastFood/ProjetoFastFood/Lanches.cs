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
    public partial class Lanches : Form
    {
        public static BindingList<Produto> ProdutosLanches = new BindingList<Produto>();


        public Lanches()

        {
       

            InitializeComponent();
            Form1.BindingListBox(listBox1, ProdutosLanches);

            ProdutosLanches.ListChanged += ProdutosListChanged;
        }
        private void ProdutosListChanged(object sender, ListChangedEventArgs e)
        {
            var itens = ((BindingList<Produto>)sender);

            if (itens.Count > 0)
            {
                var ultimo = itens.Last();
                var total = itens.Sum(c => c.Preco);

                txtValorAnterior.Text = (total - ultimo.Preco).ToString();

                txtPrecoTotal.Text = total.ToString();
            }
        }

        private void btnXBurguer_Click(object sender, EventArgs e)
        {
            AdicionarLanche("X-burger", 5.00M);
        }

        private void Lanches_Load(object sender, EventArgs e)
        {

        }

        private void btnMontanha_Click(object sender, EventArgs e)
        {

            AdicionarLanche("Montanha ", 14.50M);
        }
        private void AdicionarLanche(String produto, decimal valor)
        {
            Form1.AdicionarProduto(ProdutosLanches, produto, valor, txtValorItem);
        }

        private IWin32Window ltbListaAdd(string p)
        {
            throw new NotImplementedException();
        }

        private void btnKuarteirão_Click(object sender, EventArgs e)
        {
            AdicionarLanche("Kuarteirão ", 7.50M);
        }

        private void btnXPicanha_Click(object sender, EventArgs e)
        {
            AdicionarLanche("X-Picanha ", 11.00M);
        }

        private void btnXSalada_Click(object sender, EventArgs e)
        {
            AdicionarLanche("X-Salada ", 5.60M);
        }

        private void btnJavali_Click(object sender, EventArgs e)
        {
            AdicionarLanche("Javali", 8.50M);
        }

        private void btnXMitão_Click(object sender, EventArgs e)
        {
            AdicionarLanche("X-Mitão ", 6.99M);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdicionarLanche("X-xalblau ", 9.90M);
        }

        private void btnBigMec_Click(object sender, EventArgs e)
        {
            AdicionarLanche("BigMec", 12.80M);
        }

        private void btnBirutão_Click(object sender, EventArgs e)
        {
            AdicionarLanche("Birutão ", 8.00M);
        }

       

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ProdutosLanches.Clear();
            txtPrecoTotal.Text = "";
            txtValorAnterior.Text = "";
            txtValorItem.Text = "";
            Form1.ProdutosForm1.Clear();
        }
    }
}
