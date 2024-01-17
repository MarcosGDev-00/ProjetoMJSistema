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
    public partial class camposTributosCadastroProdutos : Form
    {
        private camposTributosCadastroProdutosCONFINS formTributosCONFINS = null;
        private camposTributosCadastroProdutosGeral formTributosGeral = null;
        private camposTributosCadastroProdutosICMS formTributosICMS = null;
        private camposTributosCadastroProdutosIPI formTributosIPI = null;
        private camposTributosCadastroProdutosPIS formTributosPIS = null;

        private GerenciadorFormulario gerenciadorFormulario = new GerenciadorFormulario();
        public camposTributosCadastroProdutos()
        {
            InitializeComponent();

            formTributosCONFINS = new camposTributosCadastroProdutosCONFINS();
            formTributosGeral = new camposTributosCadastroProdutosGeral();
            formTributosICMS = new camposTributosCadastroProdutosICMS();
            formTributosIPI = new camposTributosCadastroProdutosIPI();
            formTributosPIS = new camposTributosCadastroProdutosPIS();
        }

        private void camposTributosCadastroProdutos_Load(object sender, EventArgs e)
        {

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
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formTributosGeral, panelCamposTributos);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formTributosPIS, panelCamposTributos);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formTributosCONFINS, panelCamposTributos);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formTributosIPI, panelCamposTributos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formTributosICMS, panelCamposTributos);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
