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
    public partial class camposEndEntregaCadastrarCliente : Form
    {
        public string enderecoEntregaCliente = "";
        public string referenciaEnderecoEntrgaCliente = "";
        public string nEnderecoEntrgaClliente = "";
        public string cepEnderecoEntregaCliente = "";
        public string bairroEnderecoEntregaCliente = "";
        public string estadoEnderecoEntregaCliente = "";    
        public string cidadeEnderecoEntregaCliente = "";

        public camposEndEntregaCadastrarCliente()
        {
            InitializeComponent();
        }
        
        private void camposEndEntregaCadastrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void cxEnderecoEndEntregaCliente_TextChanged(object sender, EventArgs e)
        {
            this.enderecoEntregaCliente = cxEnderecoEndEntregaCliente.Text;
        }

        private void cxReferenciaEndEntregaCliente_TextChanged(object sender, EventArgs e)
        {
            this.referenciaEnderecoEntrgaCliente = cxReferenciaEndEntregaCliente.Text;
        }

        private void cxNumeroEnderecoEndEntregaCliente_TextChanged(object sender, EventArgs e)
        {
            this.nEnderecoEntrgaClliente = cxNumeroEnderecoEndEntregaCliente.Text;
        }

        private void cxCepEndEntregaCliente_TextChanged(object sender, EventArgs e)
        {
            this.cepEnderecoEntregaCliente = cxCepEndEntregaCliente.Text;
        }

        private void cxBairroEndEntregaCliente_TextChanged(object sender, EventArgs e)
        {
            this.bairroEnderecoEntregaCliente = cxBairroEndEntregaCliente.Text;
        }

        private void cxEstadoEndEntregaCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.estadoEnderecoEntregaCliente = cxEstadoEndEntregaCliente.Text;
        }

        private void cxCidadeEndEntregaCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cidadeEnderecoEntregaCliente = cxCidadeEndEntregaCliente.Text;
        }
    }
}
