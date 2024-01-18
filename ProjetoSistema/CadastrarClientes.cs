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
        private camposAdicionaisCadastrarClientes formAdicional = null;
        private camposFiliacaoCadastroClientes formFiliacao = null;
        private camposEndEntregaCadastrarCliente formEndEntrega = null;
        private camposEmpresaCadastroClientes formEmpresa = null;
        private camposConjugueCadastroClientes formConjugue = null;
        private camposAvalistaCadastroClientes formAvalista = null;
        private camposFidelidadeCadastroCliente formFidelidade = null;
        private camposReferenciaCadastroCliente formRef = null;
        private camposObservacoesCadastroClientes formObs = null;

        private GerenciadorFormulario gerenciadorFormulario = new GerenciadorFormulario();
        public CadastrarClientes()
        {
            InitializeComponent();

            formBase = new camposBaseCadastroClientes();
            formAdicional = new camposAdicionaisCadastrarClientes();
            formFiliacao = new camposFiliacaoCadastroClientes();
            formEndEntrega = new camposEndEntregaCadastrarCliente();
            formEmpresa = new camposEmpresaCadastroClientes();
            formConjugue = new camposConjugueCadastroClientes();
            formAvalista = new camposAvalistaCadastroClientes();
            formFidelidade = new camposFidelidadeCadastroCliente();
            formRef = new camposReferenciaCadastroCliente();
            formObs = new camposObservacoesCadastroClientes();
        }

        private void CadastrarClientes_Load(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formBase, panelCamposClientes);
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
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formBase, panelCamposClientes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formAdicional, panelCamposClientes);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formFiliacao, panelCamposClientes);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formEndEntrega, panelCamposClientes);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formEmpresa, panelCamposClientes);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formConjugue, panelCamposClientes);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formAvalista, panelCamposClientes);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formFidelidade, panelCamposClientes);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formRef, panelCamposClientes);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formObs, panelCamposClientes);
        }
    }
}
