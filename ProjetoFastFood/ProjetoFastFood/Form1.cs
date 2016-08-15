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
    public partial class Form1 : Form
    {
        private IWin32Window listaItensDaltbLista;
        public static BindingList<Produto> ProdutosForm1 = new BindingList<Produto>();

        public static void AdicionarProduto(BindingList<Produto> produtos, string nomeBebida, decimal preco, TextBox txtValorItem)
        {
            txtValorItem.Text = preco.ToString();

            produtos.Add(new Produto
            {
                Nome = string.Format("{0}: R$ {1}", nomeBebida, preco),
                Preco = preco
            });

            ProdutosForm1.Add(new Produto
            {
                Nome = string.Format("{0}: R$ {1}", nomeBebida, preco),
                Preco = preco
            });
        }


        public static void BindingListBox(ListBox listProdutos, BindingList<Produto> produtos)
        {

            listProdutos.DataSource = produtos;
            listProdutos.DisplayMember = "Nome";
            listProdutos.ValueMember = "Preco";
        }
        public Form1()
        {
            InitializeComponent();

            BindingListBox(ltbLista, ProdutosForm1);
            ProdutosForm1.ListChanged += ProdutosListChanged;
        }

        private void ProdutosListChanged(object sender, ListChangedEventArgs e)
        {
            var itens = ((BindingList<Produto>)sender);

            if (itens.Count > 0)
            {
                var total = itens.Sum(c => c.Preco);
                txtTotal.Text = total.ToString();
            }
            else {
                txtTotal.Text = string.Empty;
            }
        }
        public Form1(IWin32Window listaItensDaltbLista)
        {
            // TODO: Complete member initialization
            this.listaItensDaltbLista = listaItensDaltbLista;
        }

        private void btnCadastroClientes_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.ShowDialog();


        }

        private void btnLanches_Click(object sender, EventArgs e)
        {
            Lanches obj = new Lanches();
            obj.ShowDialog();

        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            Bebidas obj = new Bebidas();
            obj.ShowDialog();
        }

        private void btnSobremesas_Click(object sender, EventArgs e)
        {
            Sobremesas obj = new Sobremesas();
            obj.ShowDialog();
        }

        private void btnCombos_Click(object sender, EventArgs e)
        {
            Combos obj = new Combos();
            obj.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ltbListaSelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public void btnLataCoca_Click(object sender, EventArgs e)
        {
            //double bebidas = 0;
            ///bebidas = 12;            
            // ltbLista.Items.Add("caca-cola"+bebidas);
            //double bebidas = 0;
            //bebidas = 12;
            // listBox1.Items.Add("caca-cola" + bebidas);
            //textBox2.Text = bebidas.ToString();
            //textBox3.Text = bebidas.ToString();


            // double Total = bebidas + +bebidas + bebidas;
            //textBox1.Text = Convert.ToString(Total);
        }

        private void btnTroco_Click(object sender, EventArgs e)
        {
            double valorTotal, valorPago, troco;

            valorTotal = Convert.ToDouble(txtTotal.Text);
            valorPago = Convert.ToDouble(txtRecebido.Text);

            troco = valorPago - valorTotal;


            txtTroco.Text = String.Format("{0:C}", troco);
        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido Finalizado !");

            ProdutosForm1.Clear();
            Bebidas.ProdutosBebidas.Clear();
            Sobremesas.ProdutosSobremesas.Clear();
            Combos.ProdutosCombo.Clear();
            Lanches.ProdutosLanches.Clear();
           

            txtRecebido.Text=String.Empty;
            txtTotal.Text=String.Empty;
            txtTroco.Text=String.Empty;
    
    }

        private void txtRecebido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

