namespace App_controlador_gastos
{
    partial class frmConsultaDespesas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.rdbDT_Vencimento = new System.Windows.Forms.RadioButton();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.cmbTipoDespesas = new System.Windows.Forms.ComboBox();
            this.rdbValorReceita = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbIDReceita = new System.Windows.Forms.RadioButton();
            this.rdbDt_Pagamento = new System.Windows.Forms.RadioButton();
            this.dgvDespesas = new System.Windows.Forms.DataGridView();
            this.lblATE = new System.Windows.Forms.Label();
            this.lblDE = new System.Windows.Forms.Label();
            this.dt_DE = new System.Windows.Forms.DateTimePicker();
            this.dt_ATE = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblATE);
            this.groupBox1.Controls.Add(this.lblDE);
            this.groupBox1.Controls.Add(this.dt_DE);
            this.groupBox1.Controls.Add(this.dt_ATE);
            this.groupBox1.Controls.Add(this.rdbTodos);
            this.groupBox1.Controls.Add(this.rdbDT_Vencimento);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.txtConsulta);
            this.groupBox1.Controls.Add(this.cmbTipoDespesas);
            this.groupBox1.Controls.Add(this.rdbValorReceita);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbIDReceita);
            this.groupBox1.Controls.Add(this.rdbDt_Pagamento);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 115);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar por:";
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Checked = true;
            this.rdbTodos.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTodos.Location = new System.Drawing.Point(17, 19);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(63, 21);
            this.rdbTodos.TabIndex = 9;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.CheckedChanged += new System.EventHandler(this.rdbTodos_CheckedChanged);
            // 
            // rdbDT_Vencimento
            // 
            this.rdbDT_Vencimento.AutoSize = true;
            this.rdbDT_Vencimento.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDT_Vencimento.Location = new System.Drawing.Point(485, 19);
            this.rdbDT_Vencimento.Name = "rdbDT_Vencimento";
            this.rdbDT_Vencimento.Size = new System.Drawing.Size(125, 21);
            this.rdbDT_Vencimento.TabIndex = 8;
            this.rdbDT_Vencimento.Text = "Data Vencimento";
            this.rdbDT_Vencimento.UseVisualStyleBackColor = true;
            this.rdbDT_Vencimento.CheckedChanged += new System.EventHandler(this.rdbDT_Vencimento_CheckedChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(691, 72);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(83, 23);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(319, 75);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(346, 20);
            this.txtConsulta.TabIndex = 6;
            // 
            // cmbTipoDespesas
            // 
            this.cmbTipoDespesas.FormattingEnabled = true;
            this.cmbTipoDespesas.Location = new System.Drawing.Point(112, 74);
            this.cmbTipoDespesas.Name = "cmbTipoDespesas";
            this.cmbTipoDespesas.Size = new System.Drawing.Size(150, 21);
            this.cmbTipoDespesas.TabIndex = 1;
            // 
            // rdbValorReceita
            // 
            this.rdbValorReceita.AutoSize = true;
            this.rdbValorReceita.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbValorReceita.Location = new System.Drawing.Point(234, 19);
            this.rdbValorReceita.Name = "rdbValorReceita";
            this.rdbValorReceita.Size = new System.Drawing.Size(57, 21);
            this.rdbValorReceita.TabIndex = 5;
            this.rdbValorReceita.Text = "Valor";
            this.rdbValorReceita.UseVisualStyleBackColor = true;
            this.rdbValorReceita.CheckedChanged += new System.EventHandler(this.rdbValorReceita_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Despesas:";
            // 
            // rdbIDReceita
            // 
            this.rdbIDReceita.AutoSize = true;
            this.rdbIDReceita.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbIDReceita.Location = new System.Drawing.Point(125, 19);
            this.rdbIDReceita.Name = "rdbIDReceita";
            this.rdbIDReceita.Size = new System.Drawing.Size(69, 21);
            this.rdbIDReceita.TabIndex = 3;
            this.rdbIDReceita.Text = "Código";
            this.rdbIDReceita.UseVisualStyleBackColor = true;
            this.rdbIDReceita.CheckedChanged += new System.EventHandler(this.rdbIDReceita_CheckedChanged);
            // 
            // rdbDt_Pagamento
            // 
            this.rdbDt_Pagamento.AutoSize = true;
            this.rdbDt_Pagamento.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDt_Pagamento.Location = new System.Drawing.Point(324, 19);
            this.rdbDt_Pagamento.Name = "rdbDt_Pagamento";
            this.rdbDt_Pagamento.Size = new System.Drawing.Size(123, 21);
            this.rdbDt_Pagamento.TabIndex = 4;
            this.rdbDt_Pagamento.Text = "Data Pagamento";
            this.rdbDt_Pagamento.UseVisualStyleBackColor = true;
            this.rdbDt_Pagamento.CheckedChanged += new System.EventHandler(this.rdbDt_Pagamento_CheckedChanged);
            // 
            // dgvDespesas
            // 
            this.dgvDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDespesas.Location = new System.Drawing.Point(15, 133);
            this.dgvDespesas.Name = "dgvDespesas";
            this.dgvDespesas.Size = new System.Drawing.Size(797, 324);
            this.dgvDespesas.TabIndex = 2;
            // 
            // lblATE
            // 
            this.lblATE.AutoSize = true;
            this.lblATE.Location = new System.Drawing.Point(511, 77);
            this.lblATE.Name = "lblATE";
            this.lblATE.Size = new System.Drawing.Size(26, 13);
            this.lblATE.TabIndex = 80;
            this.lblATE.Text = "Até:";
            // 
            // lblDE
            // 
            this.lblDE.AutoSize = true;
            this.lblDE.Location = new System.Drawing.Point(328, 77);
            this.lblDE.Name = "lblDE";
            this.lblDE.Size = new System.Drawing.Size(24, 13);
            this.lblDE.TabIndex = 79;
            this.lblDE.Text = "De:";
            // 
            // dt_DE
            // 
            this.dt_DE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_DE.Location = new System.Drawing.Point(358, 75);
            this.dt_DE.Name = "dt_DE";
            this.dt_DE.Size = new System.Drawing.Size(125, 20);
            this.dt_DE.TabIndex = 78;
            // 
            // dt_ATE
            // 
            this.dt_ATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ATE.Location = new System.Drawing.Point(552, 75);
            this.dt_ATE.Name = "dt_ATE";
            this.dt_ATE.Size = new System.Drawing.Size(113, 20);
            this.dt_ATE.TabIndex = 77;
            // 
            // frmConsultaDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 469);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDespesas);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaDespesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Despesas";
            this.Load += new System.EventHandler(this.frmConsultaDespesas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsultaDespesas_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.RadioButton rdbValorReceita;
        private System.Windows.Forms.RadioButton rdbDt_Pagamento;
        private System.Windows.Forms.RadioButton rdbIDReceita;
        private System.Windows.Forms.ComboBox cmbTipoDespesas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDespesas;
        private System.Windows.Forms.RadioButton rdbDT_Vencimento;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.Label lblATE;
        private System.Windows.Forms.Label lblDE;
        private System.Windows.Forms.DateTimePicker dt_DE;
        private System.Windows.Forms.DateTimePicker dt_ATE;
    }
}