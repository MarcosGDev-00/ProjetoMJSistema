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
    public partial class camposConjugueCadastroClientes : Form
    {
        public string nomeClienteConjugue = "";
        public string cpfClienteConjugue = "";
        public string rgClienteConjugue = "";
        public string dataNascClienteConjugue = "";
        public string telefoneConjugue = "";
        public string enderecoClienteConjugue = "";
        public string NumeroEndClienteConjugue = "";
        public string cepClienteConjugue = "";
        public string bairroClienteConjugue = "";
        public string ufClienteConjugue = "";
        public string cidadeClienteConjugue = "";
        public string empresaClienteConjugue = "";
        public string cargoClienteConjugue = "";
        public string rendaClienteConjugue = "";
        public string admissaoClienteConjugue = "";

        public camposConjugueCadastroClientes()
        {
            InitializeComponent();
            ConfigurarControles();
        }

        private void camposConjugueCadastroClientes_Load(object sender, EventArgs e)
        {
            cxRendaConjugue.Mask = "00,00";
            cxRendaConjugue.PromptChar = '0';

            cxFoneConjugueConjugue.Mask = "(00)00000-0000";
            cxFoneConjugueConjugue.PromptChar = ' ';
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            this.enderecoClienteConjugue = cxEnderecoConjugue.Text;
        }

        private void ConfigurarControles()
        {
            cxAdmissaoConjugue.Mask = "00/00/0000";
            cxAdmissaoConjugue.ValidatingType = typeof(DateTime);
            cxAdmissaoConjugue.PromptChar = ' ';

            dtAdmissaoConjugue.Format = DateTimePickerFormat.Short;
            dtAdmissaoConjugue.CustomFormat = "   /   /      ";

            cxAdmissaoConjugue.TypeValidationCompleted += cxAdmissaoConjugue_TypeValidationCompleted;
            dtAdmissaoConjugue.ValueChanged += dtAdmissaoConjugue_ValueChanged;
            cxAdmissaoConjugue.TextChanged += cxAdmissaoConjugue_TextChanged;

            cxDataNascimentoConjugue.Mask = "00/00/0000";
            cxDataNascimentoConjugue.ValidatingType = typeof(DateTime);
            cxDataNascimentoConjugue.PromptChar = ' ';

            dtDataNascimento.Format = DateTimePickerFormat.Short;
            dtDataNascimento.CustomFormat = "   /   /      ";

            cxDataNascimentoConjugue.TypeValidationCompleted += cxDataNascimento_TypeValidationCompleted;
            dtDataNascimento.ValueChanged += dtDataNascimento_ValueChanged;
            cxDataNascimentoConjugue.TextChanged += cxDataNascimento_TextChanged;
        }

        private void cxAdmissaoConjugue_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida. Digite uma data válida.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cxAdmissaoConjugue.Text = "";
            }
            else
            {
                dtAdmissaoConjugue.Value = cxAdmissaoConjugue.Text == "" ? DateTimePicker.MinimumDateTime : (DateTime)e.ReturnValue;
            }
        }

        private void dtDataNascimento_ValueChanged(object sender, EventArgs e)
        {
            cxDataNascimentoConjugue.Text = dtDataNascimento.Value.ToString("dd/MM/yyyy");
        }

        private void cxDataNascimento_TextChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(cxDataNascimentoConjugue.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime result))
            {
                dtDataNascimento.Value = result;
            }
        }

        private void dtAdmissaoConjugue_ValueChanged(object sender, EventArgs e)
        {
            cxAdmissaoConjugue.Text = dtAdmissaoConjugue.Value.ToString("dd/MM/yyyy");
        }

        private void cxAdmissaoConjugue_TextChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(cxAdmissaoConjugue.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime result))
            {
                dtAdmissaoConjugue.Value = result;
            }
        }

        private void cxDataNascimento_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida. Digite uma data válida.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cxDataNascimentoConjugue.Text = "";
            }
            else
            {
                dtDataNascimento.Value = cxDataNascimentoConjugue.Text == "" ? DateTimePicker.MinimumDateTime : (DateTime)e.ReturnValue;
            }
        }

        private void cxNomeConjugue_TextChanged(object sender, EventArgs e)
        {
            this.nomeClienteConjugue = cxNomeConjugue.Text;
        }

        private void cxCpfConjugue_TextChanged(object sender, EventArgs e)
        {
            this.cpfClienteConjugue = cxCpfConjugue.Text;
        }

        private void cxRgConjugue_TextChanged(object sender, EventArgs e)
        {
            this.rgClienteConjugue = cxRgConjugue.Text;
        }

        private void cxDataNascimentoConjugue_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.dataNascClienteConjugue = cxDataNascimentoConjugue.Text;
        }

        private void cxFoneConjugueConjugue_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.telefoneConjugue = cxFoneConjugueConjugue.Text;
        }

        private void cxNenderecoConjugue_TextChanged(object sender, EventArgs e)
        {
            this.NumeroEndClienteConjugue = cxNenderecoConjugue.Text;
        }

        private void cxCepConjugue_TextChanged(object sender, EventArgs e)
        {
            this.cepClienteConjugue = cxCepConjugue.Text;
        }

        private void cxBairroConjugue_TextChanged(object sender, EventArgs e)
        {
            this.bairroClienteConjugue = cxBairroConjugue.Text;
        }

        private void cxUfConjugue_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ufClienteConjugue = cxUfConjugue.Text;
        }

        private void cxCidadeConjugue_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cidadeClienteConjugue = cxCidadeConjugue.Text;
        }

        private void cxEmpresaConjugue_TextChanged(object sender, EventArgs e)
        {
            this.empresaClienteConjugue = cxEmpresaConjugue.Text;
        }

        private void cxCargoConjugue_TextChanged(object sender, EventArgs e)
        {
            this.cargoClienteConjugue = cxCargoConjugue.Text;
        }

        private void cxRendaConjugue_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.rendaClienteConjugue = cxRendaConjugue.Text;
        }

        private void cxAdmissaoConjugue_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.admissaoClienteConjugue = cxAdmissaoConjugue.Text;
        }
    }
}
