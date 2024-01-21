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
    public partial class camposDadosDaNotaEntradaEstoque : Form
    {
        public camposDadosDaNotaEntradaEstoque()
        {
            InitializeComponent();
            ConfigurarControles();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void camposDadosDaNotaEntradaEstoque_Load(object sender, EventArgs e)
        {
            
        }

        private void ConfigurarControles()
        {
            cxDtaEmissaoDadosNota.Mask = "00/00/0000";
            cxDtaEmissaoDadosNota.ValidatingType = typeof(DateTime);
            cxDtaEmissaoDadosNota.PromptChar = ' ';

            dtDtaEmissaoDadosNota.Format = DateTimePickerFormat.Short;
            dtDtaEmissaoDadosNota.CustomFormat = "   /   /      ";

            cxDtaEmissaoDadosNota.TypeValidationCompleted += cxDtaEmissaoDadosNota_TypeValidationCompleted;
            dtDtaEmissaoDadosNota.ValueChanged += dtDtaEmissaoDadosNota_ValueChanged;
            cxDtaEmissaoDadosNota.TextChanged += cxDtaEmissaoDadosNota_TextChanged;

            cxDtaEntradaDadosNota.Mask = "00/00/0000";
            cxDtaEntradaDadosNota.ValidatingType = typeof(DateTime);
            cxDtaEntradaDadosNota.PromptChar = ' ';

            dtDtaEntradaDadosNota.Format = DateTimePickerFormat.Short;
            dtDtaEntradaDadosNota.CustomFormat = "   /   /      ";

            cxDtaEntradaDadosNota.TypeValidationCompleted += cxDtaEntradaDadosNota_TypeValidationCompleted;
            dtDtaEntradaDadosNota.ValueChanged += dtDtaEntradaDadosNota_ValueChanged;
            cxDtaEntradaDadosNota.TextChanged += cxDtaEntradaDadosNota_TextChanged;
        }

        private void cxDtaEmissaoDadosNota_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida. Digite uma data válida.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cxDtaEmissaoDadosNota.Text = "";
            }
            else
            {
                dtDtaEmissaoDadosNota.Value = cxDtaEmissaoDadosNota.Text == "" ? DateTimePicker.MinimumDateTime : (DateTime)e.ReturnValue;
            }
        }

        private void dtDtaEmissaoDadosNota_ValueChanged(object sender, EventArgs e)
        {
            cxDtaEmissaoDadosNota.Text = dtDtaEmissaoDadosNota.Value.ToString("dd/MM/yyyy");
        }

        private void cxDtaEmissaoDadosNota_TextChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(cxDtaEmissaoDadosNota.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime result))
            {
                dtDtaEmissaoDadosNota.Value = result;
            }
        }

        private void cxDtaEntradaDadosNota_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida. Digite uma data válida.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cxDtaEntradaDadosNota.Text = "";
            }
            else
            {
                dtDtaEntradaDadosNota.Value = cxDtaEntradaDadosNota.Text == "" ? DateTimePicker.MinimumDateTime : (DateTime)e.ReturnValue;
            }
        }

        private void dtDtaEntradaDadosNota_ValueChanged(object sender, EventArgs e)
        {
            cxDtaEntradaDadosNota.Text = dtDtaEntradaDadosNota.Value.ToString("dd/MM/yyyy");
        }

        private void cxDtaEntradaDadosNota_TextChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(cxDtaEntradaDadosNota.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime result))
            {
                dtDtaEntradaDadosNota.Value = result;
            }
        }
    }
}
