namespace App_controlador_gastos
{
    partial class frmReceitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceitas));
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtID_Receita = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoReceita = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAlterar = new System.Windows.Forms.ToolStrip();
            this.lblNovo = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.lblAlterar1 = new System.Windows.Forms.ToolStripLabel();
            this.lblExcluir = new System.Windows.Forms.ToolStripLabel();
            this.dt_Recebimento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ttpID = new System.Windows.Forms.ToolTip(this.components);
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblAlterar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            resources.ApplyResources(this.btnExcluir, "btnExcluir");
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnInserir
            // 
            resources.ApplyResources(this.btnInserir, "btnInserir");
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnAlterar
            // 
            resources.ApplyResources(this.btnAlterar, "btnAlterar");
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Name = "label9";
            // 
            // txtID_Receita
            // 
            resources.ApplyResources(this.txtID_Receita, "txtID_Receita");
            this.txtID_Receita.Name = "txtID_Receita";
            this.txtID_Receita.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_Receita_KeyDown);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Name = "label10";
            // 
            // txtObservacao
            // 
            resources.ApplyResources(this.txtObservacao, "txtObservacao");
            this.txtObservacao.Name = "txtObservacao";
            // 
            // txtValor
            // 
            resources.ApplyResources(this.txtValor, "txtValor");
            this.txtValor.Name = "txtValor";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cmbTipoReceita
            // 
            this.cmbTipoReceita.FormattingEnabled = true;
            resources.ApplyResources(this.cmbTipoReceita, "cmbTipoReceita");
            this.cmbTipoReceita.Name = "cmbTipoReceita";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lblAlterar
            // 
            this.lblAlterar.BackColor = System.Drawing.SystemColors.Control;
            this.lblAlterar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNovo,
            this.toolStripLabel3,
            this.lblAlterar1,
            this.lblExcluir});
            resources.ApplyResources(this.lblAlterar, "lblAlterar");
            this.lblAlterar.Name = "lblAlterar";
            // 
            // lblNovo
            // 
            resources.ApplyResources(this.lblNovo, "lblNovo");
            this.lblNovo.Name = "lblNovo";
            this.lblNovo.Click += new System.EventHandler(this.lblNovo_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            resources.ApplyResources(this.toolStripLabel3, "toolStripLabel3");
            // 
            // lblAlterar1
            // 
            resources.ApplyResources(this.lblAlterar1, "lblAlterar1");
            this.lblAlterar1.Name = "lblAlterar1";
            this.lblAlterar1.Click += new System.EventHandler(this.lblAlterar1_Click);
            // 
            // lblExcluir
            // 
            resources.ApplyResources(this.lblExcluir, "lblExcluir");
            this.lblExcluir.Name = "lblExcluir";
            this.lblExcluir.Click += new System.EventHandler(this.lblExcluir_Click);
            // 
            // dt_Recebimento
            // 
            this.dt_Recebimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            resources.ApplyResources(this.dt_Recebimento, "dt_Recebimento");
            this.dt_Recebimento.Name = "dt_Recebimento";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Name = "label5";
            // 
            // btnPesquisar
            // 
            resources.ApplyResources(this.btnPesquisar, "btnPesquisar");
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmReceitas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dt_Recebimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAlterar);
            this.Controls.Add(this.cmbTipoReceita);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtID_Receita);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReceitas";
            this.Load += new System.EventHandler(this.frmReceitas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmReceitas_KeyDown);
            this.lblAlterar.ResumeLayout(false);
            this.lblAlterar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtID_Receita;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoReceita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip lblAlterar;
        private System.Windows.Forms.ToolStripLabel lblNovo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel lblAlterar1;
        private System.Windows.Forms.ToolStripLabel lblExcluir;
        private System.Windows.Forms.DateTimePicker dt_Recebimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip ttpID;
        private System.Windows.Forms.Button btnPesquisar;
    }
}