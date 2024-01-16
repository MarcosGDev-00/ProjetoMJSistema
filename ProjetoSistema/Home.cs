using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using static ProjetoSistema.Login;

namespace ProjetoSistema
{
    public partial class Home : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private IconButton IconCurrentForm;

        private Timer timerSessao;

        public Home()
        {
            InitializeComponent();
            InitializeControls();
            menuExpansivel();

            this.FormClosing += Home_FormClosing;

            this.Load += Home_Load;

            timerSessao = new Timer();
            timerSessao.Interval = 1000;
            timerSessao.Tick += TimerSessao_Tick;
            timerSessao.Start();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            VerificarSessaoExpirada();
        }

        private void TimerSessao_Tick(object sender, EventArgs e)
        {
            VerificarSessaoExpirada();
        }

        private void VerificarSessaoExpirada()
        {
            if (Sessao.SessaoExpirada())
            {
                timerSessao.Stop();
                MessageBox.Show("Sessão expirada. Redirecionando para a tela de login.");
                Console.WriteLine("Sessão expirada. Redirecionando para a tela de login.");

                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                this.Close();

            }
            else
            {
                AtualizarDadosSessao();
                Console.WriteLine("Sessão ativa. Continuando com a verificação periódica.");
            }
        }

        private void AtualizarDadosSessao()
        {
            lblUser.Text = Sessao.Usuario;

        }

        // Método para inicializar controles necessários
        private void InitializeControls()
        {
            currentBtn = new IconButton();
            leftBorderBtn = new Panel();
            IconCurrentForm = new IconButton();

            // Adicione os controles ao formulário ou ao controle de contêiner apropriado
            this.Controls.Add(currentBtn);
            this.Controls.Add(leftBorderBtn);
            this.Controls.Add(IconCurrentForm);
        }

        // Método para ativar um botão com efeitos visuais personalizados
        private void ActivateButton(object senderBtn, Color customColor)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;

                currentBtn.BackColor = Color.FromArgb(1, 60, 60);
                currentBtn.ForeColor = customColor;
                currentBtn.IconColor = customColor;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;

                leftBorderBtn.BackColor = customColor;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                leftBorderBtn.Size = new Size(5, 60);

                lblTitleHeader.Text = currentBtn.Text;
                iconTitleHeader.IconChar = currentBtn.IconChar;
                iconTitleHeader.IconColor = customColor;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(2, 89, 89);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }

        private void ExitButton(object senderBtn, Color customColor)
        {
            iconTitleHeader.IconColor = customColor;

            DisableButton();
            currentBtn = (IconButton)senderBtn;

            currentBtn.BackColor = Color.FromArgb(1, 60, 60);
            currentBtn.ForeColor = customColor;
            currentBtn.IconColor = customColor;
            currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;

            leftBorderBtn.BackColor = customColor;
            leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
            leftBorderBtn.Visible = true;
            leftBorderBtn.BringToFront();
            leftBorderBtn.Size = new Size(5, 60);
        }

        private void menuExpansivel()
        {
            panelSubmenu.Visible = false;
            // ...
        }

        private void ocultarSubmenu()
        {
            if (panelSubmenu.Visible == true)
                panelSubmenu.Visible = false;
            //...
        }

        private void exibirSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


        public Form formAtivo = null;
        public void exibirFormFilhoNoPanel(Form exibirForm)
        {
            if (formAtivo != null)
                formAtivo.Close();
            formAtivo = exibirForm;
            exibirForm.TopLevel = false;
            exibirForm.FormBorderStyle = FormBorderStyle.None;
            exibirForm.Dock = DockStyle.Fill;
            panelHome.Controls.Add(exibirForm);
            panelHome.Tag = exibirForm;
            exibirForm.BringToFront();
            exibirForm.Show();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Cores.RGBColors.color1);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Cores.RGBColors.color1);
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Cores.RGBColors.color1);
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Cores.RGBColors.color1);
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Cores.RGBColors.color1);
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Cores.RGBColors.color1);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            ExitButton(sender, Cores.RGBColors.color1);
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerSessao.Stop();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new Base());
            ActivateButton(sender, Cores.RGBColors.color1);
        }

        private void btnCadastro_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, Cores.RGBColors.color1);
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, Cores.RGBColors.color1);
        }

        private void btnVendas_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, Cores.RGBColors.color1);
        }

        private void btnAdm_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, Cores.RGBColors.color1);
        }

        private void btnEstoque_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, Cores.RGBColors.color1);
        }

        private void btnProdutos_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, Cores.RGBColors.color1);
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            ExitButton(sender, Cores.RGBColors.color1);
        }

        private void btnCadastro_Click_2(object sender, EventArgs e)
        {
            exibirSubMenu(panelSubmenu);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
           
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new TelaProdutos());
            
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            
        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClientes_Click_2(object sender, EventArgs e)
        {
            ActivateButton(sender, Cores.RGBColors.color1);
        }

        private void btnVendas_Click_2(object sender, EventArgs e)
        {
            ActivateButton(sender, Cores.RGBColors.color1);
        }

        private void btnAdm_Click_2(object sender, EventArgs e)
        {
            ActivateButton(sender, Cores.RGBColors.color1);
        }

        private void btnEstoque_Click_2(object sender, EventArgs e)
        {
            ActivateButton(sender, Cores.RGBColors.color1);
        }

        private void btnProdutos_Click_2(object sender, EventArgs e)
        {
            ActivateButton(sender, Cores.RGBColors.color1);
        }

        private void btnSair_Click_2(object sender, EventArgs e)
        {
            ExitButton(sender, Cores.RGBColors.color1);
        }
    }
}
