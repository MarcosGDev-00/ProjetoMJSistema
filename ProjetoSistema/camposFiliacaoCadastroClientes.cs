using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSistema
{
    public partial class camposFiliacaoCadastroClientes : Form
    {
        public camposFiliacaoCadastroClientes()
        {
            InitializeComponent();
        }

        private void maskedTextBoxTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void camposFiliacaoCadastroClientes_Load(object sender, EventArgs e)
        {
            cxTelefonePai.Mask = "(00)00000-0000";
            cxTelefonePai.PromptChar = ' ';

            cxTelefoneMae.Mask = "(00)00000-0000";
            cxTelefoneMae.PromptChar = ' ';
        }
    }
}
