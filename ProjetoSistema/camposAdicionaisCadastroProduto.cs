using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace ProjetoSistema
{
    public partial class camposAdicionaisCadastroProduto : Form
    {
        public string produtoAtivo { get { return cxAtivoProdutoAdicional.Text; } }
        public string produtoReceberDesconto { get { return cxReceberDescontoAdicional.Text; } }
        public string produtoVendidoFracionado { get { return cxVendidoFracionadoAdicional.Text; } }
        public string produtoControlarLote { get { return cxControlarLoteAdicional.Text; } }
        public string produtoBalanca { get { return cxBalançaAdicional.Text; } }
        public string produtoBalancaCheck { get { return cxBalançaCheckAdicional.Text; } }
        public string produtoAtualizarPreco { get { return cxAtualizarPrecoAdicional.Text; } }
        public string produtoAtualizarNCM { get { return cxAtualizarNCMAdiconal.Text; } }

        public camposAdicionaisCadastroProduto()
        {
            InitializeComponent();
        }

        private void camposAdicionaisCadastroProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
