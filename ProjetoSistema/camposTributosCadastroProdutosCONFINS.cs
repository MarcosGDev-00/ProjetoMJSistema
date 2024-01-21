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
    public partial class camposTributosCadastroProdutosCONFINS : Form
    {
        public string confinsSaida { get { return cxConfinsSaída.Text; } }
        public string confinsEntrada { get { return cxConfinsEntrada.Text; } }
        public string aliquotaConfinsSaida { get { return cxAlíquotaConfinsSaida.Text; } }
        public string aliquotaConfinsEntrada { get { return cxAlíquotaConfinsEntrada.Text; } }

        public camposTributosCadastroProdutosCONFINS()
        {
            InitializeComponent();
        }

        private void camposTributosCadastroProdutosCONFINS_Load(object sender, EventArgs e)
        {

        }
    }
}
