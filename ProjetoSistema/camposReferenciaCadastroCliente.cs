using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProjetoSistema
{
    public partial class camposReferenciaCadastroCliente : Form
    {
        public string refereniaClienteRefrencia = "";
        public string comercial1ClienteRefrencia = "";
        public string comercial2ClienteRefrencia = "";
        public string comercial3ClienteRefrencia = "";
        public string bancaria1ClienteRefrencia = "";
        public string bancaria2lienteRefrencia = "";

        public camposReferenciaCadastroCliente()
        {
            InitializeComponent();
        }

        private void camposReferenciaCadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void cxReferenciaReferencia_TextChanged(object sender, EventArgs e)
        {
            this.refereniaClienteRefrencia = cxReferenciaReferencia.Text;
        }

        private void cxComercial1Referencia_TextChanged(object sender, EventArgs e)
        {
            this.comercial1ClienteRefrencia = cxComercial1Referencia.Text;
        }

        private void cxComercial2Referencia_TextChanged(object sender, EventArgs e)
        {
            this.comercial2ClienteRefrencia = cxComercial2Referencia.Text;
        }

        private void cxComercial3Referencia_TextChanged(object sender, EventArgs e)
        {
            this.comercial3ClienteRefrencia = cxComercial3Referencia.Text;
        }

        private void cxBancaria1Referencia_TextChanged(object sender, EventArgs e)
        {
            this.bancaria1ClienteRefrencia = cxBancaria1Referencia.Text;
        }

        private void cxBancaria2Referencia_TextChanged(object sender, EventArgs e)
        {
            this.bancaria2lienteRefrencia = cxBancaria2Referencia.Text;
        }
    }
}
