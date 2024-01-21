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
    public partial class camposCalcImpostoEntradaEstoque : Form
    {
        public camposCalcImpostoEntradaEstoque()
        {
            InitializeComponent();
        }

        private void camposCalcImpostoEntradaEstoque_Load(object sender, EventArgs e)
        {
            cxBaseICMS.Mask = "00,00";
            cxBaseICMS.PromptChar = '0';

            cxValorICMS.Mask = "00,00";
            cxValorICMS.PromptChar = '0';

            cxBaseICMSST.Mask = "00,00";
            cxBaseICMSST.PromptChar = '0';

            cxValorICMSST.Mask = "00,00";
            cxValorICMSST.PromptChar = '0';

            cxTotalProdutos.Mask = "00,00";
            cxTotalProdutos.PromptChar = '0';

            cxValorFrete.Mask = "00,00";
            cxValorFrete.PromptChar = '0';

            cxValorSeguro.Mask = "00,00";
            cxValorSeguro.PromptChar = '0';

            cxDesconto.Mask = "00,00";
            cxDesconto.PromptChar = '0';

            cxDespezas.Mask = "00,00";
            cxDespezas.PromptChar = '0';

            cxTotalImposto.Mask = "00,00";
            cxTotalImposto.PromptChar = '0';

            cxValorPIS.Mask = "00,00";
            cxValorPIS.PromptChar = '0';

            cxValorCONFINS.Mask = "00,00";
            cxValorCONFINS.PromptChar = '0';

            cxValorIPI.Mask = "00,00";
            cxValorIPI.PromptChar = '0';

            cxValorII.Mask = "00,00";
            cxValorII.PromptChar = '0';

            cxTotalNota.Mask = "00,00";
            cxTotalNota.PromptChar = '0';
        }
    }
}
