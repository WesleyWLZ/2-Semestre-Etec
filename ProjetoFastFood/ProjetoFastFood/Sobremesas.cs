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
    public partial class Sobremesas : Form
    {
        public static BindingList<Produto> ProdutosSobremesas = new BindingList<Produto>();

        public Sobremesas()
        {
            InitializeComponent();
            Form1.BindingListBox(listBox1, ProdutosSobremesas);

            ProdutosSobremesas.ListChanged += ProdutosListChanged;
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

        private void Sobremesas_Load(object sender, EventArgs e)
        {

        }

        private void btnPetitiGateu_Click(object sender, EventArgs e)
        {
            AdicinarSobremesa("Mini Churros", 2.50M);
        }
        private void AdicinarSobremesa(String produto, decimal valor)
        {
            Form1.AdicionarProduto(ProdutosSobremesas, produto, valor, txtValorItems);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnBrownie_Click(object sender, EventArgs e)
        {
            AdicinarSobremesa("Mousse de Chocolate", 3.50M);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdicinarSobremesa("Pudim", 3.00M);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdicinarSobremesa("Sorvete Doce de Leite", 13.00M);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdicinarSobremesa("Pastel de Belem", 2.00M);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdicinarSobremesa("Batata Frita Média", 4.00M);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdicinarSobremesa("Sorvete Morango", 13.00M);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdicinarSobremesa("Sorvete Napolitano", 13.00M);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdicinarSobremesa("Sorvete Creme", 13.00M);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ProdutosSobremesas.Clear();
            txtPrecoTotal.Text = "";
            txtValorAnterior.Text = "";
            txtValorItems.Text = "";
            Form1.ProdutosForm1.Clear();
        }
    }
}
