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
    }
}
