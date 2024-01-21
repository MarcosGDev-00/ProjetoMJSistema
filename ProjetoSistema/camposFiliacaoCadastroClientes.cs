using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSistema
{
    public partial class camposFiliacaoCadastroClientes : Form
    {
        public string paiCliente = "";
        public string telefonePaiCliente = "";
        public string maeCliente = "";
        public string telefoneMaeCliente = "";  
        public string enderecoFiliacaoCliente = "";
        public string referenciaFiliacaoCliente = "";       
        public string numeroEndFiliacaooCliente = "";
        public string cepEndFiliacaoCliente = "";
        public string bairroFiliacaoCliente = "";
        public string estadoFiliacaoCliente = "";
        public string cidadeFiliacaoCliente = "";

        public camposFiliacaoCadastroClientes()
        {
            InitializeComponent();
        }

        private void maskedTextBoxTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void camposFiliacaoCadastroClientes_Load(object sender, EventArgs e)
        {
            cxTelefonePaiClienteFiliacao.Mask = "(00)00000-0000";
            cxTelefonePaiClienteFiliacao.PromptChar = ' ';

            cxTelefoneMaeClienteFiliacao.Mask = "(00)00000-0000";
            cxTelefoneMaeClienteFiliacao.PromptChar = ' ';
        }

        private void cxPaiClienteFiliacao_TextChanged(object sender, EventArgs e)
        {
            this.paiCliente = cxPaiClienteFiliacao.Text;
        }

        private void cxTelefonePaiClienteFiliacao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.telefonePaiCliente = cxTelefonePaiClienteFiliacao.Text;
        }

        private void cxMaeClienteFiliacao_TextChanged(object sender, EventArgs e)
        {
            this.telefoneMaeCliente = cxTelefoneMaeClienteFiliacao.Text;
        }

        private void cxTelefoneMaeClienteFiliacao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.telefoneMaeCliente = cxTelefoneMaeClienteFiliacao.Text;
        }

        private void cxEnderecoClienteFiliacao_TextChanged(object sender, EventArgs e)
        {
            this.enderecoFiliacaoCliente = cxEnderecoClienteFiliacao.Text;
        }

        private void cxReferenciaClienteFiliacao_TextChanged(object sender, EventArgs e)
        {
            this.referenciaFiliacaoCliente = cxReferenciaClienteFiliacao.Text;
        }

        private void cxNumeroEndClienteFiliacao_TextChanged(object sender, EventArgs e)
        {
            this.numeroEndFiliacaooCliente = cxNumeroEndClienteFiliacao.Text;
        }

        private void cxCepClienteFiliacao_TextChanged(object sender, EventArgs e)
        {
            this.cepEndFiliacaoCliente = cxCepClienteFiliacao.Text;
        }

        private void cxBairroClienteFiliacao_TextChanged(object sender, EventArgs e)
        {
            this.bairroFiliacaoCliente = cxBairroClienteFiliacao.Text;
        }

        private void cxEstadoClienteFiliacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.estadoFiliacaoCliente = cxEstadoClienteFiliacao.Text;
        }

        private void cxCidadeClienteFiliacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cidadeFiliacaoCliente = cxCidadeClienteFiliacao.Text;
        }
    }
}
