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
        public camposConjugueCadastroClientes()
        {
            InitializeComponent();
            ConfigurarControles();
        }

        private void camposConjugueCadastroClientes_Load(object sender, EventArgs e)
        {
            cxRendaConjugue.Mask = "00,00";
            cxRendaConjugue.PromptChar = '0';

            cxFoneConjugue.Mask = "(00)00000-0000";
            cxFoneConjugue.PromptChar = ' ';
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

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

            cxDataNascimento.Mask = "00/00/0000";
            cxDataNascimento.ValidatingType = typeof(DateTime);
            cxDataNascimento.PromptChar = ' ';

            dtDataNascimento.Format = DateTimePickerFormat.Short;
            dtDataNascimento.CustomFormat = "   /   /      ";

            cxDataNascimento.TypeValidationCompleted += cxDataNascimento_TypeValidationCompleted;
            dtDataNascimento.ValueChanged += dtDataNascimento_ValueChanged;
            cxDataNascimento.TextChanged += cxDataNascimento_TextChanged;
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
            cxDataNascimento.Text = dtDataNascimento.Value.ToString("dd/MM/yyyy");
        }

        private void cxDataNascimento_TextChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(cxDataNascimento.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime result))
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
                cxDataNascimento.Text = "";
            }
            else
            {
                dtDataNascimento.Value = cxDataNascimento.Text == "" ? DateTimePicker.MinimumDateTime : (DateTime)e.ReturnValue;
            }
        }
    }
}
