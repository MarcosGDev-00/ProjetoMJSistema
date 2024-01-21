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
    public partial class CadastrarProdutoNoEstoque : Form
    {
        private camposDadosDaNotaEntradaEstoque formDadosNota = null;
        private camposProdutoEntradaEstoque formProduto = null;
        private camposCalcImpostoEntradaEstoque formImposto = null;
        private camposContasPagarEntradaEstoque formContas = null;

        private GerenciadorFormulario gerenciadorFormulario = new GerenciadorFormulario();
        public CadastrarProdutoNoEstoque()
        {
            InitializeComponent();

            formDadosNota = new camposDadosDaNotaEntradaEstoque();
            formProduto = new camposProdutoEntradaEstoque();
            formImposto = new camposCalcImpostoEntradaEstoque();
            formContas = new camposContasPagarEntradaEstoque();
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

        private void button1_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formDadosNota, panelCampos);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formProduto, panelCampos);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formImposto, panelCampos);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formContas, panelCampos);
        }
    }
}
