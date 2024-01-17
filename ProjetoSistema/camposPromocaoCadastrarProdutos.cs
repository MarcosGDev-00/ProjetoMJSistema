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
    public partial class camposPromocaoCadastrarProdutos : Form
    {
        public camposPromocaoCadastrarProdutos()
        {
            InitializeComponent();
            ConfigurarControles();
        }

        private void camposPromocaoCadastrarProdutos_Load(object sender, EventArgs e)
        {
            cxLocal.Mask = "00,00";
            cxLocal.PromptChar = '0';
        }

        private void ConfigurarControles()
        {
            cxDataInicial.Mask = "00/00/0000";
            cxDataInicial.ValidatingType = typeof(DateTime);
            cxDataInicial.PromptChar = ' ';

            dtDataInicial.Format = DateTimePickerFormat.Short;
            dtDataInicial.CustomFormat = "   /   /      ";

            cxDataInicial.TypeValidationCompleted += cxDataInicial_TypeValidationCompleted;
            dtDataInicial.ValueChanged += dtDataInicial_ValueChanged;
            cxDataInicial.TextChanged += cxDataInicial_TextChanged;

            cxDataFinal.Mask = "00/00/0000";
            cxDataFinal.ValidatingType = typeof(DateTime);
            cxDataFinal.PromptChar = ' ';

            dtDataFinal.Format = DateTimePickerFormat.Short;
            dtDataFinal.CustomFormat = "   /   /      ";

            cxDataFinal.TypeValidationCompleted += cxDataFinal_TypeValidationCompleted;
            dtDataFinal.ValueChanged += dtDataFinal_ValueChanged;
            cxDataFinal.TextChanged += cxDataFinal_TextChanged;
        }

        private void cxDataInicial_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida. Digite uma data válida.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cxDataInicial.Text = "";
            }
            else
            {
                dtDataInicial.Value = cxDataInicial.Text == "" ? DateTimePicker.MinimumDateTime : (DateTime)e.ReturnValue;
            }
        }

        private void dtDataInicial_ValueChanged(object sender, EventArgs e)
        {
            cxDataInicial.Text = dtDataInicial.Value.ToString("dd/MM/yyyy");
        }

        private void cxDataInicial_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void cxDataInicial_TextChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(cxDataInicial.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime result))
            {
                dtDataInicial.Value = result;
            }
        }

        private void cxDataFinal_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida. Digite uma data válida.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cxDataFinal.Text = "";
            }
            else
            {
                dtDataFinal.Value = cxDataFinal.Text == "" ? DateTimePicker.MinimumDateTime : (DateTime)e.ReturnValue;
            }
        }

        private void dtDataFinal_ValueChanged(object sender, EventArgs e)
        {
            cxDataFinal.Text = dtDataInicial.Value.ToString("dd/MM/yyyy");
        }

        private void cxDataFinal_TextChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(cxDataInicial.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime result))
            {
                dtDataInicial.Value = result;
            }
        }

        private void cxLocal_Click(object sender, EventArgs e)
        {
            cxLocal.SelectionStart = 0;
        }

        private void cxLocal_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
