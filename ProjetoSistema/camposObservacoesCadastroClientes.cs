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
    public partial class camposObservacoesCadastroClientes : Form
    {
        public string observacoesCliente = "";

        public camposObservacoesCadastroClientes()
        {
            InitializeComponent();
        }

        private void camposObservacoesCadastroClientes_Load(object sender, EventArgs e)
        {

        }

        private void cxObsObservacoes_TextChanged(object sender, EventArgs e)
        {
            this.observacoesCliente = cxObsObservacoes.Text;
        }
    }
}
