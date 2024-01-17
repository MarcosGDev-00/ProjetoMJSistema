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
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formComissao, panelCampos);
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
    }
}
