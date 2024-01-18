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
    public partial class camposBaseCadastroProduto : Form
    {

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem cadastrarNovoTipoToolStripMenuItem;
        private ComboBox comboBoxTipoProduto;

        public camposBaseCadastroProduto()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        

        private void camposBaseCadastroProduto_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxTipoProd_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void CadastrarNovoTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            CadastrarTipoProduto cadastrarTipoProduto = new CadastrarTipoProduto();
            cadastrarTipoProduto.ShowDialog();
        }
    }
}
