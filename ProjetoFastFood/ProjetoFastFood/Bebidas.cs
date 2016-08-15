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
    public partial class Bebidas : Form
    {


        public static BindingList<Produto> ProdutosBebidas = new BindingList<Produto>();

        public Bebidas()
        {
            InitializeComponent();
            Form1.BindingListBox(listBox1, ProdutosBebidas);

            ProdutosBebidas.ListChanged += ProdutosListChanged;
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

        private void Bebidas_Load(object sender, EventArgs e)
        {
        }

        private void btnLataCoca_Click(object sender, EventArgs e)
        {
            AdicionarBebida("Cola-Cola Lata", 3.00M);

        }
        private void AdicionarBebida(String produto, decimal valor)
        {
            Form1.AdicionarProduto(ProdutosBebidas, produto, valor, txtValorItem);
        }

        private IWin32Window ltbListaAdd(string p)
        {
            throw new NotImplementedException();
        }

        public IWin32Window listaItensDaltbLista { get; set; }

        private void btnSucoLaranja_Click(object sender, EventArgs e)
        {
            AdicionarBebida("Suco de Laranja Del Valle", 3.00M);
        }

        private void btnRefriCoca_Click(object sender, EventArgs e)
        {
            AdicionarBebida("Coca-Cola 2 Litros", 6.00M);
        }

        private void btnRefriPepsi_Click(object sender, EventArgs e)
        {
            AdicionarBebida("Pepsi 2 Litros", 5.00M);
        }

        private void btnLataPepsi_Click(object sender, EventArgs e)
        {
            AdicionarBebida("Pepsi lata", 3.00M);
        }

        private void btnSucoLimão_Click(object sender, EventArgs e)
        {
            AdicionarBebida("Suco de Limão Del Valle", 3.00M);
        }

        private void btnRefriFantaUva_Click(object sender, EventArgs e)
        {
            AdicionarBebida("Fanta-Uva 2 Litros", 4.50M);
        }

        private void btnLataFantaUva_Click(object sender, EventArgs e)
        {
            AdicionarBebida("Fanta-Uva Lata", 3.00M);
        }

        private void btnSucoUva_Click(object sender, EventArgs e)
        {

            AdicionarBebida("Suco de Uva Del Valle", 3.00M);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPrecoTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txtValorItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtValorAnterior_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbtLimpar_Click(object sender, EventArgs e)
        {

            ProdutosBebidas.Clear();
            txtPrecoTotal.Text = "";
            txtValorAnterior.Text = "";
            txtValorItem.Text = "";
            Form1.ProdutosForm1.Clear();

        }
    }
}