using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_controlador_gastos
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void lblReceitas_Click(object sender, EventArgs e)
        {
            frmReceitas telaReceitas = new frmReceitas();
            telaReceitas.ShowDialog();
        }

        private void lblDespesas_Click(object sender, EventArgs e)
        {
            frmDespesas telaDespesas = new frmDespesas();
            telaDespesas.ShowDialog();
        }
        // BOTÃO SAIR DO FORM PRINCIPAL, PERGUNTAR AO USUÁRIO SE REALMENTE DESEJA SAIR
        private void lblSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja finalizar o sistema?", "finalizando ... ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta.ToString() == "Yes") // fazer comparação
            {
                Application.Exit();
            }
        }

        private void frmTelaPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                DialogResult resposta = MessageBox.Show("Deseja finalizar o sistema?", "finalizando ... ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resposta.ToString() == "Yes") // fazer comparação
                {
                    Application.Exit();
                }

            }

        }

        private void lblSobre_Click(object sender, EventArgs e)
        {
            DialogResult sobre = MessageBox.Show(" Controlador de Gastos, versão 1.0.\n Desenvolvedor: Laize Neves", "Sobre");
        }

        private void receitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioReceita relatorioReceita = new frmRelatorioReceita();
            relatorioReceita.ShowDialog();
        }
    }
}
