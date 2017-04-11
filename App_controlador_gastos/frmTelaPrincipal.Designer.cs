namespace App_controlador_gastos
{
    partial class frmTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblReceitas = new System.Windows.Forms.ToolStripLabel();
            this.lblDespesas = new System.Windows.Forms.ToolStripLabel();
            this.lblRelatorios = new System.Windows.Forms.ToolStripDropDownButton();
            this.receitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receitasXDespesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSobre = new System.Windows.Forms.ToolStripLabel();
            this.lblSair = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblReceitas,
            this.lblDespesas,
            this.lblRelatorios,
            this.lblSobre,
            this.lblSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(688, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblReceitas
            // 
            this.lblReceitas.Name = "lblReceitas";
            this.lblReceitas.Size = new System.Drawing.Size(50, 22);
            this.lblReceitas.Text = "Receitas";
            this.lblReceitas.ToolTipText = "Receitas";
            this.lblReceitas.Click += new System.EventHandler(this.lblReceitas_Click);
            // 
            // lblDespesas
            // 
            this.lblDespesas.Name = "lblDespesas";
            this.lblDespesas.Size = new System.Drawing.Size(55, 22);
            this.lblDespesas.Text = "Despesas";
            this.lblDespesas.ToolTipText = "Despesas";
            this.lblDespesas.Click += new System.EventHandler(this.lblDespesas_Click);
            // 
            // lblRelatorios
            // 
            this.lblRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receitasToolStripMenuItem,
            this.despesasToolStripMenuItem,
            this.receitasXDespesasToolStripMenuItem});
            this.lblRelatorios.Name = "lblRelatorios";
            this.lblRelatorios.Size = new System.Drawing.Size(72, 22);
            this.lblRelatorios.Text = "Relatórios";
            this.lblRelatorios.ToolTipText = "Relatórios";
            // 
            // receitasToolStripMenuItem
            // 
            this.receitasToolStripMenuItem.Name = "receitasToolStripMenuItem";
            this.receitasToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.receitasToolStripMenuItem.Text = "Receitas";
            this.receitasToolStripMenuItem.Click += new System.EventHandler(this.receitasToolStripMenuItem_Click);
            // 
            // despesasToolStripMenuItem
            // 
            this.despesasToolStripMenuItem.Name = "despesasToolStripMenuItem";
            this.despesasToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.despesasToolStripMenuItem.Text = "Despesas";
            // 
            // receitasXDespesasToolStripMenuItem
            // 
            this.receitasXDespesasToolStripMenuItem.Name = "receitasXDespesasToolStripMenuItem";
            this.receitasXDespesasToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.receitasXDespesasToolStripMenuItem.Text = "Receitas x Despesas";
            // 
            // lblSobre
            // 
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(37, 22);
            this.lblSobre.Text = "Sobre";
            this.lblSobre.ToolTipText = "Sobre";
            this.lblSobre.Click += new System.EventHandler(this.lblSobre_Click);
            // 
            // lblSair
            // 
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(26, 22);
            this.lblSair.Text = "Sair";
            this.lblSair.ToolTipText = "Sair";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(688, 324);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTelaPrincipal_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblReceitas;
        private System.Windows.Forms.ToolStripLabel lblDespesas;
        private System.Windows.Forms.ToolStripDropDownButton lblRelatorios;
        private System.Windows.Forms.ToolStripMenuItem receitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receitasXDespesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel lblSobre;
        private System.Windows.Forms.ToolStripLabel lblSair;
    }
}