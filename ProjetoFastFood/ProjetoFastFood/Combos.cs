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
    public partial class Combos : Form
    {

        public static BindingList<Produto> ProdutosCombo = new BindingList<Produto>();

        public Combos()
        {
            InitializeComponent();
            Form1.BindingListBox(listBox1, ProdutosCombo);

            ProdutosCombo.ListChanged += ProdutosListChanged;
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

       

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMM_Click(object sender, EventArgs e)
        {
            AdicionarBebida("Combo Frango com Batata", 17.90M);
        }

        private void btnPetitiGateu_Click(object sender, EventArgs e)
        {
            AdicionarBebida("Combo Beirute com Batata", 15.00M);
        }

        private void AdicionarBebida(String produto, decimal valor)
        {
            Form1.AdicionarProduto(ProdutosCombo, produto, valor, txtValorItem);
        }

        private IWin32Window ltbListaAdd(string p)
        {
            throw new NotImplementedException();
        }

        public IWin32Window listaItensDaltbLista { get; set; }

        private void Combos_Load(object sender, EventArgs e)
        {

        }

        private void btnBrownie_Click(object sender, EventArgs e)
        {
            AdicionarBebida("Combo Hamburguer com Batata", 15.00M);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdicionarBebida("Combo Double com Batata", 18.00M);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ProdutosCombo.Clear();
            txtPrecoTotal.Text = "";
            txtValorAnterior.Text = "";
            txtValorItem.Text = "";
            Form1.ProdutosForm1.Clear();
        }
    }
}
