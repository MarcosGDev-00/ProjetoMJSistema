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
    public partial class CadastrarClientes : Form
    {
        private camposBaseCadastroClientes formBase = null;

        private GerenciadorFormulario gerenciadorFormulario = new GerenciadorFormulario();
        public CadastrarClientes()
        {
            InitializeComponent();

            formBase = new camposBaseCadastroClientes();
        }

        private void CadastrarClientes_Load(object sender, EventArgs e)
        {

        }

        public class GerenciadorFormulario
        {
            private Form formAtivo = null;

            public void ExibirFormFilhoNoPanel(Form exibirForm, Panel panel)
            {
                if (formAtivo != null)
                {
                    formAtivo = null;
                }

                formAtivo = exibirForm;

                exibirForm.TopLevel = false;
                exibirForm.FormBorderStyle = FormBorderStyle.None;
                exibirForm.Dock = DockStyle.Fill;
                panel.Controls.Add(exibirForm);
                panel.Tag = exibirForm;
                exibirForm.BringToFront();
                exibirForm.Show();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formBase, panelCamposClientes
                );
        }
    }
}
