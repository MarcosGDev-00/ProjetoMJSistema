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

namespace ProjetoSistema
{
    public partial class camposTributosCadastroProdutosGeral : Form
    {
        public string grupoTributarioProduto { get { return cxGrupoTributario.Text; } }
        public string cstProduto { get { return cxCST.Text; } }
        public string cfopProduto { get { return cxCFOP.Text; } }
        public string origemProduto { get { return cxOrigem.Text; } }
        public string NCMProduto { get { return cxNCM.Text; } }
        public string CESTProduto { get { return cxCEST.Text; } }
        public string generoProduto { get { return cxGenero.Text; } }

        public camposTributosCadastroProdutosGeral()
        {
            InitializeComponent();
        }

        private void camposTributosCadastroProdutosGeral_Load(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            banco.conectar();
            List<string> cst = banco.MostrarCst();
            List<string> origem = banco.MostrarOrigem();
            List<string> ncm = banco.MostrarNcm();
            List<string> cfop = banco.MostrarCfop();
            List<string> genero = banco.MostrarGeneroProduto();

            cxCST.Items.Clear();
            cxOrigem.Items.Clear();
            cxNCM.Items.Clear();
            cxCFOP.Items.Clear();
            cxGenero.Items.Clear();

            cxCST.DataSource = cst;
            cxCST.Text = "Selecione";

            cxOrigem.DataSource = origem;
            cxOrigem.Text = "Selecione";

            cxNCM.DataSource = ncm;
            cxNCM.Text = "Selecione";

            cxCFOP.DataSource = cfop;
            cxCFOP.Text = "Selecione";

            cxGenero.DataSource = genero;
            cxGenero.Text = "Selecione";
        }
    }
}
