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
        public camposMedicamentosCadastroProdutos()
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
            panelCamposMedicamentos.Controls.Add(exibirForm);
            panelCamposMedicamentos.Tag = exibirForm;
            exibirForm.BringToFront();
            exibirForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new camposMedicamentosCadastroProdutosGeral());
        }

        private void camposMedicamentosCadastroProdutos_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new camposMedicamentosCadastroProdutosSNGPC());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new camposMedicamentosCadastroProdutosFarmaPopular());
        }
    }
}
