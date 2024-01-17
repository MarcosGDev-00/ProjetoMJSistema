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
    public partial class camposDetalhesCadastrarProdutos : Form
    {
        public camposDetalhesCadastrarProdutos()
        {
            InitializeComponent();
        }

        private void camposDetalhesCadastrarProdutos_Load(object sender, EventArgs e)
        {
            cxEstoque.Mask = "00,00";
            cxEstoque.PromptChar = '0';

            cxEstoqueMinimo.Mask = "00,00";
            cxEstoqueMinimo.PromptChar = '0';

            cxPesoBruto.Mask = "00,00";
            cxPesoBruto.PromptChar = '0';

            cxDiasValidade.Mask = "00,00";
            cxDiasValidade.PromptChar = '0';

            cxQntEmb.Mask = "00,00";
            cxQntEmb.PromptChar = '0';

            cxEstoqueMax.Mask = "00,00";
            cxEstoqueMax.PromptChar = '0';

            cxPesoLiquido.Mask = "00,00";
            cxPesoLiquido.PromptChar = '0';

            cxTara.Mask = "00,00";
            cxTara.PromptChar = '0';
        }

        private void cxEstoque_Click(object sender, EventArgs e)
        {
            cxEstoque.SelectionStart = 0;
        }

        private void cxEstoqueMinimo_Click(object sender, EventArgs e)
        {
            cxEstoqueMinimo.SelectionStart = 0;
        }

        private void cxPesoBruto_Click(object sender, EventArgs e)
        {
            cxPesoBruto.SelectionStart = 0;
        }

        private void cxDiasValidade_Click(object sender, EventArgs e)
        {
            cxDiasValidade.SelectionStart = 0;
        }

        private void cxQntEmb_Click(object sender, EventArgs e)
        {
            cxQntEmb.SelectionStart = 0;
        }

        private void cxEstoqueMax_Click(object sender, EventArgs e)
        {
            cxEstoqueMax.SelectionStart = 0;
        }

        private void cxPesoLiquido_Click(object sender, EventArgs e)
        {
            cxPesoLiquido.SelectionStart = 0;
        }

        private void cxTara_Click(object sender, EventArgs e)
        {
            cxTara.SelectionStart = 0;
        }
    }
}
