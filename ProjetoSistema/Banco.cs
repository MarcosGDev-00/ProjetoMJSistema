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


        public void inserir_cliente(Clientes novo_cliente)
        {
            cmd = new MySqlCommand("INSERT INTO cliente (nome, email, contato, endereco, sexo, cpf) VALUES (?,?,?,?,?,?)", conexao);
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = novo_cliente.nome;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar, 50).Value = novo_cliente.email;
            cmd.Parameters.Add("@contato", MySqlDbType.VarChar, 15).Value = novo_cliente.contato;
            cmd.Parameters.Add("@endereco", MySqlDbType.VarChar, 50).Value = novo_cliente.endereco;
            cmd.Parameters.Add("@sexo", MySqlDbType.VarChar, 15).Value = novo_cliente.sexo;
            cmd.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = novo_cliente.cpf;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            catch
            {
                Console.WriteLine("Erro ao inserir cliente");
                MessageBox.Show("Erro ao cadastrar cliente.");
            }

        }
        public void inserir_funcionario(Funcionarios novo_funcionario)
        {
            cmd = new MySqlCommand("INSERT INTO funcionarios (nome, usuario, senha, cpf, cargo, telefone, endereco, email, numero_identificacao, data_nascimento, sexo) VALUES (?,?,?,?,?,?,?,?,?,?,?)", conexao);
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = novo_funcionario.nome;
            cmd.Parameters.Add("@usuario", MySqlDbType.VarChar, 15).Value = novo_funcionario.usuario;
            cmd.Parameters.Add("@senha", MySqlDbType.VarChar, 8).Value = novo_funcionario.senha;
            cmd.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = novo_funcionario.cpf;
            cmd.Parameters.Add("@cargo", MySqlDbType.VarChar, 20).Value = novo_funcionario.cargo;
            cmd.Parameters.Add("@telefone", MySqlDbType.VarChar, 14).Value = novo_funcionario.telefone;
            cmd.Parameters.Add("@endereco", MySqlDbType.VarChar, 50).Value = novo_funcionario.endereco;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar, 50).Value = novo_funcionario.email;
            cmd.Parameters.Add("@numero_identificacao", MySqlDbType.VarChar, 7).Value = novo_funcionario.nId;
            cmd.Parameters.Add("@data_nascimento", MySqlDbType.Date).Value = novo_funcionario.dataNasc;
            cmd.Parameters.Add("@sexo", MySqlDbType.VarChar, 15).Value = novo_funcionario.sexo;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionário cadastrado com sucesso!");
            }
            catch
            {
                Console.WriteLine("Erro ao inserir funcionário");
                MessageBox.Show("Erro ao cadastrar funcionário.");
            }
        }
        public void verificar_cadastro(Funcionarios funcionario)
        {
            cmd = new MySqlCommand("SELECT COUNT(*) AS quantidade FROM funcionarios WHERE usuario = @usuario", conexao);
            cmd.Parameters.Add("@usuario", MySqlDbType.VarChar, 15).Value = funcionario.usuario;
            MySqlDataReader dados = null;
            dados = cmd.ExecuteReader();
            dados.Read();
            if (dados.GetString(0) == "0")
            {
                this.inserir_funcionario(funcionario);
                MessageBox.Show("Usuario cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro. O Usuario já possui um Cadastro!");
            }

        }
        public bool valor_booleano()
        {

            return true;
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
        public DataTable buscar_lista_clientes(string id)
        {
            cmd = new MySqlCommand("Select * From cliente WHERE nome LIKE '%" + id + "%'", conexao);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);


            return dataTable;
        }

        public DataTable buscar_tabela_de_funcionario(string nome)
        {
            cmd = new MySqlCommand("Select * From funcionarios WHERE nome LIKE '%" + nome + "%'", conexao);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }
    }
}
