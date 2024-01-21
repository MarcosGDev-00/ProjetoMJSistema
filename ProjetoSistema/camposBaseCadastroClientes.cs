using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSistema
{
    public partial class camposBaseCadastroClientes : Form
    {
        public string tipoDocCliente = "";
        public string doc = "";
        public string insEstadualCliente = "";
        public string indIeCliente = "";
        public string insunicipalCliente = "";
        public string nomeCliente = "";
        public string rSocialCliente = "";
        public string rgCliente = "";
        public string dataEmissaoRgCliente = "";
        public string orgEmissorRgCliente = "";
        public string enderecoCliente = "";
        public string nEndCliente = "";
        public string bairroCliente = "";
        public string cepCliente = "";
        public string referenciaCliente = "";
        public string apelidoCliente = "";
        public string emailCliente = "";
        public string paisCliente = "";
        public string estadoCliente = "";
        public string cidadeCliente = "";
        public string descontoCredCliente = "";
        public string telefoneCliente = "";
        public string telefone2Cliente = "";
        public string celularCliente = "";
        public string sexoCliente = "";
        public string estadoCivilCliente = "";

        public camposBaseCadastroClientes()
        {
            InitializeComponent();
            ConfigurarControles();
        }

        private void camposBaseCadastroClientes_Load(object sender, EventArgs e)
        {
            cxTelefonebase.Mask = "(00)00000-0000";
            cxTelefonebase.PromptChar = ' ';

            cxTelefone2Base.Mask = "(00)00000-0000";
            cxTelefone2Base.PromptChar = ' ';

            cxCelularBase.Mask = "(00)00000-0000";
            cxCelularBase.PromptChar = ' ';
        }

        private void ConfigurarControles()
        {
            cxDataEmissaoBase.Mask = "00/00/0000";
            cxDataEmissaoBase.ValidatingType = typeof(DateTime);
            cxDataEmissaoBase.PromptChar = ' ';

            dtDataEmissaoBase.Format = DateTimePickerFormat.Short;
            dtDataEmissaoBase.CustomFormat = "   /   /      ";

            cxDataEmissaoBase.TypeValidationCompleted += maskedTextBox2_TypeValidationCompleted;
            dtDataEmissaoBase.ValueChanged += dateTimePicker1_ValueChanged;
            cxDataEmissaoBase.TextChanged += maskedTextBox2_TextChanged;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida. Digite uma data válida.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cxDataEmissaoBase.Text = "";
            }
            else
            {
                dtDataEmissaoBase.Value = cxDataEmissaoBase.Text == "" ? DateTimePicker.MinimumDateTime : (DateTime)e.ReturnValue;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cxDataEmissaoBase.Text = dtDataEmissaoBase.Value.ToString("dd/MM/yyyy");
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(cxDataEmissaoBase.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime result))
            {
                dtDataEmissaoBase.Value = result;
            }
            this.dataEmissaoRgCliente = cxDataEmissaoBase.Text;
        }

        private void textBoxTelefone_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBoxTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.telefoneCliente = cxTelefonebase.Text;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            /*
            Banco banco = new Banco();
            banco.conectar();
            CadastrarCliente cliente = new CadastrarCliente();
            cliente.TipoDocumento = cxTipoDocBase.Text;
            cliente.InsEstadual = cxInsEstadualBase.Text;
            cliente.IndIE = cxIndIeBase.Text;
            cliente.InsMunicipal = cxInsMunicipalBase.Text;
            cliente.Nome =  cxNomeClienteBase.Text;
            cliente.RazaoSocial = cxRsocialBase.Text;
            cliente.RG = Convert.ToInt32(cxRgBase.Text);
            cliente.DataEmissao = Convert.ToDateTime(cxDataEmissaoBase.Text);
            cliente.Orgao = cxOrgaoBase.Text;
            cliente.Endereco = cxEndBase.Text;
            cliente.Numero = cxNumeroBase.Text;
            cliente.Bairro = cxBairroBase.Text;
            cliente.CEP = cxCepBase.Text;
            cliente.Referencia = cxRefBase.Text;
            cliente.Apelido = cxApelidoBase.Text;
            cliente.Email = cxEmailBase.Text;
            cliente.Pais = cxPaisBase.Text;
            cliente.Estado = cxBairroBase.Text;
            cliente.Cidade = cxCidadeBase.Text;
            cliente.LimiteCredito = Convert.ToDecimal(cxDescontoBase.Text);
            cliente.Telefone = cxTelefonebase.Text;
            cliente.Telefone2 = cxTelefone2Base.Text;
            cliente.Celular = cxCelularBase.Text;
            cliente.Sexo = cxSexoBase.Text;
            cliente.EstadoCivil = cxEstadoCivilBase.Text;
            banco.cadastrar_cliente(cliente);
            */
        }

        private void cxDocBase_TextChanged(object sender, EventArgs e)
        {
            this.doc = cxDocBase.Text;
        }

        private void cxTipoDocBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tipoDocCliente = cxTipoDocBase.Text;
        }

        private void cxNomeClienteBase_TextChanged(object sender, EventArgs e)
        {
            this.nomeCliente = cxNomeClienteBase.Text;
        }

        private void cxInsEstadualBase_TextChanged(object sender, EventArgs e)
        {
            this.insEstadualCliente = cxInsEstadualBase.Text;
        }

        private void cxIndIeBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.indIeCliente = cxIndIeBase.Text;
        }

        private void cxInsMunicipalBase_TextChanged(object sender, EventArgs e)
        {
            this.insunicipalCliente = cxInsMunicipalBase.Text;
        }

        private void cxRsocialBase_TextChanged(object sender, EventArgs e)
        {
            this.rSocialCliente = cxRsocialBase.Text;
        }

        private void cxRgBase_TextChanged(object sender, EventArgs e)
        {
            this.rgCliente = cxRgBase.Text;
        }

        private void cxOrgaoBase_TextChanged(object sender, EventArgs e)
        {
            this.orgEmissorRgCliente = cxOrgaoBase.Text;
        }

        private void cxEndBase_TextChanged(object sender, EventArgs e)
        {
            this.enderecoCliente = cxEndBase.Text;
        }

        private void cxNumeroBase_TextChanged(object sender, EventArgs e)
        {
            this.nEndCliente = cxNumeroBase.Text;
        }

        private void cxBairroBase_TextChanged(object sender, EventArgs e)
        {
            this.bairroCliente = cxBairroBase.Text;
        }

        private void cxCepBase_TextChanged(object sender, EventArgs e)
        {
            this.cepCliente = cxCepBase.Text;
        }

        private void cxRefBase_TextChanged(object sender, EventArgs e)
        {
            this.referenciaCliente = cxRefBase.Text;
        }

        private void cxApelidoBase_TextChanged(object sender, EventArgs e)
        {
            this.apelidoCliente = cxApelidoBase.Text;
        }

        private void cxEmailBase_TextChanged(object sender, EventArgs e)
        {
            this.emailCliente = cxEmailBase.Text;
        }

        private void cxPaisBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.paisCliente = cxPaisBase.Text;
        }

        private void cxEstadoBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.estadoCliente = cxEstadoBase.Text;
        }

        private void cxCidadeBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cidadeCliente = cxCidadeBase.Text;
        }

        private void cxDescontoBase_TextChanged(object sender, EventArgs e)
        {
            this.descontoCredCliente = cxDescontoBase.Text;
        }

        private void cxTelefone2Base_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.telefone2Cliente = cxTelefone2Base.Text;
        }

        private void cxCelularBase_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            this.celularCliente = cxCelularBase.Text;
        }

        private void cxSexoBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.sexoCliente = cxSexoBase.Text;
        }

        private void cxEstadoCivilBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.estadoCivilCliente = cxEstadoCivilBase.Text;
        }
    }
}
