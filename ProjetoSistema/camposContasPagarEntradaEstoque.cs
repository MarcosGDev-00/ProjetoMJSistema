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
    public partial class camposContasPagarEntradaEstoque : Form
    {
        public camposContasPagarEntradaEstoque()
        {
            InitializeComponent();
            ConfigurarControles();
        }

        private void camposContasPagarEntradaEstoque_Load(object sender, EventArgs e)
        {
            cxValorParcela.Mask = "00,00";
            cxValorParcela.PromptChar = '0';
        }

        private void ConfigurarControles()
        {
            cxVencimento.Mask = "00/00/0000";
            cxVencimento.ValidatingType = typeof(DateTime);
            cxVencimento.PromptChar = ' ';

            dtVencimento.Format = DateTimePickerFormat.Short;
            dtVencimento.CustomFormat = "   /   /      ";

            cxVencimento.TypeValidationCompleted += cxVencimento_TypeValidationCompleted;
            dtVencimento.ValueChanged += dtVencimento_ValueChanged;
            cxVencimento.TextChanged += cxVencimento_TextChanged;
        }

        private void cxVencimento_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida. Digite uma data válida.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cxVencimento.Text = "";
            }
            else
            {
                dtVencimento.Value = cxVencimento.Text == "" ? DateTimePicker.MinimumDateTime : (DateTime)e.ReturnValue;
            }
        }

        private void dtVencimento_ValueChanged(object sender, EventArgs e)
        {
            cxVencimento.Text = dtVencimento.Value.ToString("dd/MM/yyyy");
        }

        private void cxVencimento_TextChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(cxVencimento.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime result))
            {
                dtVencimento.Value = result;
            }
        }
    }
}
