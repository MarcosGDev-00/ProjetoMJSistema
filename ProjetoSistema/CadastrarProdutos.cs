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
        public CadastrarProdutos()
        {
            InitializeComponent();
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
            panelCampos.Controls.Add(exibirForm);
            panelCampos.Tag = exibirForm;
            exibirForm.BringToFront();
            exibirForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new camposBaseCadastroProduto());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new camposAdicionaisCadastroProduto());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new camposPrecosCadastroProdutos());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new camposTributosCadastroProdutos());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new camposDetalhesCadastrarProdutos());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new camposEstoqueCadastroProdutos());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new camposPromocaoCadastrarProdutos());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new camposMedicamentosCadastroProdutos());
        }

        private void CadastrarProdutos_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new camposCombustivelCadastrarProdutos());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new camposObservacoesCadastroProdutos());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new camposComissãoCadastrarProdutos());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new camposFotosCadastrarProdutos());
        }
    }
}
