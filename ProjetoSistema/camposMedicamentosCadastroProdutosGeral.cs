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
    public partial class camposMedicamentosCadastroProdutosGeral : Form
    {


        public camposMedicamentosCadastroProdutosGeral()
        {
            InitializeComponent();
            ConfigurarControles();
        }

        private void ConfigurarControles()
        {
            maskedTextBox2.Mask = "00/00/0000";
            maskedTextBox2.ValidatingType = typeof(DateTime);

            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.CustomFormat = "   /   /      ";

            maskedTextBox2.TypeValidationCompleted += maskedTextBox2_TypeValidationCompleted;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            maskedTextBox2.TextChanged += maskedTextBox2_TextChanged;
        }


        private void camposMedicamentosCadastroProdutosGeral_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida. Digite uma data válida.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskedTextBox2.Text = "";
            }
            else
            {
                dateTimePicker1.Value = maskedTextBox2.Text == "" ? DateTimePicker.MinimumDateTime : (DateTime)e.ReturnValue;
            }
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            maskedTextBox2.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(maskedTextBox2.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime result))
            {
                dateTimePicker1.Value = result;
            }
        }
    }
}
