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
    public partial class camposMedicamentosCadastroProdutos : Form
    {
        private camposMedicamentosCadastroProdutosFarmaPopular formMedicamentosFarmaPop = null;
        private camposMedicamentosCadastroProdutosGeral formMedicamentosProdutosGeral = null;
        private camposMedicamentosCadastroProdutosSNGPC formMedicamentosSNGPC = null;

        private GerenciadorFormulario gerenciadorFormulario = new GerenciadorFormulario();
        public camposMedicamentosCadastroProdutos()
        {
            InitializeComponent();

            formMedicamentosFarmaPop = new camposMedicamentosCadastroProdutosFarmaPopular();
            formMedicamentosProdutosGeral = new camposMedicamentosCadastroProdutosGeral();
            formMedicamentosSNGPC = new camposMedicamentosCadastroProdutosSNGPC();
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
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formMedicamentosProdutosGeral, panelCamposMedicamentos);
        }

        private void camposMedicamentosCadastroProdutos_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formMedicamentosSNGPC, panelCamposMedicamentos);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formMedicamentosFarmaPop, panelCamposMedicamentos);
        }
    }
}
