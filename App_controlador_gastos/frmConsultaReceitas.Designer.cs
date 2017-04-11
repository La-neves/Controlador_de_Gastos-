namespace App_controlador_gastos
{
    partial class frmConsultaReceitas
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
            this.dgvReceitas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTipoReceita = new System.Windows.Forms.RadioButton();
            this.lblATE = new System.Windows.Forms.Label();
            this.lblDE = new System.Windows.Forms.Label();
            this.dt_RecebimentoDE = new System.Windows.Forms.DateTimePicker();
            this.dt_RecebimentoATE = new System.Windows.Forms.DateTimePicker();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.rdbValorReceita = new System.Windows.Forms.RadioButton();
            this.rdbDt_Recebimento = new System.Windows.Forms.RadioButton();
            this.rdbIDReceita = new System.Windows.Forms.RadioButton();
            this.cmbTipoDespesas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ttpTotalReceita = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceitas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReceitas
            // 
            this.dgvReceitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceitas.Location = new System.Drawing.Point(13, 146);
            this.dgvReceitas.Name = "dgvReceitas";
            this.dgvReceitas.Size = new System.Drawing.Size(797, 313);
            this.dgvReceitas.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTipoReceita);
            this.groupBox1.Controls.Add(this.lblATE);
            this.groupBox1.Controls.Add(this.lblDE);
            this.groupBox1.Controls.Add(this.dt_RecebimentoDE);
            this.groupBox1.Controls.Add(this.dt_RecebimentoATE);
            this.groupBox1.Controls.Add(this.rdbTodos);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.txtConsulta);
            this.groupBox1.Controls.Add(this.rdbValorReceita);
            this.groupBox1.Controls.Add(this.rdbDt_Recebimento);
            this.groupBox1.Controls.Add(this.rdbIDReceita);
            this.groupBox1.Controls.Add(this.cmbTipoDespesas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 115);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar por:";
            // 
            // rdbTipoReceita
            // 
            this.rdbTipoReceita.AutoSize = true;
            this.rdbTipoReceita.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTipoReceita.Location = new System.Drawing.Point(477, 19);
            this.rdbTipoReceita.Name = "rdbTipoReceita";
            this.rdbTipoReceita.Size = new System.Drawing.Size(98, 21);
            this.rdbTipoReceita.TabIndex = 77;
            this.rdbTipoReceita.Text = "Tipo Receita";
            this.rdbTipoReceita.UseVisualStyleBackColor = true;
            this.rdbTipoReceita.CheckedChanged += new System.EventHandler(this.rdbTipoDespesa_CheckedChanged);
            // 
            // lblATE
            // 
            this.lblATE.AutoSize = true;
            this.lblATE.Location = new System.Drawing.Point(523, 76);
            this.lblATE.Name = "lblATE";
            this.lblATE.Size = new System.Drawing.Size(26, 13);
            this.lblATE.TabIndex = 76;
            this.lblATE.Text = "Até:";
            // 
            // lblDE
            // 
            this.lblDE.AutoSize = true;
            this.lblDE.Location = new System.Drawing.Point(340, 76);
            this.lblDE.Name = "lblDE";
            this.lblDE.Size = new System.Drawing.Size(24, 13);
            this.lblDE.TabIndex = 75;
            this.lblDE.Text = "De:";
            // 
            // dt_RecebimentoDE
            // 
            this.dt_RecebimentoDE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_RecebimentoDE.Location = new System.Drawing.Point(370, 74);
            this.dt_RecebimentoDE.Name = "dt_RecebimentoDE";
            this.dt_RecebimentoDE.Size = new System.Drawing.Size(125, 20);
            this.dt_RecebimentoDE.TabIndex = 74;
            // 
            // dt_RecebimentoATE
            // 
            this.dt_RecebimentoATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_RecebimentoATE.Location = new System.Drawing.Point(564, 74);
            this.dt_RecebimentoATE.Name = "dt_RecebimentoATE";
            this.dt_RecebimentoATE.Size = new System.Drawing.Size(113, 20);
            this.dt_RecebimentoATE.TabIndex = 73;
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Checked = true;
            this.rdbTodos.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTodos.Location = new System.Drawing.Point(25, 19);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(63, 21);
            this.rdbTodos.TabIndex = 8;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.Click += new System.EventHandler(this.rdbTodos_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(694, 71);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(83, 23);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(331, 73);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(346, 20);
            this.txtConsulta.TabIndex = 6;
            // 
            // rdbValorReceita
            // 
            this.rdbValorReceita.AutoSize = true;
            this.rdbValorReceita.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbValorReceita.Location = new System.Drawing.Point(222, 19);
            this.rdbValorReceita.Name = "rdbValorReceita";
            this.rdbValorReceita.Size = new System.Drawing.Size(90, 21);
            this.rdbValorReceita.TabIndex = 5;
            this.rdbValorReceita.Text = "Valor Total";
            this.rdbValorReceita.UseVisualStyleBackColor = true;
            this.rdbValorReceita.Click += new System.EventHandler(this.rdbValorReceita_Click);
            // 
            // rdbDt_Recebimento
            // 
            this.rdbDt_Recebimento.AutoSize = true;
            this.rdbDt_Recebimento.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDt_Recebimento.Location = new System.Drawing.Point(331, 19);
            this.rdbDt_Recebimento.Name = "rdbDt_Recebimento";
            this.rdbDt_Recebimento.Size = new System.Drawing.Size(133, 21);
            this.rdbDt_Recebimento.TabIndex = 4;
            this.rdbDt_Recebimento.Text = "Data Recebimento";
            this.rdbDt_Recebimento.UseVisualStyleBackColor = true;
            this.rdbDt_Recebimento.Click += new System.EventHandler(this.rdbDt_Recebimento_Click);
            // 
            // rdbIDReceita
            // 
            this.rdbIDReceita.AutoSize = true;
            this.rdbIDReceita.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbIDReceita.Location = new System.Drawing.Point(120, 19);
            this.rdbIDReceita.Name = "rdbIDReceita";
            this.rdbIDReceita.Size = new System.Drawing.Size(69, 21);
            this.rdbIDReceita.TabIndex = 3;
            this.rdbIDReceita.Text = "Código";
            this.rdbIDReceita.UseVisualStyleBackColor = true;
            this.rdbIDReceita.CheckedChanged += new System.EventHandler(this.rdbIDReceita_CheckedChanged);
            // 
            // cmbTipoDespesas
            // 
            this.cmbTipoDespesas.FormattingEnabled = true;
            this.cmbTipoDespesas.Location = new System.Drawing.Point(120, 73);
            this.cmbTipoDespesas.Name = "cmbTipoDespesas";
            this.cmbTipoDespesas.Size = new System.Drawing.Size(150, 21);
            this.cmbTipoDespesas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Receitas:";
            // 
            // frmConsultaReceitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 473);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvReceitas);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaReceitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Receitas";
            this.Load += new System.EventHandler(this.frmRelatorioReceitas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmConsultaReceitas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceitas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReceitas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbIDReceita;
        private System.Windows.Forms.ComboBox cmbTipoDespesas;
        private System.Windows.Forms.RadioButton rdbDt_Recebimento;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.RadioButton rdbValorReceita;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.DateTimePicker dt_RecebimentoATE;
        private System.Windows.Forms.DateTimePicker dt_RecebimentoDE;
        private System.Windows.Forms.Label lblATE;
        private System.Windows.Forms.Label lblDE;
        private System.Windows.Forms.RadioButton rdbTipoReceita;
        private System.Windows.Forms.ToolTip ttpTotalReceita;
    }
}