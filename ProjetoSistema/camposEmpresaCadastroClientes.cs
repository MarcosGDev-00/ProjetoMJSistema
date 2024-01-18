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
        public camposEmpresaCadastroClientes()
        {
            InitializeComponent();
            ConfigurarControles();
        }

        private void camposEmpresaCadastroClientes_Load(object sender, EventArgs e)
        {
            cxRenda.Mask = "00,00";
            cxRenda.PromptChar = '0';

            cxTelefoneEmpresa.Mask = "(00)00000-0000";
            cxTelefoneEmpresa.PromptChar = ' ';
        }

        private void ConfigurarControles()
        {
            cxAdmissao.Mask = "00/00/0000";
            cxAdmissao.ValidatingType = typeof(DateTime);
            cxAdmissao.PromptChar = ' ';

            dtAdmissao.Format = DateTimePickerFormat.Short;
            dtAdmissao.CustomFormat = "   /   /      ";

            cxAdmissao.TypeValidationCompleted += cxAdmissao_TypeValidationCompleted_1;
            dtAdmissao.ValueChanged += dtAdmissao_ValueChanged;
            cxAdmissao.TextChanged += cxAdmissao_TextChanged_1;
        }

        private void cxAdmissao_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida. Digite uma data válida.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cxAdmissao.Text = "";
            }
            else
            {
                dtAdmissao.Value = cxAdmissao.Text == "" ? DateTimePicker.MinimumDateTime : (DateTime)e.ReturnValue;
            }
        }

        private void dtAdmissao_ValueChanged(object sender, EventArgs e)
        {
            cxAdmissao.Text = dtAdmissao.Value.ToString("dd/MM/yyyy");
        }

        private void cxAdmissao_TextChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(cxAdmissao.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime result))
            {
                dtAdmissao.Value = result;
            }
        }

        private void cxAdmissao_TypeValidationCompleted_1(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida. Digite uma data válida.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cxAdmissao.Text = "";
            }
            else
            {
                dtAdmissao.Value = cxAdmissao.Text == "" ? DateTimePicker.MinimumDateTime : (DateTime)e.ReturnValue;
            }
        }

        private void cxAdmissao_TextChanged_1(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(cxAdmissao.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime result))
            {
                dtAdmissao.Value = result;
            }
        }
    }
}
