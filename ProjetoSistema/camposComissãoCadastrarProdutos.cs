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
    public partial class camposComissãoCadastrarProdutos : Form
    {
        public camposComissãoCadastrarProdutos()
        {
            InitializeComponent();
        }

        private void camposComissãoCadastrarProdutos_Load(object sender, EventArgs e)
        {
            cxComissaoPorcento.Mask = "00,00";
            cxComissaoPorcento.PromptChar = '0';

            cxComissaoReais.Mask = "00,00";
            cxComissaoReais.PromptChar = '0';

            cxPontos.Mask = "00,00";
            cxPontos.PromptChar = '0';

            cxComissaoPorcento.Click += cxComissaoPorcento_Click;
            cxComissaoReais.Click += cxComissaoReais_Click;
            cxPontos.Click += cxPontos_Click;
        }

        private void cxComissaoPorcento_Click(object sender, EventArgs e)
        {
            cxComissaoPorcento.SelectionStart = 0;
        }

        private void cxComissaoReais_Click(object sender, EventArgs e)
        {
            cxComissaoReais.SelectionStart = 0;
        }

        private void cxPontos_Click(object sender, EventArgs e)
        {
            cxComissaoReais.SelectionStart = 0;
        }
    }
}
