using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSistema
{
    public partial class camposBaseCadastroProduto : Form
    {
        public string codigoInternoProduto { get { return cxCódigoInternoProdutoBase.Text; } }
        public string codigoProduto { get { return cxCategoriaProdutoBase.Text; } }
        public string referenciaProduto { get { return cxReferenciaProdutoBase.Text; } }
        public string codigoBarrasProduto { get { return cxCodigoBarrasBase.Text; } }
        public string nomeProduto { get { return cxNomeProdutoBase.Text; } }
        public string uniddePoduto { get { return cxUnidadeProdutoBase.Text; } }
        public string descricaoProduto { get { return cxDescricaoProdutoBase.Text; } }
        public string tipoProduto { get { return cxTipoProdutoBase.Text; } }
        public string categoriaProduto { get { return cxCategoriaProdutoBase.Text; } }
        public string subcategoriaProduto { get { return cxSubcategoriaProdutosBase.Text; } }
        public string fabricanteProduto { get { return cxFabricanteProdutoBase.Text; } }
        public string fornecedorProduto { get { return cxFornecedorProdutoBase.Text; } }

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem cadastrarNovoTipoToolStripMenuItem;
        private ComboBox comboBoxTipoProduto;

        public camposBaseCadastroProduto()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        

        private void camposBaseCadastroProduto_Load(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            banco.conectar();
            List<string> tipoproduto = banco.MostrarTipoProduto();
            List<string> categorias = banco.MostrarCategorias();
            List<string> subcategorias = banco.MostrarSubcategorias();
            List<string> fabricante = banco.MostrarFabricante();
            List<string> fornecedor = banco.MostrarFornecedor();

            cxTipoProdutoBase.Items.Clear();
            cxCategoriaProdutoBase.Items.Clear();
            cxSubcategoriaProdutosBase.Items.Clear();
            cxFabricanteProdutoBase.Items.Clear();
            cxFornecedorProdutoBase.Items.Clear();

            cxTipoProdutoBase.DataSource = tipoproduto;
            cxTipoProdutoBase.Text = "Selecione";
            cxCategoriaProdutoBase.DataSource = categorias;
            cxCategoriaProdutoBase.Text = "Selecione";
            cxSubcategoriaProdutosBase.DataSource = subcategorias;
            cxSubcategoriaProdutosBase.Text = "Selecione";
            cxFabricanteProdutoBase.DataSource = fabricante;
            cxFabricanteProdutoBase.Text = "Selecione";
            cxFornecedorProdutoBase.DataSource = fornecedor;
            cxFornecedorProdutoBase.Text = "Selecione";
        }

        private void comboBoxTipoProd_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void CadastrarNovoTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            CadastrarTipoProduto cadastrarTipoProduto = new CadastrarTipoProduto();
            cadastrarTipoProduto.ShowDialog();
        }
    }
}
