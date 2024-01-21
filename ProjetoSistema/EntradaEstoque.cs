using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSistema
{
    internal class EntradaEstoque
    {
        public int IdEntradaEstoque;
        public string TipoEntrada;
        public string Local;
        public int Numero;
        public string Serie;
        public string Modelo;
        public string Natureza;
        public int ChaveNFe;
        public DateTime DataEmissao;
        public DateTime DataEntrada;
        public string TipoFrete;
        public int CodigoProduto;
        public string NomeProduto;
        public decimal PrecoDeCompra;
        public decimal QuantidadeDeCompra;
        public string Unidades;
        public decimal PrecoCusto;
        public decimal Total;
        public decimal BaseCalculoICMS;
        public decimal ValorICMS;
        public decimal BaseCalcICMSST;
        public decimal ValorICMSST;
        public decimal ValorFrete;
        public decimal ValorSeguro;
        public decimal Desconto;
        public decimal OutrasDespesas;
        public decimal ValorPIS;
        public decimal ValorCOFINS;
        public decimal ValorIPI;
        public decimal Valor2;
        public decimal ValorTotalProdutos;
        public decimal ValorTotalImposto;
        public decimal ValorTotalNota;
    }
}
