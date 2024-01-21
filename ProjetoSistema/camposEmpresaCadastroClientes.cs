using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSistema
{
    public partial class camposEmpresaCadastroClientes : Form
    {
        public string nomeEmpresaCliente = "";
        public string telefoneClienteEmpresa = "";
        public string enderecoClienteEmpresa = "";
        public string NenderecoClienteEmpres = "";
        public string cepClienteEmpresa = "";
        public string bairroClienteEmpresa = "";
        public string ufClienteEmpresa = "";
        public string cidadeClienteEmpresa = "";
        public string cargoClienteEmpresa = "";
        public string rendaClienteEmpresa = "";
        public string admissaoClienteEmpresa = "";

        public camposEmpresaCadastroClientes()
        {
            InitializeComponent();
            ConfigurarControles();
        }

        private void camposEmpresaCadastroClientes_Load(object sender, EventArgs e)
        {
            cxRendaEmpresa.Mask = "00,00";
            cxRendaEmpresa.PromptChar = '0';

            cxTelefoneEmpresa.Mask = "(00)00000-0000";
            cxTelefoneEmpresa.PromptChar = ' ';
        }

        private void ConfigurarControles()
        {
            cxAdmissaoEmpresa.Mask = "00/00/0000";
            cxAdmissaoEmpresa.ValidatingType = typeof(DateTime);
            cxAdmissaoEmpresa.PromptChar = ' ';

            dtAdmissao.Format = DateTimePickerFormat.Short;
            dtAdmissao.CustomFormat = "   /   /      ";

            cxAdmissaoEmpresa.TypeValidationCompleted += cxAdmissao_TypeValidationCompleted_1;
            dtAdmissao.ValueChanged += dtAdmissao_ValueChanged;
            cxAdmissaoEmpresa.TextChanged += cxAdmissao_TextChanged_1;
        }

        private void cxAdmissao_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida. Digite uma data válida.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cxAdmissaoEmpresa.Text = "";
            }
            else
            {
                dtAdmissao.Value = cxAdmissaoEmpresa.Text == "" ? DateTimePicker.MinimumDateTime : (DateTime)e.ReturnValue;
            }
        }

        private void dtAdmissao_ValueChanged(object sender, EventArgs e)
        {
            cxAdmissaoEmpresa.Text = dtAdmissao.Value.ToString("dd/MM/yyyy");
        }

        private void cxAdmissao_TextChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(cxAdmissaoEmpresa.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime result))
            {
                dtAdmissao.Value = result;
            }
        }

        private void cxAdmissao_TypeValidationCompleted_1(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida. Digite uma data válida.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cxAdmissaoEmpresa.Text = "";
            }
            else
            {
                dtAdmissao.Value = cxAdmissaoEmpresa.Text == "" ? DateTimePicker.MinimumDateTime : (DateTime)e.ReturnValue;
            }
        }

        private void cxAdmissao_TextChanged_1(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(cxAdmissaoEmpresa.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime result))
            {
                dtAdmissao.Value = result;
            }
        }

        private void cxNomeEmpresaEmpresa_TextChanged(object sender, EventArgs e)
        {
            this.nomeEmpresaCliente = cxNomeEmpresaEmpresa.Text;
        }

        private void cxTelefoneEmpresa_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.telefoneClienteEmpresa = cxTelefoneEmpresa.Text;
        }

        private void cxEnderecoEmpresa_TextChanged(object sender, EventArgs e)
        {
            this.enderecoClienteEmpresa = cxEnderecoEmpresa.Text;
        }

        private void cxNenderecoEmpresa_TextChanged(object sender, EventArgs e)
        {
            this.NenderecoClienteEmpres = cxNenderecoEmpresa.Text;
        }

        private void cxCepEmpresa_TextChanged(object sender, EventArgs e)
        {
            this.cepClienteEmpresa = cxCepEmpresa.Text;
        }

        private void cxBairroEmpresa_TextChanged(object sender, EventArgs e)
        {
            this.bairroClienteEmpresa = cxBairroEmpresa.Text;
        }

        private void cxUfEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ufClienteEmpresa = cxUfEmpresa.Text;
        }

        private void cxCidadeEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cidadeClienteEmpresa = cxCidadeEmpresa.Text;
        }

        private void cxCargoEmpresa_TextChanged(object sender, EventArgs e)
        {
            this.cargoClienteEmpresa = cxCargoEmpresa.Text;
        }

        private void cxRendaEmpresa_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.rendaClienteEmpresa = cxRendaEmpresa.Text;
        }

        private void cxAdmissaoEmpresa_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.admissaoClienteEmpresa = cxAdmissaoEmpresa.Text;
        }
    }
}
