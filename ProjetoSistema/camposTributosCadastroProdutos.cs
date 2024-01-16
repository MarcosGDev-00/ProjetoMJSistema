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
        public camposTributosCadastroProdutos()
        {
            InitializeComponent();
        }

        private void camposTributosCadastroProdutos_Load(object sender, EventArgs e)
        {

        }

        public Form formAtivo = null;
        public void exibirFormFilhoNoPanel(Form exibirForm)
        {
            if (formAtivo != null)
                formAtivo.Close();
            formAtivo = exibirForm;
            exibirForm.TopLevel = false;
            exibirForm.FormBorderStyle = FormBorderStyle.None;
            exibirForm.Dock = DockStyle.Fill;
            panelCamposTributos.Controls.Add(exibirForm);
            panelCamposTributos.Tag = exibirForm;
            exibirForm.BringToFront();
            exibirForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new camposTributosCadastroProdutosGeral());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new camposTributosCadastroProdutosPIS());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new camposTributosCadastroProdutosCONFINS());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new camposTributosCadastroProdutosIPI());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new camposTributosCadastroProdutosICMS());
        }
    }
}
