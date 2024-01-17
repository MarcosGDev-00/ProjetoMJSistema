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
    public partial class camposMedicamentosCadastroProdutosFarmaPopular : Form
    {
        public camposMedicamentosCadastroProdutosFarmaPopular()
        {
            InitializeComponent();
        }

        private void camposMedicamentosCadastroProdutosFarmaPopular_Load(object sender, EventArgs e)
        {
            cxPrecoVenda.Mask = "00,00";
            cxPrecoVenda.PromptChar = '0';

            cxMargem.Mask = "00,00";
            cxMargem.PromptChar = '0';

            cxAprCX.Mask = "00,00";
            cxAprCX.PromptChar = '0';

            cxPrecoVenda.Click += cxPrecoVenda_Click;
            cxMargem.Click += cxMargem_Click;
            cxAprCX.Click += cxAprCX_Click;
        }

        private void cxPrecoVenda_MouseEnter(object sender, EventArgs e)
        {
        }

        private void cxPrecoVenda_Click(object sender, EventArgs e)
        {
            cxPrecoVenda.SelectionStart = 0;
        }

        private void cxMargem_Click(object sender, EventArgs e)
        {
            cxMargem.SelectionStart = 0;
        }

        private void cxAprCX_Click(object sender, EventArgs e)
        {
            cxAprCX.SelectionStart = 0;
        }
    }
}
