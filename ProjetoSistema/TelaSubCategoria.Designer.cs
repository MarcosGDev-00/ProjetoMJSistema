namespace ProjetoSistema
{
    partial class TelaSubCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSubCategoria = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dataGridViewBuscarProdutos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cxPesquisarProduto = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cxCategoriaPesquisarPrduto = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBoxUsuario = new FontAwesome.Sharp.IconPictureBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnNovoProduto = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panelSubCategoria.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscarProdutos)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Selecione",
            "Funcionário",
            "Administrador"});
            this.comboBox1.Location = new System.Drawing.Point(17, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(317, 31);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Text = "Selecione";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(741, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 50);
            this.panel1.TabIndex = 15;
            // 
            // panelSubCategoria
            // 
            this.panelSubCategoria.BackColor = System.Drawing.Color.White;
            this.panelSubCategoria.Controls.Add(this.panel9);
            this.panelSubCategoria.Controls.Add(this.label4);
            this.panelSubCategoria.Controls.Add(this.button1);
            this.panelSubCategoria.Controls.Add(this.panel3);
            this.panelSubCategoria.Location = new System.Drawing.Point(16, 182);
            this.panelSubCategoria.Name = "panelSubCategoria";
            this.panelSubCategoria.Padding = new System.Windows.Forms.Padding(30);
            this.panelSubCategoria.Size = new System.Drawing.Size(1536, 729);
            this.panelSubCategoria.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.dataGridViewBuscarProdutos);
            this.panel9.Location = new System.Drawing.Point(40, 360);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1463, 336);
            this.panel9.TabIndex = 16;
            // 
            // dataGridViewBuscarProdutos
            // 
            this.dataGridViewBuscarProdutos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBuscarProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBuscarProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBuscarProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBuscarProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBuscarProdutos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBuscarProdutos.Name = "dataGridViewBuscarProdutos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBuscarProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBuscarProdutos.RowHeadersWidth = 51;
            this.dataGridViewBuscarProdutos.RowTemplate.Height = 24;
            this.dataGridViewBuscarProdutos.Size = new System.Drawing.Size(1461, 334);
            this.dataGridViewBuscarProdutos.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.label4.Location = new System.Drawing.Point(33, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(402, 38);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tabela de Subcategorias";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.button1.Location = new System.Drawing.Point(34, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 51);
            this.button1.TabIndex = 14;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(33, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1473, 77);
            this.panel3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.label5.Location = new System.Drawing.Point(737, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Status";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.cxPesquisarProduto);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(0, 27);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(352, 50);
            this.panel5.TabIndex = 13;
            // 
            // cxPesquisarProduto
            // 
            this.cxPesquisarProduto.BackColor = System.Drawing.Color.White;
            this.cxPesquisarProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cxPesquisarProduto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxPesquisarProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cxPesquisarProduto.Location = new System.Drawing.Point(64, 13);
            this.cxPesquisarProduto.Name = "cxPesquisarProduto";
            this.cxPesquisarProduto.Size = new System.Drawing.Size(260, 23);
            this.cxPesquisarProduto.TabIndex = 11;
            this.cxPesquisarProduto.Text = "Pesquisar...";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.iconPictureBoxUsuario);
            this.panel6.Location = new System.Drawing.Point(-2, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(60, 50);
            this.panel6.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.label2.Location = new System.Drawing.Point(-4, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.label1.Location = new System.Drawing.Point(368, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Código";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cxCategoriaPesquisarPrduto);
            this.panel4.Location = new System.Drawing.Point(370, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(352, 50);
            this.panel4.TabIndex = 14;
            // 
            // cxCategoriaPesquisarPrduto
            // 
            this.cxCategoriaPesquisarPrduto.BackColor = System.Drawing.Color.White;
            this.cxCategoriaPesquisarPrduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cxCategoriaPesquisarPrduto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxCategoriaPesquisarPrduto.ForeColor = System.Drawing.Color.Gainsboro;
            this.cxCategoriaPesquisarPrduto.Location = new System.Drawing.Point(10, 13);
            this.cxCategoriaPesquisarPrduto.Name = "cxCategoriaPesquisarPrduto";
            this.cxCategoriaPesquisarPrduto.Size = new System.Drawing.Size(327, 23);
            this.cxCategoriaPesquisarPrduto.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconButton3);
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.btnNovoProduto);
            this.panel2.Location = new System.Drawing.Point(48, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1504, 77);
            this.panel2.TabIndex = 5;
            // 
            // iconPictureBoxUsuario
            // 
            this.iconPictureBoxUsuario.BackColor = System.Drawing.Color.White;
            this.iconPictureBoxUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.iconPictureBoxUsuario.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconPictureBoxUsuario.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.iconPictureBoxUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxUsuario.IconSize = 30;
            this.iconPictureBoxUsuario.Location = new System.Drawing.Point(14, 9);
            this.iconPictureBoxUsuario.Name = "iconPictureBoxUsuario";
            this.iconPictureBoxUsuario.Size = new System.Drawing.Size(30, 32);
            this.iconPictureBoxUsuario.TabIndex = 15;
            this.iconPictureBoxUsuario.TabStop = false;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton3.IconSize = 30;
            this.iconButton3.Location = new System.Drawing.Point(858, 0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(267, 77);
            this.iconButton3.TabIndex = 3;
            this.iconButton3.Text = "Atualizar";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(572, 0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(267, 77);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.Text = "Buscar";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(286, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(267, 77);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Importação";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(162)))));
            this.btnNovoProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoProduto.FlatAppearance.BorderSize = 0;
            this.btnNovoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoProduto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoProduto.ForeColor = System.Drawing.Color.White;
            this.btnNovoProduto.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnNovoProduto.IconColor = System.Drawing.Color.White;
            this.btnNovoProduto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnNovoProduto.IconSize = 30;
            this.btnNovoProduto.Location = new System.Drawing.Point(0, 0);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(267, 77);
            this.btnNovoProduto.TabIndex = 0;
            this.btnNovoProduto.Text = "Nova Subcategoria";
            this.btnNovoProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovoProduto.UseVisualStyleBackColor = false;
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // TelaSubCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1568, 988);
            this.Controls.Add(this.panelSubCategoria);
            this.Controls.Add(this.panel2);
            this.Name = "TelaSubCategoria";
            this.Text = "TelaSubCategoria";
            this.panel1.ResumeLayout(false);
            this.panelSubCategoria.ResumeLayout(false);
            this.panelSubCategoria.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscarProdutos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBoxUsuario;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSubCategoria;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView dataGridViewBuscarProdutos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox cxPesquisarProduto;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox cxCategoriaPesquisarPrduto;
        private FontAwesome.Sharp.IconButton btnNovoProduto;
        private System.Windows.Forms.Panel panel2;
    }
}