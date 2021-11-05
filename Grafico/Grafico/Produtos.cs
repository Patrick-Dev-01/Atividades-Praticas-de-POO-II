using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafico
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            dataGridView1.DataSource = produto.ListarProdutos();
        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            try {
                produto.CadastrarProduto(textBox1.Text, (int)numericUpDown1.Value, (float)numericUpDown2.Value);

                MessageBox.Show("Produto cadastrado com Sucesso", "Cadastro de Produtos");
            }

            catch {
                MessageBox.Show("Erro ao cadastrar o produto", "Erro no Cadastro");
            }
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'produtosDataSet.tbProdutos'. Você pode movê-la ou removê-la conforme necessário.
            this.tbProdutosTableAdapter.Fill(this.produtosDataSet.tbProdutos);

            chart1.Series["Preço"].YValueMembers = "quantidade";
            chart1.Series["Preço"].XValueMember = "nomeProduto";
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
