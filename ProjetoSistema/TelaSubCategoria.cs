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
    public partial class TelaSubCategoria : Form
    {
        public TelaSubCategoria()
        {
            InitializeComponent();
        }

        public Form formAtivo = null;
        public void exibirFormFilhoNoPanel(Form exibirForm)
        {
            if (formAtivo != null)
                formAtivo.Close();
            formAtivo = exibirForm;
            exibirForm.TopLevel = false;
            exibirForm.FormBorderStyle = FormBorderStyle.None;
            exibirForm.Dock = DockStyle.Fill;
            panelSubCategoria.Controls.Add(exibirForm);
            panelSubCategoria.Tag = exibirForm;
            exibirForm.BringToFront();
            exibirForm.Show();
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new CadastrarSubcategoria());
        }
    }
}
