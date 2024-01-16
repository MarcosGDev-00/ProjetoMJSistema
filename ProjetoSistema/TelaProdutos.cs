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
    public partial class TelaProdutos : Form
    {
        public TelaProdutos()
        {
            InitializeComponent();

            cxPesquisarProduto.Enter += cxPesquisarProduto_Enter;
            cxPesquisarProduto.Leave += cxPesquisarProduto_Leave;
            cxPesquisarProduto.Click += cxPesquisarProduto_Click;
        }


        private void cxUsuario_Click(object sender, EventArgs e)
        {

        }

        private void cxPesquisarProduto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cxPesquisarProduto_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text == "Pesquisar...")
            {
                textBox.Text = "";
            }
        }

        private void cxPesquisarProduto_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void cxPesquisarProduto_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cxPesquisarProduto_MouseLeave_1(object sender, EventArgs e)
        {
            

        }

        private void CadastroProdutos_Load(object sender, EventArgs e)
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

        private void dataGridViewBuscarProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cxPesquisarProduto_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void cxPesquisarProduto_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text == "Pesquisar...")
            {
                textBox.Text = "";
            }
        }

        private void cxPesquisarProduto_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Pesquisar...";
            }
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            

        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNovoProduto_Click_1(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new CadastrarProdutos());
        }
    }
}
