namespace ProjetoSistema
{
    partial class CadastrarTipoProduto
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cxCategoriaPesquisarPrduto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.label2.Location = new System.Drawing.Point(10, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 86;
            this.label2.Text = "Tipo Produto";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cxCategoriaPesquisarPrduto);
            this.panel4.Location = new System.Drawing.Point(12, 147);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1166, 50);
            this.panel4.TabIndex = 87;
            // 
            // cxCategoriaPesquisarPrduto
            // 
            this.cxCategoriaPesquisarPrduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(217)))), ((int)(((byte)(189)))));
            this.cxCategoriaPesquisarPrduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cxCategoriaPesquisarPrduto.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxCategoriaPesquisarPrduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cxCategoriaPesquisarPrduto.Location = new System.Drawing.Point(22, 13);
            this.cxCategoriaPesquisarPrduto.Name = "cxCategoriaPesquisarPrduto";
            this.cxCategoriaPesquisarPrduto.Size = new System.Drawing.Size(1124, 23);
            this.cxCategoriaPesquisarPrduto.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(1006, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 58);
            this.button1.TabIndex = 88;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.label1.Location = new System.Drawing.Point(406, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 46);
            this.label1.TabIndex = 89;
            this.label1.Text = "Cadastrar Tipo de Produto";
            // 
            // CadastrarTipoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(217)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1190, 310);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Name = "CadastrarTipoProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarTipoProduto";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox cxCategoriaPesquisarPrduto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}