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
    public partial class camposPrecosCadastroProdutos : Form
    {
        public string precoCompraProduto { get { return cxPrecoCompraPrecos.Text; } }
        public string ipiProduto { get { return cxIPIPrecos.Text; } }
        public string valorFreteProduto { get { return cxValorFretePrecos.Text; } }
        public string custoMédioProduto { get { return cxCustoMedioPrecos.Text; } }
        public string custoProduto { get { return cxCustoPrecos.Text; } }
        public string precoVendaProduto { get { return cxPrecoVendaPrecos.Text; } }
        public string margemProduto { get { return cxCustoMedioPrecos.Text; } }
        public string descMaximoProduto { get { return cxDescMaxPrecos.Text; } }
        public string preco2Produto { get { return cxPreco2Precos.Text; } }
        public string preco3Produto { get { return cxPreco3Precos.Text; } }
        public string preco4Produto { get { return cxPreco4Precos.Text; } }
        public string margem2Produto { get { return cxMargem2Precos.Text; } }
        public string margem3Produto { get { return cxMargem3Precos.Text; } }
        public string margem4Produto { get { return cxMargem4Precos.Text; } }
        public string qntMinima2Produto { get { return cxQuantMinima2Precos.Text; } }
        public string qntMinima3Produto { get { return cxQuantMinima3Precos.Text; } }
        public string qntMinima4Produto { get { return cxQuantMinima4Precos.Text; } }
        public string descMaximo2Produto { get { return cxDescMax2Precos.Text; } }
        public string descMaximo3Produto { get { return cxDescMax3Precos.Text; } }
        public string descMaximo4Produto { get { return cxDescMax4Precos.Text; } }

        public camposPrecosCadastroProdutos()
        {
            InitializeComponent();
        }

        private void camposPrecosCadastroProdutos_Load(object sender, EventArgs e)
        {

        }
    }
}
