using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows;

namespace ProjetoSistema
{
    internal class Banco
    {
        public string host;
        public string nome;
        public string usuario;
        public string senha;

        private MySqlConnection conexao = null;
        private MySqlCommand cmd;

        public Banco()
        {
            this.host = "localhost";
            this.nome = "sistema_loja_mj";
            this.usuario = "root";
            this.senha = "";
        }

        public void conectar()
        {
            conexao = new MySqlConnection("server=" + host + ";User Id=" + usuario + ";database=" + nome + ";password=" + senha);
            try
            {
                conexao.Open();
                Console.WriteLine("Conectado ao banco com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar ao banco!");
            }
        }

        public void cadastrar_pais(CadastrarPais pais)
        {
            cmd = new MySqlCommand("INSERT INTO pais (pais) VALUES (?)", conexao); // O comado que ele irá execultar é igual ao valor dos Parenteses
            cmd.Parameters.Add("@pais", MySqlDbType.VarChar, 50).Value = pais.NomePais;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("erro ao inserir Pais!");
            }
        }

        public void cadastrar_cidade(CadastrarCidade cidade)
        {
            cmd = new MySqlCommand("INSERT INTO cidade (cidade) VALUES (?)", conexao); // O comado que ele irá execultar é igual ao valor dos Parenteses
            cmd.Parameters.Add("@cidade", MySqlDbType.VarChar, 50).Value = cidade.cidade;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("erro ao inserir Cidade!");
            }
        }

        public void cadastrar_cliente(CadastrarCliente novoCliente)
        {
            cmd = new MySqlCommand("INSERT INTO cadastrar_cliente (tipo_documento, doc, ins_estadual, ind_IE, ins_municipal, nome, RG, data_emissao, orgao, razao_social, endereco, numero, bairro, cep, referencia, apelido, email, pais, estado, cidade, limite_credito, telefone, telefone2, celular, sexo, estado_civil, nacionalidade, uf, naturalidade, data_nascimento, status_atividade, vender_a_prazo, pai, mae, ende_filiacao, referencia_ende_filiacao, numero_ende_filiacao, cep_ende_filiacao, bairro_ende_filiacao, estado_filiacao, cidade_filiacao, endereco_entrega, referencia_entrega, numero_end_entrega, cep_entrega, bairro_entrega, estado_entrega, cidade_entrega, empresa, fone, end_empresa, numero_end_empresa, cep_end_empresa, bairro_end_empresa, UF_empresa, cidade_end_empresa, cargo_empresa, renda, data_admissao, nome_avalista, cpf_avalista, rg_avalista, data_nasc_avalista, fone_avalista, end_avalista, numero_end_avalista, cep_avalista, bairro_avalista, uf_avalista, cidade_avalista, empresa_do_avalista, cargo_avalista, renda_avalista, data_admissao_avalista, conjugue, cpf_conjugue, rg_conjugue, data_nasc_conjugue, fone_conjugue, end_conjugue, numero_end_conjugue, cep_conjugue, bairro_conjuge, uf_conjugue, cidade_conjugue, empresa_do_conjugue, cargo_empresa_conjugue, renda_conjugue, data_admissao_conjugue, numero_do_cartao_cliente, tabela_de_preco, foto_cliente, vendedor, referencia_comercial, comercial1, comercial2, comercial3, bancaria1, bancaria2, observacoes) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", conexao);

            cmd.Parameters.Add("@tipo_documento", MySqlDbType.VarChar, 18).Value = novoCliente.TipoDocumento;
            cmd.Parameters.Add("@doc", MySqlDbType.VarChar, 20).Value = novoCliente.doc;
            cmd.Parameters.Add("@ins_estadual", MySqlDbType.VarChar, 30).Value = novoCliente.InsEstadual;
            cmd.Parameters.Add("@ind_IE", MySqlDbType.VarChar, 30).Value = novoCliente.IndIE;
            cmd.Parameters.Add("@ins_municipal", MySqlDbType.VarChar, 30).Value = novoCliente.InsMunicipal;
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = novoCliente.Nome;
            cmd.Parameters.Add("@RG", MySqlDbType.Int32, 10).Value = novoCliente.RG;
            cmd.Parameters.Add("@data_emissao", MySqlDbType.Date).Value = novoCliente.DataEmissao;
            cmd.Parameters.Add("@orgao", MySqlDbType.VarChar, 20).Value = novoCliente.Orgao;
            cmd.Parameters.Add("@razao_social", MySqlDbType.VarChar, 100).Value = novoCliente.RazaoSocial;
            cmd.Parameters.Add("@endereco", MySqlDbType.VarChar, 50).Value = novoCliente.Endereco;
            cmd.Parameters.Add("@numero", MySqlDbType.VarChar, 10).Value = novoCliente.Numero;
            cmd.Parameters.Add("@bairro", MySqlDbType.VarChar, 30).Value = novoCliente.Bairro;
            cmd.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = novoCliente.CEP;
            cmd.Parameters.Add("@referencia", MySqlDbType.VarChar, 30).Value = novoCliente.Referencia;
            cmd.Parameters.Add("@apelido", MySqlDbType.VarChar, 50).Value = novoCliente.Apelido;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar, 50).Value = novoCliente.Email;
            cmd.Parameters.Add("@pais", MySqlDbType.VarChar, 20).Value = novoCliente.Pais;
            cmd.Parameters.Add("@estado", MySqlDbType.VarChar, 20).Value = novoCliente.Estado;
            cmd.Parameters.Add("@cidade", MySqlDbType.VarChar, 30).Value = novoCliente.Cidade;
            cmd.Parameters.Add("@limite_credito", MySqlDbType.Decimal, 12).Value = novoCliente.LimiteCredito;
            cmd.Parameters.Add("@telefone", MySqlDbType.VarChar, 15).Value = novoCliente.Telefone;
            cmd.Parameters.Add("@telefone2", MySqlDbType.VarChar, 15).Value = novoCliente.Telefone2;
            cmd.Parameters.Add("@celular", MySqlDbType.VarChar, 15).Value = novoCliente.Celular;
            cmd.Parameters.Add("@sexo", MySqlDbType.VarChar, 10).Value = novoCliente.Sexo;
            cmd.Parameters.Add("@estado_civil", MySqlDbType.VarChar, 20).Value = novoCliente.EstadoCivil;
            cmd.Parameters.Add("@nacionalidade", MySqlDbType.VarChar, 20).Value = novoCliente.Nacionalidade;
            cmd.Parameters.Add("@uf", MySqlDbType.VarChar, 20).Value = novoCliente.UF;
            cmd.Parameters.Add("@naturalidade", MySqlDbType.VarChar, 20).Value = novoCliente.Naturalidade;
            cmd.Parameters.Add("@data_nascimento", MySqlDbType.Date).Value = novoCliente.DataNascimento;
            cmd.Parameters.Add("@status_atividade", MySqlDbType.VarChar, 7).Value = novoCliente.StatusAtividade;
            cmd.Parameters.Add("@vender_a_prazo", MySqlDbType.VarChar, 3).Value = novoCliente.VenderAPrazo;
            cmd.Parameters.Add("@pai", MySqlDbType.VarChar, 100).Value = novoCliente.Pai;
            cmd.Parameters.Add("@mae", MySqlDbType.VarChar, 100).Value = novoCliente.Mae;
            cmd.Parameters.Add("@ende_filiacao", MySqlDbType.VarChar, 50).Value = novoCliente.EnderecoFiliacao;
            cmd.Parameters.Add("@referencia_ende_filiacao", MySqlDbType.VarChar, 30).Value = novoCliente.ReferenciaEnderecoFiliacao;
            cmd.Parameters.Add("@numero_ende_filiacao", MySqlDbType.VarChar, 10).Value = novoCliente.NumeroEnderecoFiliacao;
            cmd.Parameters.Add("@cep_ende_filiacao", MySqlDbType.VarChar, 9).Value = novoCliente.CEPFiliacao;
            cmd.Parameters.Add("@bairro_ende_filiacao", MySqlDbType.VarChar, 30).Value = novoCliente.BairroFiliacao;
            cmd.Parameters.Add("@estado_filiacao", MySqlDbType.VarChar, 15).Value = novoCliente.EstadoFiliacao;
            cmd.Parameters.Add("@cidade_filiacao", MySqlDbType.VarChar, 20).Value = novoCliente.CidadeFiliacao;
            cmd.Parameters.Add("@endereco_entrega", MySqlDbType.VarChar, 50).Value = novoCliente.EnderecoEntrega;
            cmd.Parameters.Add("@referencia_entrega", MySqlDbType.VarChar, 30).Value = novoCliente.ReferenciaEntrega;
            cmd.Parameters.Add("@numero_end_entrega", MySqlDbType.VarChar, 10).Value = novoCliente.NumeroEndEntrega;
            cmd.Parameters.Add("@cep_entrega", MySqlDbType.VarChar, 9).Value = novoCliente.CEPEntrega;
            cmd.Parameters.Add("@bairro_entrega", MySqlDbType.VarChar, 30).Value = novoCliente.BairroEntrega;
            cmd.Parameters.Add("@estado_entrega", MySqlDbType.VarChar, 15).Value = novoCliente.EstadoEntrega;
            cmd.Parameters.Add("@cidade_entrega", MySqlDbType.VarChar, 20).Value = novoCliente.CidadeEntrega;
            cmd.Parameters.Add("@empresa", MySqlDbType.VarChar, 50).Value = novoCliente.Empresa;
            cmd.Parameters.Add("@fone", MySqlDbType.VarChar, 14).Value = novoCliente.FoneEmpresa;
            cmd.Parameters.Add("@end_empresa", MySqlDbType.VarChar, 30).Value = novoCliente.EnderecoEmpresa;
            cmd.Parameters.Add("@numero_end_empresa", MySqlDbType.VarChar, 10).Value = novoCliente.NumeroEndEmpresa;
            cmd.Parameters.Add("@cep_end_empresa", MySqlDbType.VarChar, 9).Value = novoCliente.CEPEndEmpresa;
            cmd.Parameters.Add("@bairro_end_empresa", MySqlDbType.Int32, 30).Value = novoCliente.BairroEndEmpresa;
            cmd.Parameters.Add("@UF_empresa", MySqlDbType.Int32, 20).Value = novoCliente.UFEmpresa;
            cmd.Parameters.Add("@cidade_end_empresa", MySqlDbType.VarChar, 20).Value = novoCliente.CidadeEndEmpresa;
            cmd.Parameters.Add("@cargo_empresa", MySqlDbType.VarChar, 30).Value = novoCliente.CargoEmpresa;
            cmd.Parameters.Add("@renda", MySqlDbType.Decimal, 12).Value = novoCliente.Renda;
            cmd.Parameters.Add("@data_admissao", MySqlDbType.Date).Value = novoCliente.DataAdmissao;
            cmd.Parameters.Add("@nome_avalista", MySqlDbType.VarChar, 100).Value = novoCliente.NomeAvalista;
            cmd.Parameters.Add("@cpf_avalista", MySqlDbType.VarChar, 14).Value = novoCliente.CPFAvalista;
            cmd.Parameters.Add("@rg_avalista", MySqlDbType.VarChar, 7).Value = novoCliente.RGAvalista;
            cmd.Parameters.Add("@data_nasc_avalista", MySqlDbType.Date).Value = novoCliente.DataNascAvalista;
            cmd.Parameters.Add("@fone_avalista", MySqlDbType.VarChar, 15).Value = novoCliente.FoneAvalista;
            cmd.Parameters.Add("@end_avalista", MySqlDbType.VarChar, 30).Value = novoCliente.EndAvalista;
            cmd.Parameters.Add("@numero_end_avalista", MySqlDbType.VarChar, 10).Value = novoCliente.NumeroEndAvalista;
            cmd.Parameters.Add("@cep_avalista", MySqlDbType.VarChar, 9).Value = novoCliente.CepAvalista;
            cmd.Parameters.Add("@bairro_avalista", MySqlDbType.VarChar, 15).Value = novoCliente.BairroAvalista;
            cmd.Parameters.Add("@uf_avalista", MySqlDbType.Int32, 30).Value = novoCliente.UFAvalista;
            cmd.Parameters.Add("@cidade_avalista", MySqlDbType.VarChar, 30).Value = novoCliente.CidadeAvalista;
            cmd.Parameters.Add("@empresa_do_avalista", MySqlDbType.VarChar, 50).Value = novoCliente.EmpresaAvalista;
            cmd.Parameters.Add("@cargo_avalista", MySqlDbType.VarChar, 50).Value = novoCliente.CargoAvalista;
            cmd.Parameters.Add("@renda_avalista", MySqlDbType.Decimal, 12).Value = novoCliente.RendaAvalista;
            cmd.Parameters.Add("@data_admissao_avalista", MySqlDbType.Date).Value = novoCliente.DataAdmissaoAvalista;
            cmd.Parameters.Add("@conjugue", MySqlDbType.VarChar, 100).Value = novoCliente.Conjugue;
            cmd.Parameters.Add("@cpf_conjugue", MySqlDbType.VarChar, 14).Value = novoCliente.CPFConjugue;
            cmd.Parameters.Add("@rg_conjugue", MySqlDbType.VarChar, 10).Value = novoCliente.RGConjugue;
            cmd.Parameters.Add("@data_nasc_conjugue", MySqlDbType.Date).Value = novoCliente.DataNascConjugue;
            cmd.Parameters.Add("@fone_conjugue", MySqlDbType.VarChar, 15).Value = novoCliente.FoneConjugue;
            cmd.Parameters.Add("@end_conjugue", MySqlDbType.VarChar, 50).Value = novoCliente.EndConjugue;
            cmd.Parameters.Add("@numero_end_conjugue", MySqlDbType.VarChar, 10).Value = novoCliente.NumeroEndConjugue;
            cmd.Parameters.Add("@cep_conjugue", MySqlDbType.VarChar, 9).Value = novoCliente.CepConjugue;
            cmd.Parameters.Add("@bairro_conjugue", MySqlDbType.VarChar, 20).Value = novoCliente.BairroConjuge;
            cmd.Parameters.Add("@uf_conjugue", MySqlDbType.VarChar, 20).Value = novoCliente.UFConjugue;
            cmd.Parameters.Add("@cidade_conjugue", MySqlDbType.VarChar, 30).Value = novoCliente.CidadeConjugue;
            cmd.Parameters.Add("@empresa_do_conjugue", MySqlDbType.VarChar, 50).Value = novoCliente.EmpresaConjugue;
            cmd.Parameters.Add("@cargo_empresa_conjugue", MySqlDbType.VarChar, 50).Value = novoCliente.CargoEmpresaConjugue;
            cmd.Parameters.Add("@renda_conjugue", MySqlDbType.Decimal, 12).Value = novoCliente.RendaConjugue;
            cmd.Parameters.Add("@data_admissao_conjugue", MySqlDbType.Date).Value = novoCliente.DataAdmissaoConjugue;
            cmd.Parameters.Add("@numero_do_cartao_cliente", MySqlDbType.VarChar, 16).Value = novoCliente.NumeroDoCartaoCliente;
            cmd.Parameters.Add("@tabela_de_preco", MySqlDbType.VarChar, 15).Value = novoCliente.TabelaDePreco;
            cmd.Parameters.Add("@foto_cliente", MySqlDbType.VarChar, 100).Value = novoCliente.FotoCliente;
            cmd.Parameters.Add("@vendedor", MySqlDbType.VarChar, 50).Value = novoCliente.Vendedor;
            cmd.Parameters.Add("@referencia_comercial", MySqlDbType.VarChar, 30).Value = novoCliente.ReferenciaComercial;
            cmd.Parameters.Add("@comercial1", MySqlDbType.VarChar, 30).Value = novoCliente.Comercial1;
            cmd.Parameters.Add("@comercial2", MySqlDbType.VarChar, 30).Value = novoCliente.Comercial2;
            cmd.Parameters.Add("@comercial3", MySqlDbType.VarChar, 30).Value = novoCliente.Comercial3;
            cmd.Parameters.Add("@bancaria1", MySqlDbType.VarChar, 50).Value = novoCliente.Bancaria1;
            cmd.Parameters.Add("@bancaria2", MySqlDbType.VarChar, 50).Value = novoCliente.Bancaria2;
            cmd.Parameters.Add("@observacoes", MySqlDbType.VarChar, 80).Value = novoCliente.Observacoes;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar cliente: {ex.Message}");
                Console.WriteLine($"Erro ao cadastrar cliente: {ex.Message}");
            }
        }

        public void CadastrarCategoria(CadastrarCategoriaProduto categoria)
        {
            cmd = new MySqlCommand("INSERT INTO categoria (codigo, nome, status, comissao_por_percent, descricao) VALUES (?, ?, ?, ?, ?)", conexao);

            cmd.Parameters.Add("@codigo", MySqlDbType.Int32, 11).Value = categoria.Codigo;
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 30).Value = categoria.Nome;
            cmd.Parameters.Add("@status", MySqlDbType.VarChar, 15).Value = categoria.Status;
            cmd.Parameters.Add("@comissao_por_percent", MySqlDbType.Decimal, 10).Value = categoria.Comissao_por_percent;
            cmd.Parameters.Add("@descricao", MySqlDbType.VarChar, 100).Value = categoria.Descricao;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar categoria: {ex.Message}");
            }
        }
        public void CadastrarSubcategoria(CadastrarSubcategorias subcategoria)
        {
            cmd = new MySqlCommand("INSERT INTO subcategoria (codigo, nome, status, comissao_por_percent, descricao) VALUES (?, ?, ?, ?, ?)", conexao);

            cmd.Parameters.Add("@codigo", MySqlDbType.Int32, 11).Value = subcategoria.Codigo;
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 30).Value = subcategoria.Nome;
            cmd.Parameters.Add("@status", MySqlDbType.VarChar, 30).Value = subcategoria.Status;
            cmd.Parameters.Add("@descricao", MySqlDbType.VarChar, 30).Value = subcategoria.Descricao;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar subcategoria: {ex.Message}");
            }
        }
        public void CadastrarFabricante(CadastrarFabricante fabricante)
        {
            cmd = new MySqlCommand("INSERT INTO fabricante(nome, contato, endereco, cnpj_cpf) VALUES (?, ?, ?, ?)", conexao);

            cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = fabricante.Nome;
            cmd.Parameters.Add("@contato", MySqlDbType.VarChar, 30).Value = fabricante.Contato;
            cmd.Parameters.Add("@endereco", MySqlDbType.VarChar, 50).Value = fabricante.Endereco;
            cmd.Parameters.Add("@cnpj_cpf", MySqlDbType.VarChar, 18).Value = fabricante.Cnpj_Cpf;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar fabricante: {ex.Message}");
            }
        }
        public void CadastrarFornecedor(CadastrarFornecedores fornecedor)
        {
            cmd = new MySqlCommand("INSERT INTO fornecedor(nome, contato, endereco, cnpj_cpf, RazaoSocial) VALUES (?, ?, ?, ?, ?)", conexao);

            cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = fornecedor.Nome;
            cmd.Parameters.Add("@contato", MySqlDbType.VarChar, 14).Value = fornecedor.Contato;
            cmd.Parameters.Add("@endereco", MySqlDbType.VarChar, 50).Value = fornecedor.Endereco;
            cmd.Parameters.Add("@cnpj_cpf", MySqlDbType.VarChar, 18).Value = fornecedor.Cnpj_Cpf;
            cmd.Parameters.Add("@RazaoSocial", MySqlDbType.VarChar, 50).Value = fornecedor.Cnpj_Cpf;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar fornecedor: {ex.Message}");
            }
        }
        public void CadastrarGeneroProduto(CadastrarGeneroProduto genero)
        {
            cmd = new MySqlCommand("INSERT INTO genero(genero) VALUES (?)", conexao);
            cmd.Parameters.Add("@genero", MySqlDbType.VarChar, 50).Value = genero.genero;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar genero: {ex.Message}");
            }
        }
        public void CadastrarLocalEstoque(CadastrarLocalEstoque local)
        {
            cmd = new MySqlCommand("INSERT INTO local_estoque(local) VALUES (?)", conexao);
            cmd.Parameters.Add("@local", MySqlDbType.VarChar, 50).Value = local.LocalNoEstoque;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar genero: {ex.Message}");
            }
        }
        public void CadastrarLocalEstabelecimento(CadastrarLocalEstabelecimento local)
        {
            cmd = new MySqlCommand("INSERT INTO local_estabelecimento(local_no_estabelecimento) VALUES (?)", conexao);
            cmd.Parameters.Add("@local_no_estabelecimento", MySqlDbType.VarChar, 50).Value = local.LocalNoEstabelecimento;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar genero: {ex.Message}");
            }
        }
        public void CadastrarProduto(CadastrarProduto novoProduto)
        {
            cmd = new MySqlCommand("INSERT INTO cadastrar_produto (nome, codigo_interno, codigo_adicional, codigo_barras, unidade_medida, referencia, descricao, tipo_produto, categoria, subcategoria, fabricante, fornecedor, status, receber_desconto, vender_fracionado, controlar_estoque, balanca, balanca_checkout, atualizar_preco, atualizar_ncm_entrada_estoque, preco_compra, ipi, valor_frete, custo, custo_medio, preco_venda, preco2, preco3, prec4, margem, margem2, margem3, margem4, qnt_minima, qnt_minima2, qnt_minima3, qnt_minima4, desc_max, desc_max2, desc_max3, desc_max4, grupo_trib, cst, cfop, origem, ncm, cest, genero, icms_saida, reducao_base_cal_entrada, obs_icms, icms_entrada, reducao_base_cal_saida, fcp, pis_saida, pis_aliquota_saida, pis_entrada, pis_aliquota_entrada, confins_saida, confins_aliquota_saida, confins_entrada, confins_aliquota_entrada, ipi_saida, ipi_aliquota_saida, ipi_entrada, ipi_aliquota_entrada, estoque, qnt_embalagem, estoque_maximo, estoque_minimo, peso_bruto, peso_liquido, data_validade, tara, local_no_estabelecimento, empresa, local_no_estoque, saldo, promocao_data_inicial, promocao_data_final, valor_promocao, comissao_porcentagem, comissao_real, pontos, imagem, tipo_lista, tipo_preco, linha, portaria, data_vigencia, preco_antigo, rm_saida, class_terapeutica, un_medida_sngpc, uso_prolongado, precovenda_farmacia_popular, margem_farmacia_popular, apresentacao_cx, codigo_anp, desc_anp, observacoes) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, , ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", conexao);

            cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = novoProduto.Nome;
            cmd.Parameters.Add("@codigo_interno", MySqlDbType.VarChar, 20).Value = novoProduto.CodigoInterno;
            cmd.Parameters.Add("@codigo_adicional", MySqlDbType.VarChar, 10).Value = novoProduto.CodigoAdicional;
            cmd.Parameters.Add("@codigo_barras", MySqlDbType.VarChar, 13).Value = novoProduto.CodigoBarras;
            cmd.Parameters.Add("@unidade_medida", MySqlDbType.VarChar, 15).Value = novoProduto.UnidadeMedida;
            cmd.Parameters.Add("@referencia", MySqlDbType.VarChar, 20).Value = novoProduto.referencia;
            cmd.Parameters.Add("@descricao", MySqlDbType.VarChar, 100).Value = novoProduto.Descricao;
            cmd.Parameters.Add("@tipo_produto", MySqlDbType.VarChar, 10).Value = novoProduto.TipoProduto;
            cmd.Parameters.Add("@categoria", MySqlDbType.VarChar, 15).Value = novoProduto.Categoria;
            cmd.Parameters.Add("@subcategoria", MySqlDbType.VarChar, 15).Value = novoProduto.Subcategoria;
            cmd.Parameters.Add("@fabricante", MySqlDbType.VarChar, 20).Value = novoProduto.Fabricante;
            cmd.Parameters.Add("@fornecedor", MySqlDbType.VarChar, 20).Value = novoProduto.Fornecedor;
            cmd.Parameters.Add("@status", MySqlDbType.VarChar, 7).Value = novoProduto.Status;
            cmd.Parameters.Add("@receber_desconto", MySqlDbType.VarChar, 3).Value = novoProduto.ReceberDesconto;
            cmd.Parameters.Add("@vender_fracionado", MySqlDbType.VarChar, 3).Value = novoProduto.VenderFracionado;
            cmd.Parameters.Add("@controlar_estoque", MySqlDbType.VarChar, 3).Value = novoProduto.ControlarEstoque;
            cmd.Parameters.Add("@balanca", MySqlDbType.VarChar, 3).Value = novoProduto.Balanca;
            cmd.Parameters.Add("@balanca_checkout", MySqlDbType.VarChar, 3).Value = novoProduto.BalancaCheckout;
            cmd.Parameters.Add("@atualizar_preco", MySqlDbType.VarChar, 3).Value = novoProduto.AtualizarPreco;
            cmd.Parameters.Add("@atualizar_ncm_entrada_estoque", MySqlDbType.VarChar, 3).Value = novoProduto.AtualizarNcmEntradaEstoque;
            cmd.Parameters.Add("@preco_compra", MySqlDbType.Decimal).Value = novoProduto.PrecoCompra;
            cmd.Parameters.Add("@ipi", MySqlDbType.Decimal).Value = novoProduto.Ipi;
            cmd.Parameters.Add("@valor_frete", MySqlDbType.Decimal).Value = novoProduto.ValorFrete;
            cmd.Parameters.Add("@custo", MySqlDbType.Decimal).Value = novoProduto.Custo;
            cmd.Parameters.Add("@custo_medio", MySqlDbType.Decimal).Value = novoProduto.CustoMedio;
            cmd.Parameters.Add("@preco_venda", MySqlDbType.Decimal).Value = novoProduto.PrecoVenda;
            cmd.Parameters.Add("@preco2", MySqlDbType.Decimal).Value = novoProduto.Preco2;
            cmd.Parameters.Add("@preco3", MySqlDbType.Decimal).Value = novoProduto.Preco3;
            cmd.Parameters.Add("@prec4", MySqlDbType.Decimal).Value = novoProduto.Preco4;
            cmd.Parameters.Add("@margem", MySqlDbType.Decimal).Value = novoProduto.Margem;
            cmd.Parameters.Add("@margem2", MySqlDbType.Decimal).Value = novoProduto.Margem2;
            cmd.Parameters.Add("@margem3", MySqlDbType.Decimal).Value = novoProduto.Margem3;
            cmd.Parameters.Add("@margem4", MySqlDbType.Decimal).Value = novoProduto.Margem4;
            cmd.Parameters.Add("@qnt_minima", MySqlDbType.Decimal).Value = novoProduto.QntMinima;
            cmd.Parameters.Add("@qnt_minima2", MySqlDbType.Decimal).Value = novoProduto.QntMinima2;
            cmd.Parameters.Add("@qnt_minima3", MySqlDbType.Decimal).Value = novoProduto.QntMinima3;
            cmd.Parameters.Add("@qnt_minima4", MySqlDbType.Decimal).Value = novoProduto.QntMinima4;
            cmd.Parameters.Add("@desc_max", MySqlDbType.Decimal).Value = novoProduto.DescMax;
            cmd.Parameters.Add("@desc_max2", MySqlDbType.Decimal).Value = novoProduto.DescMax2;
            cmd.Parameters.Add("@desc_max3", MySqlDbType.Decimal).Value = novoProduto.DescMax3;
            cmd.Parameters.Add("@desc_max4", MySqlDbType.Decimal).Value = novoProduto.DescMax4;
            cmd.Parameters.Add("@grupo_trib", MySqlDbType.VarChar, 10).Value = novoProduto.GrupoTrib;
            cmd.Parameters.Add("@cst", MySqlDbType.VarChar, 10).Value = novoProduto.Cst;
            cmd.Parameters.Add("@cfop", MySqlDbType.VarChar, 10).Value = novoProduto.Cfop;
            cmd.Parameters.Add("@origem", MySqlDbType.VarChar, 10).Value = novoProduto.Origem;
            cmd.Parameters.Add("@ncm", MySqlDbType.VarChar, 15).Value = novoProduto.Ncm;
            cmd.Parameters.Add("@cest", MySqlDbType.VarChar, 10).Value = novoProduto.Cest;
            cmd.Parameters.Add("@genero", MySqlDbType.VarChar, 20).Value = novoProduto.Genero;
            cmd.Parameters.Add("@icms_saida", MySqlDbType.Decimal).Value = novoProduto.IcmsSaida;
            cmd.Parameters.Add("@reducao_base_cal_entrada", MySqlDbType.Decimal).Value = novoProduto.ReducaoBaseCalEntrada;
            cmd.Parameters.Add("@obs_icms", MySqlDbType.VarChar, 255).Value = novoProduto.ObsIcms;
            cmd.Parameters.Add("@icms_entrada", MySqlDbType.Decimal).Value = novoProduto.IcmsEntrada;
            cmd.Parameters.Add("@reducao_base_cal_saida", MySqlDbType.Decimal).Value = novoProduto.ReducaoBaseCalSaida;
            cmd.Parameters.Add("@fcp", MySqlDbType.Decimal).Value = novoProduto.Fcp;
            cmd.Parameters.Add("@pis_saida", MySqlDbType.VarChar, 10).Value = novoProduto.PisSaida;
            cmd.Parameters.Add("@pis_aliquota_saida", MySqlDbType.Decimal).Value = novoProduto.PisAliquotaSaida;
            cmd.Parameters.Add("@pis_entrada", MySqlDbType.VarChar, 10).Value = novoProduto.PisEntrada;
            cmd.Parameters.Add("@pis_aliquota_entrada", MySqlDbType.Decimal).Value = novoProduto.PisAliquotaEntrada;
            cmd.Parameters.Add("@confins_saida", MySqlDbType.VarChar, 10).Value = novoProduto.ConfinsSaida;
            cmd.Parameters.Add("@confins_aliquota_saida", MySqlDbType.Decimal).Value = novoProduto.ConfinsAliquotaSaida;
            cmd.Parameters.Add("@confins_entrada", MySqlDbType.VarChar, 10).Value = novoProduto.ConfinsEntrada;
            cmd.Parameters.Add("@confins_aliquota_entrada", MySqlDbType.Decimal).Value = novoProduto.ConfinsAliquotaEntrada;
            cmd.Parameters.Add("@ipi_saida", MySqlDbType.VarChar, 10).Value = novoProduto.IpiSaida;
            cmd.Parameters.Add("@ipi_aliquota_saida", MySqlDbType.Decimal).Value = novoProduto.IpiAliquotaSaida;
            cmd.Parameters.Add("@ipi_entrada", MySqlDbType.VarChar, 10).Value = novoProduto.IpiEntrada;
            cmd.Parameters.Add("@ipi_aliquota_entrada", MySqlDbType.Decimal).Value = novoProduto.IpiAliquotaEntrada;
            cmd.Parameters.Add("@estoque", MySqlDbType.Decimal).Value = novoProduto.Estoque;
            cmd.Parameters.Add("@qnt_embalagem", MySqlDbType.Decimal).Value = novoProduto.QntEmbalagem;
            cmd.Parameters.Add("@estoque_maximo", MySqlDbType.Decimal).Value = novoProduto.EstoqueMaximo;
            cmd.Parameters.Add("@estoque_minimo", MySqlDbType.Decimal).Value = novoProduto.EstoqueMinimo;
            cmd.Parameters.Add("@peso_bruto", MySqlDbType.Decimal).Value = novoProduto.PesoBruto;
            cmd.Parameters.Add("@peso_liquido", MySqlDbType.Decimal).Value = novoProduto.PesoLiquido;
            cmd.Parameters.Add("@data_validade", MySqlDbType.Date).Value = novoProduto.DataValidade;
            cmd.Parameters.Add("@tara", MySqlDbType.Decimal).Value = novoProduto.Tara;
            cmd.Parameters.Add("@local_no_estabelecimento", MySqlDbType.VarChar, 50).Value = novoProduto.LocalNoEstabelecimento;
            cmd.Parameters.Add("@empresa", MySqlDbType.VarChar, 50).Value = novoProduto.Empresa;
            cmd.Parameters.Add("@local_no_estoque", MySqlDbType.VarChar, 50).Value = novoProduto.LocalNoEstoque;
            cmd.Parameters.Add("@saldo", MySqlDbType.Decimal).Value = novoProduto.Saldo;
            cmd.Parameters.Add("@promocao_data_inicial", MySqlDbType.Date).Value = novoProduto.PromocaoDataInicial;
            cmd.Parameters.Add("@promocao_data_final", MySqlDbType.Date).Value = novoProduto.PromocaoDataFinal;
            cmd.Parameters.Add("@valor_promocao", MySqlDbType.Decimal).Value = novoProduto.ValorPromocao;
            cmd.Parameters.Add("@comissao_porcentagem", MySqlDbType.Decimal).Value = novoProduto.ComissaoPorcentagem;
            cmd.Parameters.Add("@comissao_real", MySqlDbType.Decimal).Value = novoProduto.ComissaoReal;
            cmd.Parameters.Add("@pontos", MySqlDbType.Decimal).Value = novoProduto.Pontos;
            cmd.Parameters.Add("@imagem", MySqlDbType.VarChar, 100).Value = novoProduto.Imagem;
            cmd.Parameters.Add("@tipo_lista", MySqlDbType.VarChar, 10).Value = novoProduto.TipoLista;
            cmd.Parameters.Add("@tipo_preco", MySqlDbType.VarChar, 10).Value = novoProduto.TipoPreco;
            cmd.Parameters.Add("@linha", MySqlDbType.VarChar, 20).Value = novoProduto.Linha;
            cmd.Parameters.Add("@portaria", MySqlDbType.VarChar, 20).Value = novoProduto.Portaria;
            cmd.Parameters.Add("@data_vigencia", MySqlDbType.Date).Value = novoProduto.DataVigencia;
            cmd.Parameters.Add("@preco_antigo", MySqlDbType.Decimal).Value = novoProduto.PrecoAntigo;
            cmd.Parameters.Add("@rm_saida", MySqlDbType.VarChar, 10).Value = novoProduto.RmSaida;
            cmd.Parameters.Add("@class_terapeutica", MySqlDbType.VarChar, 50).Value = novoProduto.ClassTerapeutica;
            cmd.Parameters.Add("@un_medida_sngpc", MySqlDbType.VarChar, 20).Value = novoProduto.UnMedidaSngpc;
            cmd.Parameters.Add("@uso_prolongado", MySqlDbType.VarChar, 3).Value = novoProduto.UsoProlongado;
            cmd.Parameters.Add("@precovenda_farmacia_popular", MySqlDbType.Decimal).Value = novoProduto.PrecovendaFarmaciaPopular;
            cmd.Parameters.Add("@margem_farmacia_popular", MySqlDbType.Decimal).Value = novoProduto.MargemFarmaciaPopular;
            cmd.Parameters.Add("@apresentacao_cx", MySqlDbType.Decimal).Value = novoProduto.ApresentacaoCx;
            cmd.Parameters.Add("@codigo_anp", MySqlDbType.VarChar, 10).Value = novoProduto.CodigoAnp;
            cmd.Parameters.Add("@desc_anp", MySqlDbType.VarChar, 100).Value = novoProduto.DescAnp;
            cmd.Parameters.Add("@observacoes", MySqlDbType.VarChar, 255).Value = novoProduto.Observacoes;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar produto: {ex.Message}");
            }
        }
        public void CadastrarEntradaEstoque(EntradaEstoque entradaEstoque)
        {
            cmd = new MySqlCommand("INSERT INTO cadastrar_entrada_estoque (tipo_entrada, local, numero, serie, modelo, natureza, chave_nfe, data_emissao, data_entrada, tipo_frete, codigo_produto, nome_produto, preco_de_compra, quantidade_de_compra, unidades, preco_custo, total, base_calculo_icms, valor_icms, base_calc_icms_st, valor_icms_st, valor_frete, valor_seguro, desconto, outras_despesas, valor_pis, valor_confins, valor_ipi, valor2, valor_total_produtos, valor_total_imposto, valor_total_nota) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", conexao);

            cmd.Parameters.Add("@tipo_entrada", MySqlDbType.VarChar, 20).Value = entradaEstoque.TipoEntrada;
            cmd.Parameters.Add("@local", MySqlDbType.VarChar, 30).Value = entradaEstoque.Local;
            cmd.Parameters.Add("@numero", MySqlDbType.Int32).Value = entradaEstoque.Numero;
            cmd.Parameters.Add("@serie", MySqlDbType.VarChar, 30).Value = entradaEstoque.Serie;
            cmd.Parameters.Add("@modelo", MySqlDbType.VarChar, 40).Value = entradaEstoque.Modelo;
            cmd.Parameters.Add("@natureza", MySqlDbType.VarChar, 20).Value = entradaEstoque.Natureza;
            cmd.Parameters.Add("@chave_nfe", MySqlDbType.Int32).Value = entradaEstoque.ChaveNFe;
            cmd.Parameters.Add("@data_emissao", MySqlDbType.Date).Value = entradaEstoque.DataEmissao;
            cmd.Parameters.Add("@data_entrada", MySqlDbType.Date).Value = entradaEstoque.DataEntrada;
            cmd.Parameters.Add("@tipo_frete", MySqlDbType.VarChar, 30).Value = entradaEstoque.TipoFrete;
            cmd.Parameters.Add("@codigo_produto", MySqlDbType.Int32).Value = entradaEstoque.CodigoProduto;
            cmd.Parameters.Add("@nome_produto", MySqlDbType.VarChar, 50).Value = entradaEstoque.NomeProduto;
            cmd.Parameters.Add("@preco_de_compra", MySqlDbType.Decimal).Value = entradaEstoque.PrecoDeCompra;
            cmd.Parameters.Add("@quantidade_de_compra", MySqlDbType.Decimal).Value = entradaEstoque.QuantidadeDeCompra;
            cmd.Parameters.Add("@unidades", MySqlDbType.VarChar, 10).Value = entradaEstoque.Unidades;
            cmd.Parameters.Add("@preco_custo", MySqlDbType.Decimal).Value = entradaEstoque.PrecoCusto;
            cmd.Parameters.Add("@total", MySqlDbType.Decimal).Value = entradaEstoque.Total;
            cmd.Parameters.Add("@base_calculo_icms", MySqlDbType.Decimal).Value = entradaEstoque.BaseCalculoICMS;
            cmd.Parameters.Add("@valor_icms", MySqlDbType.Decimal).Value = entradaEstoque.ValorICMS;
            cmd.Parameters.Add("@base_calc_icms_st", MySqlDbType.Decimal).Value = entradaEstoque.BaseCalcICMSST;
            cmd.Parameters.Add("@valor_icms_st", MySqlDbType.Decimal).Value = entradaEstoque.ValorICMSST;
            cmd.Parameters.Add("@valor_frete", MySqlDbType.Decimal).Value = entradaEstoque.ValorFrete;
            cmd.Parameters.Add("@valor_seguro", MySqlDbType.Decimal).Value = entradaEstoque.ValorSeguro;
            cmd.Parameters.Add("@desconto", MySqlDbType.Decimal).Value = entradaEstoque.Desconto;
            cmd.Parameters.Add("@outras_despesas", MySqlDbType.Decimal).Value = entradaEstoque.OutrasDespesas;
            cmd.Parameters.Add("@valor_pis", MySqlDbType.Decimal).Value = entradaEstoque.ValorPIS;
            cmd.Parameters.Add("@valor_confins", MySqlDbType.Decimal).Value = entradaEstoque.ValorCOFINS;
            cmd.Parameters.Add("@valor_ipi", MySqlDbType.Decimal).Value = entradaEstoque.ValorIPI;
            cmd.Parameters.Add("@valor2", MySqlDbType.Decimal).Value = entradaEstoque.Valor2;
            cmd.Parameters.Add("@valor_total_produtos", MySqlDbType.Decimal).Value = entradaEstoque.ValorTotalProdutos;
            cmd.Parameters.Add("@valor_total_imposto", MySqlDbType.Decimal).Value = entradaEstoque.ValorTotalImposto;
            cmd.Parameters.Add("@valor_total_nota", MySqlDbType.Decimal).Value = entradaEstoque.ValorTotalNota;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar entrada de estoque: {ex.Message}");
            }
        }
        public void CadastrarLote(CadastrarLote lote)
        {
            cmd = new MySqlCommand("INSERT INTO cadastro_lote(produto, lote, data_validade, data_fabricacao, qnt_inicial) VALUE (?, ?, ?, ?, ?)", conexao);
            cmd.Parameters.Add("@produto", MySqlDbType.VarChar, 30).Value = lote.Produto;
            cmd.Parameters.Add("@lote", MySqlDbType.VarChar, 20).Value = lote.Lote;
            cmd.Parameters.Add("@data_validade", MySqlDbType.DateTime).Value = lote.DataValidade;
            cmd.Parameters.Add("@data_fabricacao", MySqlDbType.DateTime, 30).Value = lote.DataFabricacao;
            cmd.Parameters.Add("@qnt_inicial", MySqlDbType.Int32, 11).Value = lote.QuantidadeInicial;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar lote: {ex.Message}");
            }
        }

        public Funcionarios tipo_usuario(String parametro)
        {
            Funcionarios usuario = new Funcionarios();
            cmd = new MySqlCommand("SELECT cargo FROM funcionarios WHERE usuario = @usuario AND senha = @senha", conexao);
            cmd.Parameters.Add("@usuario", MySqlDbType.VarChar, 15).Value = usuario.usuario;
            cmd.Parameters.Add("@senha", MySqlDbType.VarChar, 8).Value = usuario.senha;
            MySqlDataReader dados = null;
            dados = cmd.ExecuteReader();
            while (dados.Read())
            {
                usuario.cargo = dados.GetString(5);
            }

            return usuario;
        }

        public List<string> MostrarCategorias()
        {
            List<string> categorias = new List<string>();

            using (cmd = new MySqlCommand("SELECT NOME FROM categoria", conexao))
            {
                using (MySqlDataReader dados = cmd.ExecuteReader())
                {
                    while (dados.Read())
                    {
                        categorias.Add(Convert.ToString(dados["NOME"]));
                    }
                }
            }

            return categorias;
        }
        public List<string> MostrarSubcategorias()
        {
            List<string> subcategorias = new List<string>();

            using (cmd = new MySqlCommand("SELECT NOME FROM subcategoria WHERE status = 'ATIVO'", conexao))
            {
                using (MySqlDataReader dados = cmd.ExecuteReader())
                {
                    while (dados.Read())
                    {
                        subcategorias.Add(Convert.ToString(dados["NOME"]));
                    }
                }
            }
            return subcategorias;
        }
        public List<string> MostrarFabricante()
        {
            List<string> fabricante = new List<string>();

            using (cmd = new MySqlCommand("SELECT nome FROM fabricante", conexao))
            {
                using (MySqlDataReader dados = cmd.ExecuteReader())
                {
                    while (dados.Read())
                    {
                        fabricante.Add(Convert.ToString(dados["nome"]));
                    }
                }
            }
            return fabricante;
        }
        public List<string> MostrarFornecedor()
        {
            List<string> fornecedor = new List<string>();

            using (cmd = new MySqlCommand("SELECT nome FROM fornecedor", conexao))
            {
                using (MySqlDataReader dados = cmd.ExecuteReader())
                {
                    while (dados.Read())
                    {
                        fornecedor.Add(Convert.ToString(dados["nome"]));
                    }
                }
            }
            return fornecedor;
        }
        public List<string> MostrarCst()
        {
            List<string> cst = new List<string>();

            using (cmd = new MySqlCommand("SELECT cst FROM cst", conexao))
            {
                using (MySqlDataReader dados = cmd.ExecuteReader())
                {
                    while (dados.Read())
                    {
                        cst.Add(Convert.ToString(dados["cst"]));
                    }
                }
            }
            return cst;
        }
        public List<string> MostrarOrigem()
        {
            List<string> origem = new List<string>();

            using (cmd = new MySqlCommand("SELECT origem FROM origem", conexao))
            {
                using (MySqlDataReader dados = cmd.ExecuteReader())
                {
                    while (dados.Read())
                    {
                        origem.Add(Convert.ToString(dados["origem"]));
                    }
                }
            }
            return origem;
        }
        public List<string> MostrarNcm()
        {
            List<string> ncm = new List<string>();

            using (cmd = new MySqlCommand("SELECT ncm FROM NCM", conexao))
            {
                using (MySqlDataReader dados = cmd.ExecuteReader())
                {
                    while (dados.Read())
                    {
                        ncm.Add(Convert.ToString(dados["NCM"]));
                    }
                }
            }
            return ncm;
        }
        public List<string> MostrarCfop()
        {
            List<string> cfop = new List<string>();

            using (cmd = new MySqlCommand("SELECT cfop FROM CFOP", conexao))
            {
                using (MySqlDataReader dados = cmd.ExecuteReader())
                {
                    while (dados.Read())
                    {
                        cfop.Add(Convert.ToString(dados["CFOP"]));
                    }
                }
            }
            return cfop;
        }
        public List<string> MostrarGeneroProduto()
        {
            List<string> genero = new List<string>();

            using (cmd = new MySqlCommand("SELECT genero FROM genero", conexao))
            {
                using (MySqlDataReader dados = cmd.ExecuteReader())
                {
                    while (dados.Read())
                    {
                        genero.Add(Convert.ToString(dados["genero"]));
                    }
                }
            }
            return genero;
        }
        public List<string> MostrarLocalEstabelecimento()
        {
            List<string> local = new List<string>();

            using (cmd = new MySqlCommand("SELECT local_no_estabelecimento FROM local_estabelecimento", conexao))
            {
                using (MySqlDataReader dados = cmd.ExecuteReader())
                {
                    while (dados.Read())
                    {
                        local.Add(Convert.ToString(dados["local_no_estabelecimento"]));
                    }
                }
            }
            return local;
        }
        public List<string> MostrarLocalEstoque()
        {
            List<string> localestoque = new List<string>();

            using (cmd = new MySqlCommand("SELECT local FROM local_estoque", conexao))
            {
                using (MySqlDataReader dados = cmd.ExecuteReader())
                {
                    while (dados.Read())
                    {
                        localestoque.Add(Convert.ToString(dados["local"]));
                    }
                }
            }
            return localestoque;
        }
        public List<string> MostrarEntradaEstoque()
        {
            List<string> tipoentradaestoque = new List<string>();

            using (cmd = new MySqlCommand("SELECT tipo_entrada FROM tipo_entrada_estoque", conexao))
            {
                using (MySqlDataReader dados = cmd.ExecuteReader())
                {
                    while (dados.Read())
                    {
                        tipoentradaestoque.Add(Convert.ToString(dados["tipo_entrada"]));
                    }
                }
            }
            return tipoentradaestoque;
        }
        public List<string> MostrarTipoProduto()
        {
            List<string> tipoproduto = new List<string>();

            using (cmd = new MySqlCommand("SELECT tipo_produto FROM tipo_produto", conexao))
            {
                using (MySqlDataReader dados = cmd.ExecuteReader())
                {
                    while (dados.Read())
                    {
                        tipoproduto.Add(Convert.ToString(dados["tipo_produto"]));
                    }
                }
            }
            return tipoproduto;
        }
        public List<string> MostrarUnidadeMedida()
        {
            List<string> unidade = new List<string>();

            using (cmd = new MySqlCommand("SELECT unidade_medida FROM unidade", conexao))
            {
                using (MySqlDataReader dados = cmd.ExecuteReader())
                {
                    while (dados.Read())
                    {
                        unidade.Add(Convert.ToString(dados["unidade_medida"]));
                    }
                }
            }
            return unidade;
        }


        // Buscar por change não ta funcionando
        public List<string> BuscarCst(string parametro)
        {
            List<string> buscaCst = new List<string>();

            using (cmd = new MySqlCommand("Select cst FROM cst WHERE cst LIKE '%" + parametro + " % '", conexao))
            {
                using (MySqlDataReader dados = cmd.ExecuteReader())
                {
                    while (dados.Read())
                    {
                        buscaCst.Add(Convert.ToString(dados["cst"]));
                    }
                }
            }
            return buscaCst;
        }

        public bool validar(Logins login)
        {
            bool valor = false;
            cmd = new MySqlCommand("SELECT COUNT(id_funcionarios) FROM funcionarios WHERE usuario = @usuario AND senha = @senha AND cargo = @cargo", conexao);
            cmd.Parameters.Add("@usuario", MySqlDbType.VarChar, 15).Value = login.usuario;
            cmd.Parameters.Add("@senha", MySqlDbType.VarChar, 15).Value = login.senha;
            cmd.Parameters.Add("@cargo", MySqlDbType.VarChar, 15).Value = login.cargo;

            MySqlDataReader dados = null;
            dados = cmd.ExecuteReader();
            dados.Read();
            if (dados.GetString(0) == "0")
            {
                valor = false;
                MessageBox.Show("Senha ou Usuário Incorreto!");
            }
            else
            {
                valor = true;

            }
            return valor;
        }

        public void cadastrar_produto(Produtos novo_produto)
        {
            cmd = new MySqlCommand("INSERT INTO cadastro_produto (descricao, codigo_produto, ncm, unidade_de_medida, quantidade_em_estoque, valor_unitario, aliquota_icms, aliquota_ipi, cest, outras_informacoes, data_cadastro, classificacao_fiscal, codigo_de_barras, origem_produto, cfop, Exigencia_st, modalidade_st, nfe_codigo_barras, nfe_gtin, nfe_cean, nfe_ncm, nfe_cest) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)", conexao);
            cmd.Parameters.Add("@descricao", MySqlDbType.VarChar, 255).Value = novo_produto.descricao;
            cmd.Parameters.Add("@codigo_produto", MySqlDbType.VarChar, 50).Value = novo_produto.cod_produto;
            cmd.Parameters.Add("@ncm", MySqlDbType.VarChar, 8).Value = novo_produto.ncm;
            cmd.Parameters.Add("@unidade_de_medida", MySqlDbType.VarChar, 20).Value = novo_produto.unidade_medida;
            cmd.Parameters.Add("@quantidade_em_estoque", MySqlDbType.Decimal, 10).Value = novo_produto.quant_estoque;
            cmd.Parameters.Add("@valor_unitario", MySqlDbType.Decimal, 10).Value = novo_produto.valor_unit;
            cmd.Parameters.Add("@aliquota_icms", MySqlDbType.Decimal, 5).Value = novo_produto.aliquota_icms;
            cmd.Parameters.Add("@aliquota_ipi", MySqlDbType.Decimal, 5).Value = novo_produto.aliquota_ipi;
            cmd.Parameters.Add("@cest", MySqlDbType.VarChar, 7).Value = novo_produto.cest;
            cmd.Parameters.Add("@outras_informacoes", MySqlDbType.VarChar, 50).Value = novo_produto.outras_info;
            cmd.Parameters.Add("@data_cadastro", MySqlDbType.Date).Value = novo_produto.data_cad;
            cmd.Parameters.Add("@classificacao_fiscal", MySqlDbType.VarChar, 20).Value = novo_produto.classif_fiscal;
            cmd.Parameters.Add("@codigo_de_barras", MySqlDbType.VarChar, 50).Value = novo_produto.cod_barras;
            cmd.Parameters.Add("@origem_produto", MySqlDbType.Int32, 11).Value = novo_produto.origem_produto;
            cmd.Parameters.Add("@cfop", MySqlDbType.Int32, 11).Value = novo_produto.cfop;
            cmd.Parameters.Add("@Exigencia_st", MySqlDbType.Int32, 11).Value = novo_produto.exig_st;
            cmd.Parameters.Add("@modalidade_st", MySqlDbType.Int32, 11).Value = novo_produto.modalidade_st;
            cmd.Parameters.Add("@nfe_codigo_barras", MySqlDbType.VarChar, 50).Value = novo_produto.nfe_cod_barras;
            cmd.Parameters.Add("@nfe_gtin", MySqlDbType.VarChar, 14).Value = novo_produto.nfe_gtin;
            cmd.Parameters.Add("@nfe_cean", MySqlDbType.VarChar, 14).Value = novo_produto.nfe_cean;
            cmd.Parameters.Add("@nfe_ncm", MySqlDbType.VarChar, 8).Value = novo_produto.nfe_ncm;
            cmd.Parameters.Add("@nfe_cest", MySqlDbType.VarChar, 7).Value = novo_produto.nfe_cest;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto cadastrado com sucesso !");
            }
            catch
            {
                Console.WriteLine("Erro ao inserir produto");
                MessageBox.Show("Erro ao cadastrar produto.");
            }

        }
    }
}
