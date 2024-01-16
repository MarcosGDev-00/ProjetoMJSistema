namespace ProjetoSistema
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cxCargo = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cxSenha = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cxUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconPictureBoxCargo = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBoxSenha = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBoxUsuario = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            this.lblLogin.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(217)))), ((int)(((byte)(189)))));
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(833, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 725);
            this.panel1.TabIndex = 1;
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.lblLogin.Controls.Add(this.btnLogin);
            this.lblLogin.Controls.Add(this.label4);
            this.lblLogin.Controls.Add(this.panel4);
            this.lblLogin.Controls.Add(this.panel3);
            this.lblLogin.Controls.Add(this.panel2);
            this.lblLogin.Controls.Add(this.label3);
            this.lblLogin.Controls.Add(this.label2);
            this.lblLogin.Controls.Add(this.label1);
            this.lblLogin.Location = new System.Drawing.Point(204, 79);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(442, 550);
            this.lblLogin.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(166)))), ((int)(((byte)(134)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogin.Location = new System.Drawing.Point(44, 451);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(353, 59);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(40, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cargo";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.cxCargo);
            this.panel4.Location = new System.Drawing.Point(44, 360);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(352, 50);
            this.panel4.TabIndex = 13;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.panel7.Controls.Add(this.iconPictureBoxCargo);
            this.panel7.Location = new System.Drawing.Point(-1, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(60, 50);
            this.panel7.TabIndex = 12;
            // 
            // cxCargo
            // 
            this.cxCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.cxCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cxCargo.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.cxCargo.ForeColor = System.Drawing.Color.Gainsboro;
            this.cxCargo.FormattingEnabled = true;
            this.cxCargo.Items.AddRange(new object[] {
            "Selecione",
            "Funcionário",
            "Administrador"});
            this.cxCargo.Location = new System.Drawing.Point(65, 9);
            this.cxCargo.Name = "cxCargo";
            this.cxCargo.Size = new System.Drawing.Size(286, 38);
            this.cxCargo.TabIndex = 11;
            this.cxCargo.Text = "Selecione";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.cxSenha);
            this.panel3.Location = new System.Drawing.Point(44, 267);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 50);
            this.panel3.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.panel6.Controls.Add(this.iconPictureBoxSenha);
            this.panel6.Location = new System.Drawing.Point(-2, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(60, 49);
            this.panel6.TabIndex = 11;
            // 
            // cxSenha
            // 
            this.cxSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.cxSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cxSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.cxSenha.ForeColor = System.Drawing.Color.Gainsboro;
            this.cxSenha.Location = new System.Drawing.Point(64, 12);
            this.cxSenha.Name = "cxSenha";
            this.cxSenha.PasswordChar = '*';
            this.cxSenha.Size = new System.Drawing.Size(260, 29);
            this.cxSenha.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.cxUsuario);
            this.panel2.Location = new System.Drawing.Point(44, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 50);
            this.panel2.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.panel5.Controls.Add(this.iconPictureBoxUsuario);
            this.panel5.Location = new System.Drawing.Point(-2, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(60, 50);
            this.panel5.TabIndex = 10;
            // 
            // cxUsuario
            // 
            this.cxUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.cxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cxUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.cxUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.cxUsuario.Location = new System.Drawing.Point(64, 13);
            this.cxUsuario.Name = "cxUsuario";
            this.cxUsuario.Size = new System.Drawing.Size(260, 29);
            this.cxUsuario.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(39, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(40, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(130, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::ProjetoSistema.Properties.Resources.coroaIcon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(838, 725);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // iconPictureBoxCargo
            // 
            this.iconPictureBoxCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.iconPictureBoxCargo.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBoxCargo.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.iconPictureBoxCargo.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBoxCargo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxCargo.IconSize = 47;
            this.iconPictureBoxCargo.Location = new System.Drawing.Point(7, 5);
            this.iconPictureBoxCargo.Name = "iconPictureBoxCargo";
            this.iconPictureBoxCargo.Size = new System.Drawing.Size(52, 47);
            this.iconPictureBoxCargo.TabIndex = 17;
            this.iconPictureBoxCargo.TabStop = false;
            // 
            // iconPictureBoxSenha
            // 
            this.iconPictureBoxSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.iconPictureBoxSenha.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBoxSenha.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBoxSenha.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBoxSenha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxSenha.IconSize = 48;
            this.iconPictureBoxSenha.Location = new System.Drawing.Point(8, 5);
            this.iconPictureBoxSenha.Name = "iconPictureBoxSenha";
            this.iconPictureBoxSenha.Size = new System.Drawing.Size(48, 48);
            this.iconPictureBoxSenha.TabIndex = 16;
            this.iconPictureBoxSenha.TabStop = false;
            // 
            // iconPictureBoxUsuario
            // 
            this.iconPictureBoxUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.iconPictureBoxUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBoxUsuario.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBoxUsuario.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBoxUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxUsuario.IconSize = 48;
            this.iconPictureBoxUsuario.Location = new System.Drawing.Point(8, 5);
            this.iconPictureBoxUsuario.Name = "iconPictureBoxUsuario";
            this.iconPictureBoxUsuario.Size = new System.Drawing.Size(48, 48);
            this.iconPictureBoxUsuario.TabIndex = 15;
            this.iconPictureBoxUsuario.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 725);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.lblLogin.ResumeLayout(false);
            this.lblLogin.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel lblLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox cxSenha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox cxUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cxCargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxCargo;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxSenha;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxUsuario;
    }
}

