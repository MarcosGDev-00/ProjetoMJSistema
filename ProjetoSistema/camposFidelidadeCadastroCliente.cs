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
    public partial class camposFidelidadeCadastroCliente : Form
    {
        public string numeroCartaoFidadelidadeCliente = "";
        public string tabelaPrecosFidadelidadeCliente = "";
        public string vendedorFidadelidadeCliente = "";

        public camposFidelidadeCadastroCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void camposFidelidadeCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void cxNumeroCartaoFidelidade_TextChanged(object sender, EventArgs e)
        {
            this.numeroCartaoFidadelidadeCliente = cxNumeroCartaoFidelidade.Text;
        }

        private void cxTabelaPrecoFidelidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tabelaPrecosFidadelidadeCliente = cxTabelaPrecoFidelidade.Text;
        }

        private void cxVendedorFidelidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.vendedorFidadelidadeCliente = cxVendedorFidelidade.Text;
        }
    }
}
