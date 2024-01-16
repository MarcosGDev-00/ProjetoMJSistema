using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSistema
{
    internal class Produtos
    {
        public int id;
        public string descricao;
        public string cod_produto;
        public string ncm;
        public string unidade_medida;
        public decimal quant_estoque;
        public decimal valor_unit;
        public decimal aliquota_icms;
        public decimal aliquota_ipi;
        public string cest;
        public string outras_info;
        public DateTime data_cad;
        public string classif_fiscal;
        public string cod_barras;
        public int origem_produto;
        public int cfop;
        public int exig_st;
        public int modalidade_st;
        public string nfe_cod_barras;
        public string nfe_gtin;
        public string nfe_cean;
        public string nfe_ncm;
        public string nfe_cest;
    }
}
