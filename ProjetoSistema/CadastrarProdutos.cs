using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace ProjetoSistema
{
    public partial class CadastrarProdutos : Form
    {
        private camposAdicionaisCadastroProduto formAdicional = null;
        private camposBaseCadastroProduto formBase = null;
        private camposCombustivelCadastrarProdutos formCombustivel = null;
        private camposComissãoCadastrarProdutos formComissao = null;
        private camposDetalhesCadastrarProdutos formDetalhes = null;
        private camposEstoqueCadastroProdutos formEstoque = null;
        private camposFotosCadastrarProdutos formFotos = null;
        private camposMedicamentosCadastroProdutos formMedicamento = null;
        private camposObservacoesCadastroProdutos formObs = null;
        private camposPrecosCadastroProdutos formPrecos = null;
        private camposPromocaoCadastrarProdutos formPromo = null;
        private camposTributosCadastroProdutos formTributos = null;
        private camposTributosCadastroProdutosGeral formTributosGeral = null;
        private camposTributosCadastroProdutosICMS formTributosIcms = null;
        private camposTributosCadastroProdutosPIS formTributosPis = null;
        private camposTributosCadastroProdutosIPI formTributosIpi = null;
        private camposTributosCadastroProdutosCONFINS formTributosConfins = null;
        
        
        private GerenciadorFormulario gerenciadorFormulario = new GerenciadorFormulario();

        public CadastrarProdutos()
        {
            InitializeComponent();

            formBase = new camposBaseCadastroProduto();
            formAdicional = new camposAdicionaisCadastroProduto();
            formCombustivel = new camposCombustivelCadastrarProdutos();
            formComissao = new camposComissãoCadastrarProdutos();
            formDetalhes = new camposDetalhesCadastrarProdutos();
            formEstoque = new camposEstoqueCadastroProdutos();
            formFotos = new camposFotosCadastrarProdutos();
            formMedicamento = new camposMedicamentosCadastroProdutos();
            formObs = new camposObservacoesCadastroProdutos();
            formPrecos = new camposPrecosCadastroProdutos();
            formPromo = new camposPromocaoCadastrarProdutos();
            formTributos = new camposTributosCadastroProdutos();
            formTributosGeral = new camposTributosCadastroProdutosGeral();
            formTributosIcms = new camposTributosCadastroProdutosICMS();
            formTributosPis = new camposTributosCadastroProdutosPIS();
            formTributosConfins = new camposTributosCadastroProdutosCONFINS();
        }

        public class GerenciadorFormulario
        {
            private Form formAtivo = null;

            public void ExibirFormFilhoNoPanel(Form exibirForm, Panel panel)
            {
                if (formAtivo != null)
                {
                    formAtivo = null;
                }

                formAtivo = exibirForm;

                exibirForm.TopLevel = false;
                exibirForm.FormBorderStyle = FormBorderStyle.None;
                exibirForm.Dock = DockStyle.Fill;
                panel.Controls.Add(exibirForm);
                panel.Tag = exibirForm;
                exibirForm.BringToFront();
                exibirForm.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formBase, panelCampos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formAdicional, panelCampos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formPrecos, panelCampos);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formTributos, panelCampos);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formDetalhes, panelCampos);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formEstoque, panelCampos);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formPromo, panelCampos);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formMedicamento, panelCampos);
        }

        private void CadastrarProdutos_Load(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formBase, panelCampos);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formCombustivel, panelCampos);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formObs, panelCampos);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formComissao, panelCampos);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formFotos, panelCampos);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            banco.conectar();
            CadastrarProduto produto = new CadastrarProduto();
            
            // CAMPOS BASE
            //produto.CodigoInterno = formBase.codigoInternoProduto;
            //produto.CodigoAdicional = formBase.codigoProduto;
            /*produto.referencia = formBase.referenciaProduto;
            produto.CodigoBarras = formBase.codigoBarrasProduto;
            produto.Nome = formBase.nomeProduto;
            produto.UnidadeMedida = formBase.uniddePoduto;
            produto.Descricao = formBase.descricaoProduto;
            produto.TipoProduto = formBase.tipoProduto;
            produto.Categoria = formBase.categoriaProduto;
            produto.Subcategoria = formBase.subcategoriaProduto;
            produto.Fabricante = formBase.fabricanteProduto;
            produto.Fornecedor = formBase.fornecedorProduto;

            // CAMPOS ADICIONAL
            produto.Status = formAdicional.produtoAtivo;
            produto.ReceberDesconto = formAdicional.produtoReceberDesconto;
            produto.VenderFracionado = formAdicional.produtoVendidoFracionado;
            produto.ControlarEstoque = formAdicional.produtoControlarLote;
            produto.Balanca = formAdicional.produtoBalanca;
            produto.BalancaCheckout = formAdicional.produtoBalancaCheck;
            produto.AtualizarPreco = formAdicional.produtoAtualizarPreco;
            produto.AtualizarNcmEntradaEstoque = formAdicional.produtoAtualizarNCM;

            //CAMPOS PRECOS
            produto.PrecoCompra = Convert.ToDecimal(formPrecos.precoCompraProduto);
            produto.Ipi = Convert.ToDecimal(formPrecos.ipiProduto);
            produto.ValorFrete = Convert.ToDecimal(formPrecos.valorFreteProduto);
            produto.CustoMedio = Convert.ToDecimal(formPrecos.custoMédioProduto);
            produto.Custo = Convert.ToDecimal(formPrecos.custoProduto);
            produto.PrecoVenda = Convert.ToDecimal(formPrecos.precoVendaProduto);
            produto.Margem = Convert.ToDecimal(formPrecos.margemProduto);
            produto.DescMax = Convert.ToDecimal(formPrecos.descMaximoProduto);
            produto.Preco2 = Convert.ToDecimal(formPrecos.preco2Produto);
            produto.Margem2 = Convert.ToDecimal(formPrecos.margem2Produto);
            produto.QntMinima2 = Convert.ToDecimal(formPrecos.qntMinima2Produto);
            produto.DescMax2 = Convert.ToDecimal(formPrecos.descMaximo2Produto);
            produto.Preco3 = Convert.ToDecimal(formPrecos.preco3Produto);
            produto.Margem3 = Convert.ToDecimal(formPrecos.margem3Produto);
            produto.QntMinima3 = Convert.ToDecimal(formPrecos.qntMinima3Produto);
            produto.DescMax3 = Convert.ToDecimal(formPrecos.descMaximo3Produto);
            produto.Preco4 = Convert.ToDecimal(formPrecos.preco4Produto);
            produto.Margem4 = Convert.ToDecimal(formPrecos.margem4Produto);
            produto.QntMinima4 = Convert.ToDecimal(formPrecos.qntMinima4Produto);
            produto.DescMax4 = Convert.ToDecimal(formPrecos.descMaximo4Produto);

            // CAMPOS TRIBUTOS
            // GERAL
            produto.GrupoTrib = formTributosGeral.grupoTributarioProduto;
            produto.Cst = formTributosGeral.cstProduto;
            produto.Cfop = formTributosGeral.cfopProduto;
            produto.Origem = formTributosGeral.origemProduto;
            produto.Ncm = formTributosGeral.NCMProduto;
            produto.Cest = formTributosGeral.CESTProduto;
            produto.Genero = formTributosGeral.generoProduto;

            // CONFINS
            produto.ConfinsSaida = formTributosConfins.confinsSaida;
            produto.ConfinsEntrada = formTributosConfins.confinsEntrada;
            produto.ConfinsAliquotaSaida = Convert.ToDecimal(formTributosConfins.aliquotaConfinsSaida);
            produto.ConfinsAliquotaEntrada = Convert.ToDecimal(formTributosConfins.aliquotaConfinsEntrada);*/
        }
    }
}
