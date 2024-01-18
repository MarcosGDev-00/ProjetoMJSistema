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
            cxDataNascimento.Mask = "00/00/0000";
            cxDataNascimento.ValidatingType = typeof(DateTime);
            cxDataNascimento.PromptChar = ' ';

            dtDataNascimento.Format = DateTimePickerFormat.Short;
            dtDataNascimento.CustomFormat = "   /   /      ";

            cxDataNascimento.TypeValidationCompleted += cxDataNascimento_TypeValidationCompleted;
            dtDataNascimento.ValueChanged += dtDataNascimento_ValueChanged;
            cxDataNascimento.TextChanged += cxDataNascimento_TextChanged;
        }

        private void cxDataNascimento_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida. Digite uma data válida.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cxDataNascimento.Text = "";
            }
            else
            {
                dtDataNascimento.Value = cxDataNascimento.Text == "" ? DateTimePicker.MinimumDateTime : (DateTime)e.ReturnValue;
            }
        }

        private void dtDataNascimento_Validating(object sender, CancelEventArgs e)
        {

        }

        private void dtDataNascimento_ValueChanged(object sender, EventArgs e)
        {
            cxDataNascimento.Text = dtDataNascimento.Value.ToString("dd/MM/yyyy");
        }

        private void cxDataNascimento_TextChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(cxDataNascimento.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime result))
            {
                dtDataNascimento.Value = result;
            }
        }
    }
}
