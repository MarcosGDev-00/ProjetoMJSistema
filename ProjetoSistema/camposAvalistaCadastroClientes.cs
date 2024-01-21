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
    public partial class camposAvalistaCadastroClientes : Form
    {
        public string nomeClienteAvalista = "";
        public string cpfClienteAvalista = "";
        public string rgClienteAvalista = "";
        public string dataNascimentoClienteAvalista = "";
        public string TelefoneClienteAvalista = "";
        public string enderecoClienteAvalista = "";
        public string numeroEnderecoClienteAvalista = "";
        public string cepClienteAvalista = "";
        public string bairroClienteAvalista = "";
        public string ufClienteAvalista = "";
        public string cidadeClienteAvalista = "";
        public string empresaClienteAvalista = "";
        public string cargolienteAvalista = "";
        public string rendaClienteAvalista = "";
        public string admissaoClienteAvalista = "";

        public camposAvalistaCadastroClientes()
        {
            InitializeComponent();
            ConfigurarControles();
        }

        private void camposAvalistaCadastroClientes_Load(object sender, EventArgs e)
        {
            cxRendaAvalista.Mask = "00,00";
            cxRendaAvalista.PromptChar = '0';

            cxFoneAvalista.Mask = "(00)00000-0000";
            cxFoneAvalista.PromptChar = ' ';
        }

        private void ConfigurarControles()
        {
            cxAdmissaoAvalista.Mask = "00/00/0000";
            cxAdmissaoAvalista.ValidatingType = typeof(DateTime);
            cxAdmissaoAvalista.PromptChar = ' ';

            dtAdmissaoAvalista.Format = DateTimePickerFormat.Short;
            dtAdmissaoAvalista.CustomFormat = "   /   /      ";

            cxAdmissaoAvalista.TypeValidationCompleted += cxAdmissaoAvalista_TypeValidationCompleted;
            dtAdmissaoAvalista.ValueChanged += dtAdmissaoAvalista_ValueChanged;
            cxAdmissaoAvalista.TextChanged += cxAdmissaoAvalista_TextChanged;

            cxDataNascimentoAvalista.Mask = "00/00/0000";
            cxDataNascimentoAvalista.ValidatingType = typeof(DateTime);
            cxDataNascimentoAvalista.PromptChar = ' ';

            dtDataNascimentoAvalista.Format = DateTimePickerFormat.Short;
            dtDataNascimentoAvalista.CustomFormat = "   /   /      ";

            cxDataNascimentoAvalista.TypeValidationCompleted += cxDataNascimentoAvalista_TypeValidationCompleted;
            dtDataNascimentoAvalista.ValueChanged += dtDataNascimentoAvalista_ValueChanged;
            cxDataNascimentoAvalista.TextChanged += cxDataNascimentoAvalista_TextChanged;
        }

        private void cxAdmissaoAvalista_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida. Digite uma data válida.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cxAdmissaoAvalista.Text = "";
            }
            else
            {
                dtAdmissaoAvalista.Value = cxAdmissaoAvalista.Text == "" ? DateTimePicker.MinimumDateTime : (DateTime)e.ReturnValue;
            }
        }

        private void dtDataNascimentoAvalista_ValueChanged(object sender, EventArgs e)
        {
            cxDataNascimentoAvalista.Text = dtDataNascimentoAvalista.Value.ToString("dd/MM/yyyy");
        }

        private void dtAdmissaoAvalista_ValueChanged(object sender, EventArgs e)
        {
            cxAdmissaoAvalista.Text = dtAdmissaoAvalista.Value.ToString("dd/MM/yyyy");
        }

        private void cxAdmissaoAvalista_TextChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(cxAdmissaoAvalista.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime result))
            {
                dtDataNascimentoAvalista.Value = result;
            }
        }

        private void cxDataNascimentoAvalista_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida. Digite uma data válida.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cxDataNascimentoAvalista.Text = "";
            }
            else
            {
                dtDataNascimentoAvalista.Value = cxAdmissaoAvalista.Text == "" ? DateTimePicker.MinimumDateTime : (DateTime)e.ReturnValue;
            }
        }

        private void cxDataNascimentoAvalista_TextChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(cxDataNascimentoAvalista.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime result))
            {
                dtDataNascimentoAvalista.Value = result;
            }
        }

        private void cxNomeAvalista_TextChanged(object sender, EventArgs e)
        {
            this.nomeClienteAvalista = cxNomeAvalista.Text;
        }

        private void cxCpfAvalista_TextChanged(object sender, EventArgs e)
        {
            this.cpfClienteAvalista = cxCpfAvalista.Text;
        }

        private void cxRgAvalista_TextChanged(object sender, EventArgs e)
        {
            this.rgClienteAvalista = cxRgAvalista.Text;
        }

        private void cxDataNascimentoAvalista_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.dataNascimentoClienteAvalista = cxDataNascimentoAvalista.Text;
        }

        private void cxFoneAvalista_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.TelefoneClienteAvalista = cxFoneAvalista.Text;
        }

        private void cxEnderecoAvalista_TextChanged(object sender, EventArgs e)
        {
            this.enderecoClienteAvalista = cxEnderecoAvalista.Text;
        }

        private void cxNenderecoAvalista_TextChanged(object sender, EventArgs e)
        {
            this.numeroEnderecoClienteAvalista = cxNenderecoAvalista.Text;
        }

        private void cxCepAvalista_TextChanged(object sender, EventArgs e)
        {
            this.cepClienteAvalista = cxCepAvalista.Text;
        }

        private void cxBairroAvalista_TextChanged(object sender, EventArgs e)
        {
            this.bairroClienteAvalista = cxBairroAvalista.Text;
        }

        private void cxUfAvalista_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ufClienteAvalista = cxUfAvalista.Text;
        }

        private void cxCidadeAvalista_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cidadeClienteAvalista = cxCidadeAvalista.Text;
        }

        private void cxEmpresaAvalista_TextChanged(object sender, EventArgs e)
        {
            this.empresaClienteAvalista = cxEmpresaAvalista.Text;
        }

        private void cxCargoAvalista_TextChanged(object sender, EventArgs e)
        {
            this.cargolienteAvalista = cxCargoAvalista.Text;
        }

        private void cxRendaAvalista_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.rendaClienteAvalista = cxRendaAvalista.Text;
        }

        private void cxAdmissaoAvalista_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.admissaoClienteAvalista = cxAdmissaoAvalista.Text;
        }
    }
}
