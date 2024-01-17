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
    public partial class TelaFabricante : Form
    {
        public TelaFabricante()
        {
            InitializeComponent();
        }

        private void TelaFabricante_Load(object sender, EventArgs e)
        {

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
            panelCadastro.Controls.Add(exibirForm);
            panelCadastro.Tag = exibirForm;
            exibirForm.BringToFront();
            exibirForm.Show();
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new CadastrarFabricantes());
        }
    }
}
