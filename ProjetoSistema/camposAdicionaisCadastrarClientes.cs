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
    public partial class camposAdicionaisCadastrarClientes : Form
    {
        public string nacionalidadeCliente = "";
        public string ufCliente = "";
        public string statuCliente = "";
        public string naturalidadeCliente = "";
        public string dataNascCliente = ""; 

        public camposAdicionaisCadastrarClientes()
        {
            InitializeComponent();
            ConfigurarControles();
        }

        private void camposAdicionaisCadastrarClientes_Load(object sender, EventArgs e)
        {

        }

        private void ConfigurarControles()
        {
            cxDataNascimentoClienteAdicional.Mask = "00/00/0000";
            cxDataNascimentoClienteAdicional.ValidatingType = typeof(DateTime);
            cxDataNascimentoClienteAdicional.PromptChar = ' ';

            dtDataNascimentoClienteAdicional.Format = DateTimePickerFormat.Short;
            dtDataNascimentoClienteAdicional.CustomFormat = "   /   /      ";

            cxDataNascimentoClienteAdicional.TypeValidationCompleted += cxDataNascimento_TypeValidationCompleted;
            dtDataNascimentoClienteAdicional.ValueChanged += dtDataNascimento_ValueChanged;
            cxDataNascimentoClienteAdicional.TextChanged += cxDataNascimento_TextChanged;
        }

        private void cxDataNascimento_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida. Digite uma data válida.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cxDataNascimentoClienteAdicional.Text = "";
            }
            else
            {
                dtDataNascimentoClienteAdicional.Value = cxDataNascimentoClienteAdicional.Text == "" ? DateTimePicker.MinimumDateTime : (DateTime)e.ReturnValue;
            }
        }

        private void dtDataNascimento_Validating(object sender, CancelEventArgs e)
        {

        }

        private void dtDataNascimento_ValueChanged(object sender, EventArgs e)
        {
            cxDataNascimentoClienteAdicional.Text = dtDataNascimentoClienteAdicional.Value.ToString("dd/MM/yyyy");
        }

        private void cxDataNascimento_TextChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(cxDataNascimentoClienteAdicional.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime result))
            {
                dtDataNascimentoClienteAdicional.Value = result;
            }
        }

        private void cxNacionalidadeClienteAdicional_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.nacionalidadeCliente = cxNacionalidadeClienteAdicional.Text;
        }

        private void cxUfClienteAdicional_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ufCliente = cxUfClienteAdicional.Text;
        }

        private void cxStatusClienteAdicional_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.statuCliente = cxStatusClienteAdicional.Text;
        }

        private void cxNaturalidadeClienteAdicional_TextChanged(object sender, EventArgs e)
        {
            this.naturalidadeCliente = cxNaturalidadeClienteAdicional.Text;
        }

        private void cxDataNascimentoClienteAdicional_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.dataNascCliente = cxDataNascimentoClienteAdicional.Text;
        }
    }
}
