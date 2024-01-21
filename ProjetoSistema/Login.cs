using MySqlX.XDevAPI;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.ShowDialog();
        }

        
        public static class Sessao
        {
            public static string Usuario;
            public static DateTime Expiracao;

            public static void IniciarSessao(string usuario, int minutosExpiracao = 30)
            {
                Usuario = usuario;
                Expiracao = DateTime.Now.AddMinutes(minutosExpiracao);
            }

            public static bool SessaoExpirada()
            {
                bool expirada = DateTime.Now > Expiracao;
                Console.WriteLine($"A sessão expirou: {expirada}");
                return expirada;
            }
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            banco.conectar();

            Logins login = new Logins();
            login.usuario = cxUsuario.Text;
            login.senha = cxSenha.Text;
            login.cargo = cxCargo.Text;

            bool sucesso = banco.validar(login);

            if (!sucesso)
            {
                MessageBox.Show("Senha ou usuário incorretos!");
            }
            else
            {

                Sessao.IniciarSessao(login.usuario, 30);
                MessageBox.Show("Login realizado com sucesso");
                switch (login.cargo)
                {
                    case "Operador de Caixa":
                        {
                            this.Hide();
                            //busca_cliente busca_Cliente = new busca_cliente();
                            //busca_Cliente.ShowDialog();
                        }
                        break;
                    case "Administrador":
                        {
                            this.Hide();
                            Home home = new Home();
                            home.ShowDialog();
                        }
                        break;
                    case "Conferente de Estoque":
                        {
                            this.Hide();
                            //Form1 form1 = new Form1();
                            //form1.ShowDialog();
                        }
                        break;
                    default:
                        {
                            MessageBox.Show("Login ou senha incorretos");
                        }
                        break;
                }

                cxCargo.Text = "";
                cxSenha.Text = "";
                cxUsuario.Text = "";

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
