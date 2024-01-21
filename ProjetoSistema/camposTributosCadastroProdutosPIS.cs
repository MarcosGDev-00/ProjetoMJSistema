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
    public partial class camposTributosCadastroProdutosPIS : Form
    {
        public string pisSaida { get { return cxPISSaida.Text; } }
        public string pisEntrada { get { return cxPISEntrada.Text; } }
        public string aliquotaPisSaida { get { return cxAliquotaPisSaida.Text; } }
        public string aliquotaPisEntrada { get { return cxAliquotaPisEntrada.Text; } }

        public camposTributosCadastroProdutosPIS()
        {
            InitializeComponent();
        }

        private void camposTributosCadastroProdutosPIS_Load(object sender, EventArgs e)
        {

        }
    }
}
