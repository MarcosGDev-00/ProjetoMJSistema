namespace ProjetoSistema
{
    partial class camposPromocaoCadastrarProdutos
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
            this.label9 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cxLocal = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cxDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.dtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cxDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.dtDataInicial = new System.Windows.Forms.DateTimePicker();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.label9.Location = new System.Drawing.Point(24, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 23);
            this.label9.TabIndex = 76;
            this.label9.Text = "Preço da promoção";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.cxLocal);
            this.panel9.Location = new System.Drawing.Point(26, 269);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(557, 50);
            this.panel9.TabIndex = 77;
            // 
            // cxLocal
            // 
            this.cxLocal.BackColor = System.Drawing.Color.White;
            this.cxLocal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cxLocal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxLocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cxLocal.Location = new System.Drawing.Point(16, 13);
            this.cxLocal.Name = "cxLocal";
            this.cxLocal.Size = new System.Drawing.Size(523, 23);
            this.cxLocal.TabIndex = 92;
            this.cxLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cxLocal.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cxLocal_MaskInputRejected);
            this.cxLocal.Click += new System.EventHandler(this.cxLocal_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.label8.Location = new System.Drawing.Point(22, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 23);
            this.label8.TabIndex = 74;
            this.label8.Text = "Data Final";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.cxDataFinal);
            this.panel8.Controls.Add(this.dtDataFinal);
            this.panel8.Location = new System.Drawing.Point(24, 155);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(559, 50);
            this.panel8.TabIndex = 75;
            // 
            // cxDataFinal
            // 
            this.cxDataFinal.BackColor = System.Drawing.Color.White;
            this.cxDataFinal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cxDataFinal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxDataFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cxDataFinal.Location = new System.Drawing.Point(14, 12);
            this.cxDataFinal.Name = "cxDataFinal";
            this.cxDataFinal.Size = new System.Drawing.Size(500, 27);
            this.cxDataFinal.TabIndex = 133;
            this.cxDataFinal.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.cxDataFinal_TypeValidationCompleted);
            this.cxDataFinal.TextChanged += new System.EventHandler(this.cxDataFinal_TextChanged);
            // 
            // dtDataFinal
            // 
            this.dtDataFinal.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.dtDataFinal.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.dtDataFinal.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.dtDataFinal.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.dtDataFinal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDataFinal.Location = new System.Drawing.Point(520, 7);
            this.dtDataFinal.Name = "dtDataFinal";
            this.dtDataFinal.Size = new System.Drawing.Size(20, 34);
            this.dtDataFinal.TabIndex = 1;
            this.dtDataFinal.ValueChanged += new System.EventHandler(this.dtDataFinal_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.label2.Location = new System.Drawing.Point(22, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 72;
            this.label2.Text = "Data Inicial";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.cxDataInicial);
            this.panel6.Controls.Add(this.dtDataInicial);
            this.panel6.Location = new System.Drawing.Point(24, 45);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(559, 50);
            this.panel6.TabIndex = 130;
            // 
            // cxDataInicial
            // 
            this.cxDataInicial.BackColor = System.Drawing.Color.White;
            this.cxDataInicial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cxDataInicial.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cxDataInicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cxDataInicial.Location = new System.Drawing.Point(14, 7);
            this.cxDataInicial.Name = "cxDataInicial";
            this.cxDataInicial.Size = new System.Drawing.Size(500, 27);
            this.cxDataInicial.TabIndex = 132;
            this.cxDataInicial.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cxDataInicial_MaskInputRejected);
            this.cxDataInicial.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.cxDataInicial_TypeValidationCompleted);
            this.cxDataInicial.TextChanged += new System.EventHandler(this.cxDataInicial_TextChanged);
            // 
            // dtDataInicial
            // 
            this.dtDataInicial.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.dtDataInicial.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.dtDataInicial.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.dtDataInicial.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.dtDataInicial.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtDataInicial.Location = new System.Drawing.Point(520, 7);
            this.dtDataInicial.Name = "dtDataInicial";
            this.dtDataInicial.Size = new System.Drawing.Size(20, 34);
            this.dtDataInicial.TabIndex = 0;
            this.dtDataInicial.ValueChanged += new System.EventHandler(this.dtDataInicial_ValueChanged);
            // 
            // camposPromocaoCadastrarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1435, 483);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label2);
            this.Name = "camposPromocaoCadastrarProdutos";
            this.Text = "camposPromocaoCadastrarProdutos";
            this.Load += new System.EventHandler(this.camposPromocaoCadastrarProdutos_Load);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDataFinal;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.MaskedTextBox cxDataInicial;
        private System.Windows.Forms.DateTimePicker dtDataInicial;
        private System.Windows.Forms.MaskedTextBox cxDataFinal;
        private System.Windows.Forms.MaskedTextBox cxLocal;
    }
}