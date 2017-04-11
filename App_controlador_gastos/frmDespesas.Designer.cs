namespace App_controlador_gastos
{
    partial class frmDespesas
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
            this.components = new System.ComponentModel.Container();
            this.cmbTipoDespesa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.lblAlterar = new System.Windows.Forms.ToolStrip();
            this.lblNovo = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.lblAlterar1 = new System.Windows.Forms.ToolStripLabel();
            this.lblExcluir = new System.Windows.Forms.ToolStripLabel();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.dt_Pagamento = new System.Windows.Forms.DateTimePicker();
            this.dt_Vencimento = new System.Windows.Forms.DateTimePicker();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ttpID = new System.Windows.Forms.ToolTip(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblAlterar.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTipoDespesa
            // 
            this.cmbTipoDespesa.FormattingEnabled = true;
            this.cmbTipoDespesa.Location = new System.Drawing.Point(133, 95);
            this.cmbTipoDespesa.Name = "cmbTipoDespesa";
            this.cmbTipoDespesa.Size = new System.Drawing.Size(217, 21);
            this.cmbTipoDespesa.TabIndex = 91;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "Tipo Despesa     : ";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(364, 319);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 78;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(99, 319);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 76;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblAlterar
            // 
            this.lblAlterar.BackColor = System.Drawing.SystemColors.Control;
            this.lblAlterar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNovo,
            this.toolStripLabel3,
            this.lblAlterar1,
            this.lblExcluir});
            this.lblAlterar.Location = new System.Drawing.Point(0, 0);
            this.lblAlterar.Name = "lblAlterar";
            this.lblAlterar.Size = new System.Drawing.Size(562, 25);
            this.lblAlterar.TabIndex = 89;
            this.lblAlterar.Text = "Alterar";
            // 
            // lblNovo
            // 
            this.lblNovo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovo.Name = "lblNovo";
            this.lblNovo.Size = new System.Drawing.Size(41, 22);
            this.lblNovo.Text = "Novo";
            this.lblNovo.ToolTipText = "Novo";
            this.lblNovo.Click += new System.EventHandler(this.lblNovo_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(0, 22);
            // 
            // lblAlterar1
            // 
            this.lblAlterar1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAlterar1.Name = "lblAlterar1";
            this.lblAlterar1.Size = new System.Drawing.Size(49, 22);
            this.lblAlterar1.Text = "Alterar";
            this.lblAlterar1.ToolTipText = "Alterar";
            this.lblAlterar1.Click += new System.EventHandler(this.lblAlterar1_Click_1);
            // 
            // lblExcluir
            // 
            this.lblExcluir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Size = new System.Drawing.Size(47, 22);
            this.lblExcluir.Text = "Excluir";
            this.lblExcluir.ToolTipText = "Excluir";
            this.lblExcluir.Click += new System.EventHandler(this.lblExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(232, 319);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 77;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(65, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(9, 12);
            this.label9.TabIndex = 87;
            this.label9.Text = "*";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(111, 57);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(79, 20);
            this.txtID.TabIndex = 69;
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 86;
            this.label1.Text = "Código   :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(81, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(9, 12);
            this.label10.TabIndex = 85;
            this.label10.Text = "*";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(25, 277);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(493, 20);
            this.txtObservacao.TabIndex = 75;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(121, 205);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(120, 20);
            this.txtTotalPagar.TabIndex = 74;
            this.txtTotalPagar.Text = "0,00";
            this.txtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dt_Pagamento
            // 
            this.dt_Pagamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_Pagamento.Location = new System.Drawing.Point(384, 163);
            this.dt_Pagamento.Name = "dt_Pagamento";
            this.dt_Pagamento.Size = new System.Drawing.Size(120, 20);
            this.dt_Pagamento.TabIndex = 73;
            // 
            // dt_Vencimento
            // 
            this.dt_Vencimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_Vencimento.Location = new System.Drawing.Point(136, 163);
            this.dt_Vencimento.Name = "dt_Vencimento";
            this.dt_Vencimento.Size = new System.Drawing.Size(105, 20);
            this.dt_Vencimento.TabIndex = 72;
            // 
            // txtJuros
            // 
            this.txtJuros.Location = new System.Drawing.Point(384, 130);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(120, 20);
            this.txtJuros.TabIndex = 71;
            this.txtJuros.Text = "0,00";
            this.txtJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtJuros.TextChanged += new System.EventHandler(this.txtJuros_TextChanged);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(111, 130);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(130, 20);
            this.txtValor.TabIndex = 70;
            this.txtValor.Text = "0,00";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 84;
            this.label8.Text = "Observação:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 83;
            this.label7.Text = "Total Pago R$:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(273, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 82;
            this.label6.Text = "Juros R$:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(273, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "Data Pagamento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "Data Vencimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 79;
            this.label3.Text = "Valor R$   :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(111, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(9, 12);
            this.label11.TabIndex = 92;
            this.label11.Text = "*";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(207, 54);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 93;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(562, 350);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbTipoDespesa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.lblAlterar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.dt_Pagamento);
            this.Controls.Add(this.dt_Vencimento);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDespesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despesas";
            this.Load += new System.EventHandler(this.frmDespesas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDespesas_KeyDown);
            this.lblAlterar.ResumeLayout(false);
            this.lblAlterar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoDespesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.ToolStrip lblAlterar;
        private System.Windows.Forms.ToolStripLabel lblNovo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.DateTimePicker dt_Pagamento;
        private System.Windows.Forms.DateTimePicker dt_Vencimento;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripLabel lblAlterar1;
        private System.Windows.Forms.ToolStripLabel lblExcluir;
        private System.Windows.Forms.ToolTip ttpID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnPesquisar;
    }
}

