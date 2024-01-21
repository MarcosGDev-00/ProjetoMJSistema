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

        private int alturaDesejada = 0;
        private Panel panelMenuExpand = new Panel();

        private Timer cadTimer;

        public Home()
        {
            InitializeComponent();
            InitializeControls();
            // menuExpansivel();

            this.FormClosing += Home_FormClosing;

            this.Load += Home_Load;

            timerSessao = new Timer();
            timerSessao.Interval = 1000;
            timerSessao.Tick += TimerSessao_Tick;
            timerSessao.Start();

            cadTimer = new Timer();
            cadTimer.Interval = 3;
            cadTimer.Tick += cadTimer_Tick;

        }

        private void Home_Load(object sender, EventArgs e)
        {
            VerificarSessaoExpirada();

            timerTrans.Interval = 10;
            timerTrans.Tick += timerTrans_Tick;
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
        }

        /*
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
        */


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

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerSessao.Stop();
        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuExpand_Tick(object sender, EventArgs e)
        {
            
        }

        bool menuExpand = false;

        private void timerTrans_Tick(object sender, EventArgs e)
        {
            
        }

        private void cadTimer_Tick(object sender, EventArgs e)
        {
            cadTimer.Start();

            if (menuExpand == false)
            {
                panelMenuExpand.Height += 20;
                if (panelMenuExpand.Height >= alturaDesejada)
                {
                    cadTimer.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                panelMenuExpand.Height -= 20;
                if (panelMenuExpand.Height <= 75)
                {
                    cadTimer.Stop();
                    menuExpand = false;
                }
            }
        }

        private void btnCadastro_Click_9(object sender, EventArgs e)
        {
            ActivateButton(sender, Cores.RGBColors.color1);
            panelMenuExpand = menuContainerCadastro;
            alturaDesejada = 750;
            cadTimer.Start();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new Base());
            ActivateButton(sender, Cores.RGBColors.color1);
        }

        private void btnClientes_Click_3(object sender, EventArgs e)
        {
            ActivateButton(sender, Cores.RGBColors.color1);
        }

        private void btnProdutos_Click_3(object sender, EventArgs e)
        {
            ActivateButton(sender, Cores.RGBColors.color1);
        }

        private void btnEstoque_Click_3(object sender, EventArgs e)
        {
            ActivateButton(sender, Cores.RGBColors.color1);
            panelMenuExpand = menuContainerEstoque;
            alturaDesejada = 300;
            cadTimer.Start();
        }

        private void btnAdm_Click_3(object sender, EventArgs e)
        {
            ActivateButton(sender, Cores.RGBColors.color1);
        }

        private void btnVendas_Click_3(object sender, EventArgs e)
        {
            ActivateButton(sender, Cores.RGBColors.color1);
        }

        private void btnSair_Click_3(object sender, EventArgs e)
        {
            ExitButton(sender, Cores.RGBColors.color1);
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new TelaClientes());
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new TelaProdutos());
        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new TelaFornecedor());
        }

        private void iconButton5_Click_1(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new TelaFabricante());
        }

        private void iconButton6_Click_1(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new TelaCategoria());
        }

        private void iconButton7_Click_1(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new TelaSubCategoria());
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            exibirFormFilhoNoPanel(new TelaEstoque());
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            flowLayoutPanel1.HorizontalScroll.Enabled = false;
            flowLayoutPanel1.VerticalScroll.Enabled = true;
        }

        private void menuContainerEstoque_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
