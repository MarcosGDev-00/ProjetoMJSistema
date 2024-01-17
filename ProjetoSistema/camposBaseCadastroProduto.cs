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
            ConfigurarControles();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void ConfigurarControles()
        {
            comboBoxTipoProduto = comboBoxTipoProd;
            contextMenuStrip1 = new ContextMenuStrip();
            cadastrarNovoTipoToolStripMenuItem = new ToolStripMenuItem("Cadastrar Novo Tipo");
            cadastrarNovoTipoToolStripMenuItem.Click += CadastrarNovoTipoToolStripMenuItem_Click;
            contextMenuStrip1.Items.Add(cadastrarNovoTipoToolStripMenuItem);

            comboBoxTipoProduto.ContextMenuStrip = contextMenuStrip1;
            comboBoxTipoProduto.MouseDown += comboBoxTipoProd_MouseDown;

        }

        private void camposBaseCadastroProduto_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxTipoProd_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(comboBoxTipoProduto, e.Location);
            }
        }

        private void CadastrarNovoTipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarTipoProduto cadastrarTipoProduto = new CadastrarTipoProduto();
            cadastrarTipoProduto.ShowDialog();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
