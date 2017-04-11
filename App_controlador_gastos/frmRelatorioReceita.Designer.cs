namespace App_controlador_gastos
{
    partial class frmRelatorioReceita
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
            this.rdbTipoReceita = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.rdbValorReceita = new System.Windows.Forms.RadioButton();
            this.rdbDt_Recebimento = new System.Windows.Forms.RadioButton();
            this.rdbIDReceita = new System.Windows.Forms.RadioButton();
            this.cmbTipoDespesas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblATE = new System.Windows.Forms.Label();
            this.lblDE = new System.Windows.Forms.Label();
            this.dt_RecebimentoDE = new System.Windows.Forms.DateTimePicker();
            this.dt_RecebimentoATE = new System.Windows.Forms.DateTimePicker();
            this.btnGerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbTipoReceita
            // 
            this.rdbTipoReceita.AutoSize = true;
            this.rdbTipoReceita.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTipoReceita.Location = new System.Drawing.Point(27, 173);
            this.rdbTipoReceita.Name = "rdbTipoReceita";
            this.rdbTipoReceita.Size = new System.Drawing.Size(98, 21);
            this.rdbTipoReceita.TabIndex = 90;
            this.rdbTipoReceita.Text = "Tipo Receita";
            this.rdbTipoReceita.UseVisualStyleBackColor = true;
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Checked = true;
            this.rdbTodos.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTodos.Location = new System.Drawing.Point(27, 22);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(63, 21);
            this.rdbTodos.TabIndex = 85;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.CheckedChanged += new System.EventHandler(this.rdbTodos_CheckedChanged);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(122, 136);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(322, 20);
            this.txtConsulta.TabIndex = 83;
            // 
            // rdbValorReceita
            // 
            this.rdbValorReceita.AutoSize = true;
            this.rdbValorReceita.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbValorReceita.Location = new System.Drawing.Point(27, 136);
            this.rdbValorReceita.Name = "rdbValorReceita";
            this.rdbValorReceita.Size = new System.Drawing.Size(90, 21);
            this.rdbValorReceita.TabIndex = 82;
            this.rdbValorReceita.Text = "Valor Total";
            this.rdbValorReceita.UseVisualStyleBackColor = true;
            this.rdbValorReceita.CheckedChanged += new System.EventHandler(this.rdbValorReceita_CheckedChanged);
            // 
            // rdbDt_Recebimento
            // 
            this.rdbDt_Recebimento.AutoSize = true;
            this.rdbDt_Recebimento.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDt_Recebimento.Location = new System.Drawing.Point(27, 59);
            this.rdbDt_Recebimento.Name = "rdbDt_Recebimento";
            this.rdbDt_Recebimento.Size = new System.Drawing.Size(133, 21);
            this.rdbDt_Recebimento.TabIndex = 81;
            this.rdbDt_Recebimento.Text = "Data Recebimento";
            this.rdbDt_Recebimento.UseVisualStyleBackColor = true;
            this.rdbDt_Recebimento.CheckedChanged += new System.EventHandler(this.rdbDt_Recebimento_CheckedChanged);
            // 
            // rdbIDReceita
            // 
            this.rdbIDReceita.AutoSize = true;
            this.rdbIDReceita.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbIDReceita.Location = new System.Drawing.Point(27, 99);
            this.rdbIDReceita.Name = "rdbIDReceita";
            this.rdbIDReceita.Size = new System.Drawing.Size(69, 21);
            this.rdbIDReceita.TabIndex = 80;
            this.rdbIDReceita.Text = "Código";
            this.rdbIDReceita.UseVisualStyleBackColor = true;
            this.rdbIDReceita.CheckedChanged += new System.EventHandler(this.rdbIDReceita_CheckedChanged);
            // 
            // cmbTipoDespesas
            // 
            this.cmbTipoDespesas.FormattingEnabled = true;
            this.cmbTipoDespesas.Location = new System.Drawing.Point(122, 210);
            this.cmbTipoDespesas.Name = "cmbTipoDespesas";
            this.cmbTipoDespesas.Size = new System.Drawing.Size(150, 21);
            this.cmbTipoDespesas.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 78;
            this.label1.Text = "Tipo Receitas:";
            // 
            // lblATE
            // 
            this.lblATE.AutoSize = true;
            this.lblATE.Location = new System.Drawing.Point(314, 64);
            this.lblATE.Name = "lblATE";
            this.lblATE.Size = new System.Drawing.Size(26, 13);
            this.lblATE.TabIndex = 94;
            this.lblATE.Text = "Até:";
            // 
            // lblDE
            // 
            this.lblDE.AutoSize = true;
            this.lblDE.Location = new System.Drawing.Point(166, 64);
            this.lblDE.Name = "lblDE";
            this.lblDE.Size = new System.Drawing.Size(24, 13);
            this.lblDE.TabIndex = 93;
            this.lblDE.Text = "De:";
            // 
            // dt_RecebimentoDE
            // 
            this.dt_RecebimentoDE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_RecebimentoDE.Location = new System.Drawing.Point(196, 62);
            this.dt_RecebimentoDE.Name = "dt_RecebimentoDE";
            this.dt_RecebimentoDE.Size = new System.Drawing.Size(101, 20);
            this.dt_RecebimentoDE.TabIndex = 92;
            // 
            // dt_RecebimentoATE
            // 
            this.dt_RecebimentoATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_RecebimentoATE.Location = new System.Drawing.Point(355, 62);
            this.dt_RecebimentoATE.Name = "dt_RecebimentoATE";
            this.dt_RecebimentoATE.Size = new System.Drawing.Size(89, 20);
            this.dt_RecebimentoATE.TabIndex = 91;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(382, 247);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 95;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // frmRelatorioReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 284);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.lblATE);
            this.Controls.Add(this.lblDE);
            this.Controls.Add(this.dt_RecebimentoDE);
            this.Controls.Add(this.dt_RecebimentoATE);
            this.Controls.Add(this.rdbTipoReceita);
            this.Controls.Add(this.rdbTodos);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.rdbValorReceita);
            this.Controls.Add(this.rdbDt_Recebimento);
            this.Controls.Add(this.rdbIDReceita);
            this.Controls.Add(this.cmbTipoDespesas);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRelatorioReceita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar Relatório das Receitas";
            this.Load += new System.EventHandler(this.frmRelatorioReceita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbTipoReceita;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.RadioButton rdbValorReceita;
        private System.Windows.Forms.RadioButton rdbDt_Recebimento;
        private System.Windows.Forms.RadioButton rdbIDReceita;
        private System.Windows.Forms.ComboBox cmbTipoDespesas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblATE;
        private System.Windows.Forms.Label lblDE;
        private System.Windows.Forms.DateTimePicker dt_RecebimentoDE;
        private System.Windows.Forms.DateTimePicker dt_RecebimentoATE;
        private System.Windows.Forms.Button btnGerar;
    }
}