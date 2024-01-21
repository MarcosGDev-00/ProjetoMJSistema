using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjetoSistema.camposBaseCadastroClientes;

namespace ProjetoSistema
{
    public partial class CadastrarClientes : Form
    {
        private camposBaseCadastroClientes formBase = null;
        private camposAdicionaisCadastrarClientes formAdicional = null;
        private camposFiliacaoCadastroClientes formFiliacao = null;
        private camposEndEntregaCadastrarCliente formEndEntrega = null;
        private camposEmpresaCadastroClientes formEmpresa = null;
        private camposConjugueCadastroClientes formConjugue = null;
        private camposAvalistaCadastroClientes formAvalista = null;
        private camposFidelidadeCadastroCliente formFidelidade = null;
        private camposReferenciaCadastroCliente formRef = null;
        private camposObservacoesCadastroClientes formObs = null;

        private GerenciadorFormulario gerenciadorFormulario = new GerenciadorFormulario();

        private camposBaseCadastroClientes formBaseClientes = null;
        private camposAdicionaisCadastrarClientes formAdicionalCliente = null;
        private camposFiliacaoCadastroClientes formFiliacaoCliente = null;

        public CadastrarClientes()
        {
            InitializeComponent();

            formBase = new camposBaseCadastroClientes();
            formAdicional = new camposAdicionaisCadastrarClientes();
            formFiliacao = new camposFiliacaoCadastroClientes();
            formEndEntrega = new camposEndEntregaCadastrarCliente();
            formEmpresa = new camposEmpresaCadastroClientes();
            formConjugue = new camposConjugueCadastroClientes();
            formAvalista = new camposAvalistaCadastroClientes();
            formFidelidade = new camposFidelidadeCadastroCliente();
            formRef = new camposReferenciaCadastroCliente();
            formObs = new camposObservacoesCadastroClientes();

            formBaseClientes = new camposBaseCadastroClientes();
            formAdicionalCliente = new camposAdicionaisCadastrarClientes();
            formFiliacaoCliente = new camposFiliacaoCadastroClientes();
        }

        private void CadastrarClientes_Load(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formBase, panelCamposClientes);
        }

        public class GerenciadorFormulario
        {
            private Form formAtivo = null;

            public void ExibirFormFilhoNoPanel(Form exibirForm, Panel panel)
            {
                if (formAtivo != null)
                {
                    formAtivo = null;
                }

                formAtivo = exibirForm;

                exibirForm.TopLevel = false;
                exibirForm.FormBorderStyle = FormBorderStyle.None;
                exibirForm.Dock = DockStyle.Fill;
                panel.Controls.Add(exibirForm);
                panel.Tag = exibirForm;
                exibirForm.BringToFront();
                exibirForm.Show();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formBase, panelCamposClientes);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formAdicional, panelCamposClientes);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formFiliacao, panelCamposClientes);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formEndEntrega, panelCamposClientes);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formEmpresa, panelCamposClientes);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formConjugue, panelCamposClientes);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formAvalista, panelCamposClientes);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formFidelidade, panelCamposClientes);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formRef, panelCamposClientes);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            gerenciadorFormulario.ExibirFormFilhoNoPanel(formObs, panelCamposClientes);
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            banco.conectar();
            CadastrarCliente cliente = new CadastrarCliente();

            // CAMPOS BASE
            cliente.TipoDocumento = formBase.tipoDocCliente;
            cliente.InsEstadual = formBase.insEstadualCliente;
            cliente.IndIE = formBase.indIeCliente;
            cliente.InsMunicipal = formBase.insunicipalCliente;
            cliente.Nome = formBase.nomeCliente;
            cliente.RazaoSocial = formBase.rSocialCliente;
            //cliente.RG = Convert.ToInt32(formBase.rgCliente);
            cliente.DataEmissao = Convert.ToDateTime(formBase.dataEmissaoRgCliente);
            cliente.Orgao = formBase.orgEmissorRgCliente;
            cliente.Endereco = formBase.enderecoCliente;
            cliente.Numero = formBase.nEndCliente;
            cliente.Bairro = formBase.bairroCliente;
            cliente.CEP = formBase.cepCliente;
            cliente.Referencia = formBase.referenciaCliente;
            cliente.Apelido = formBase.apelidoCliente;
            cliente.Email = formBase.emailCliente;
            cliente.Pais = formBase.paisCliente;
            cliente.Estado = formBase.estadoCliente;
            cliente.Cidade = formBase.cidadeCliente;
            //cliente.LimiteCredito = Convert.ToDecimal(formBase.descontoCredCliente);
            cliente.Telefone = formBase.telefoneCliente;
            cliente.Telefone2 = formBase.telefone2Cliente;
            cliente.Celular = formBase.celularCliente;
            cliente.Sexo = formBase.sexoCliente;
            cliente.EstadoCivil = formBase.estadoCivilCliente;

            // CAMPOS ADICIONAIS
            cliente.Nacionalidade = formAdicional.nacionalidadeCliente;
            cliente.UF = formAdicional.ufCliente;
            cliente.StatusAtividade = formAdicional.statuCliente;
            cliente.Naturalidade = formAdicional.naturalidadeCliente;
            //cliente.DataNascimento = Convert.ToDateTime(formAdicional.dataNascCliente);

            // CAMPOS FILIAÇÃO
            cliente.Pai = formFiliacao.paiCliente;
            cliente.fonePai = formFiliacao.telefonePaiCliente;
            cliente.Mae = formFiliacao.maeCliente;
            cliente.foneMae = formFiliacao.telefoneMaeCliente;
            cliente.EnderecoFiliacao = formFiliacao.enderecoFiliacaoCliente;
            cliente.ReferenciaEnderecoFiliacao = formFiliacao.referenciaFiliacaoCliente;
            cliente.NumeroEnderecoFiliacao = formFiliacao.numeroEndFiliacaooCliente;
            cliente.CEPFiliacao = formFiliacao.cepEndFiliacaoCliente;
            cliente.BairroFiliacao = formFiliacao.bairroFiliacaoCliente;
            cliente.EstadoFiliacao = formFiliacao.estadoFiliacaoCliente;
            cliente.CidadeFiliacao = formFiliacao.cidadeFiliacaoCliente;

            // CAMPOS END. ENTREGA
            cliente.EnderecoEntrega = formEndEntrega.enderecoEntregaCliente;
            cliente.ReferenciaEntrega = formEndEntrega.referenciaEnderecoEntrgaCliente;
            cliente.NumeroEndEntrega = formEndEntrega.nEnderecoEntrgaClliente;
            cliente.CEPEntrega = formEndEntrega.cepEnderecoEntregaCliente;
            cliente.BairroEntrega = formEndEntrega.bairroEnderecoEntregaCliente;
            cliente.EstadoEntrega = formEndEntrega.estadoEnderecoEntregaCliente;
            cliente.CidadeEntrega = formEndEntrega.cidadeEnderecoEntregaCliente;

            // CAMPOS EMPRESA
            cliente.Empresa = formEmpresa.nomeEmpresaCliente;
            cliente.FoneEmpresa = formEmpresa.telefoneClienteEmpresa;
            cliente.EnderecoEmpresa = formEmpresa.enderecoClienteEmpresa;
            cliente.NumeroEndEmpresa = formEmpresa.NenderecoClienteEmpres;
            cliente.CEPEndEmpresa = formEmpresa.cepClienteEmpresa;
            cliente.BairroEndEmpresa = formEmpresa.bairroClienteEmpresa;
            cliente.UFEmpresa = formEmpresa.ufClienteEmpresa;
            cliente.CidadeEndEmpresa = formEmpresa.cidadeClienteEmpresa;
            cliente.CargoEmpresa = formEmpresa.cargoClienteEmpresa;
            //cliente.Renda = Convert.ToDecimal(formEmpresa.rendaClienteEmpresa);
            //cliente.DataAdmissao = Convert.ToDateTime(formEmpresa.admissaoClienteEmpresa);

            // CAMPOS CONJUGUE
            cliente.Conjugue = formConjugue.nomeClienteConjugue;
            cliente.CPFConjugue = formConjugue.cpfClienteConjugue;
            cliente.RGConjugue = formConjugue.rgClienteConjugue;
            //cliente.DataNascConjugue = Convert.ToDateTime(formConjugue.dataNascClienteConjugue);
            cliente.FoneConjugue = formConjugue.telefoneConjugue;
            cliente.EndConjugue = formConjugue.enderecoClienteConjugue;
            cliente.NumeroEndConjugue = formConjugue.NumeroEndClienteConjugue;
            cliente.CepConjugue = formConjugue.cepClienteConjugue;
            cliente.BairroConjuge = formConjugue.bairroClienteConjugue;
            cliente.UFConjugue = formConjugue.ufClienteConjugue;
            cliente.CidadeConjugue = formConjugue.cidadeClienteConjugue;
            cliente.EmpresaConjugue = formConjugue.empresaClienteConjugue;
            cliente.CargoEmpresaConjugue = formConjugue.cargoClienteConjugue;
            //cliente.RendaConjugue = Convert.ToDecimal(formConjugue.rendaClienteConjugue);
            //cliente.DataAdmissaoConjugue = Convert.ToDateTime(formConjugue.admissaoClienteConjugue);

            // CAMPOS AVALISTA
            cliente.NomeAvalista = formAvalista.nomeClienteAvalista;
            cliente.CPFAvalista = formAvalista.cpfClienteAvalista;
            cliente.RGAvalista = formAvalista.rgClienteAvalista;
            //cliente.DataNascAvalista = Convert.ToDateTime(formAvalista.dataNascimentoClienteAvalista);
            cliente.FoneAvalista = formAvalista.TelefoneClienteAvalista;
            cliente.EndAvalista = formAvalista.enderecoClienteAvalista;
            cliente.NumeroEndAvalista = formAvalista.numeroEnderecoClienteAvalista;
            cliente.CepAvalista = formAvalista.cepClienteAvalista;
            cliente.BairroAvalista = formAvalista.bairroClienteAvalista;
            cliente.UFAvalista = formAvalista.ufClienteAvalista;
            cliente.CidadeAvalista = formAvalista.cidadeClienteAvalista;
            cliente.EmpresaAvalista = formAvalista.empresaClienteAvalista;
            cliente.CargoAvalista = formAvalista.cargolienteAvalista;
            //cliente.RendaAvalista = Convert.ToDecimal(formAvalista.rendaClienteAvalista);
            //cliente.DataAdmissaoAvalista = Convert.ToDateTime(formAvalista.admissaoClienteAvalista);

            // CAMPOS FIDELIDADE
            cliente.NumeroDoCartaoCliente = formFidelidade.numeroCartaoFidadelidadeCliente;
            cliente.TabelaDePreco = formFidelidade.tabelaPrecosFidadelidadeCliente;
            cliente.Vendedor = formFidelidade.vendedorFidadelidadeCliente;

            // CAMPOS REFERENCIA
            cliente.Referencia = formRef.refereniaClienteRefrencia;
            cliente.Comercial1 = formRef.comercial1ClienteRefrencia;
            cliente.Comercial2 = formRef.comercial2ClienteRefrencia;
            cliente.Comercial3 = formRef.comercial3ClienteRefrencia;
            cliente.Bancaria1 = formRef.bancaria1ClienteRefrencia;
            cliente.Bancaria2 = formRef.bancaria2lienteRefrencia;

            // CAMPOS OBSERVAÇÕES
            cliente.Observacoes = formObs.observacoesCliente;

            // MÉTODO PARA CADASTRAR O CLIENTE NO BANCO DE DADOS
            banco.cadastrar_cliente(cliente);
        }
    }
}
