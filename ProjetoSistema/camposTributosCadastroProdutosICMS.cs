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
    public partial class camposTributosCadastroProdutosICMS : Form
    {
        public string icmsSaida { get { return cxIcmsSaida.Text;  } }
        public string reducaoBaseSaida { get { return cxReducaoBaseCalcSaida.Text; } }
        public string obsIcms { get { return cxObsICMS.Text; } }
        public string icmsEntrada { get { return cxIcmsEntrada.Text; } }
        public string reducaoBaseEntrada { get { return cxReducaoBaseCalcEntrada.Text; } }

        public camposTributosCadastroProdutosICMS()
        {
            InitializeComponent();
        }

        private void camposTributosCadastroProdutosICMS_Load(object sender, EventArgs e)
        {

        }
    }
}
