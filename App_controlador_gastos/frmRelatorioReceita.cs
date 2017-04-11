using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace App_controlador_gastos
{
    public partial class frmRelatorioReceita : Form
    {
        public frmRelatorioReceita()
        {
            InitializeComponent();
        }
        private void frmRelatorioReceita_Load(object sender, EventArgs e)
        {
            txtConsulta.Enabled = false;
            dt_RecebimentoDE.Enabled = false;
            dt_RecebimentoATE.Enabled = false;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            frmTelaRelatorioReceita telaRelatorioReceita = new frmTelaRelatorioReceita();
            telaRelatorioReceita.ShowDialog();
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            txtConsulta.Enabled = false;
            dt_RecebimentoDE.Enabled = false;
            dt_RecebimentoATE.Enabled = false;
        }

        private void rdbDt_Recebimento_CheckedChanged(object sender, EventArgs e)
        {
            dt_RecebimentoDE.Enabled = true;
            dt_RecebimentoATE.Enabled = true;
        }

        private void rdbIDReceita_CheckedChanged(object sender, EventArgs e)
        {
            txtConsulta.Enabled = true;
            dt_RecebimentoDE.Enabled = false;
            dt_RecebimentoATE.Enabled = false;
        }

        private void rdbValorReceita_CheckedChanged(object sender, EventArgs e)
        {
            txtConsulta.Enabled = true;
            dt_RecebimentoDE.Enabled = false;
            dt_RecebimentoATE.Enabled = false;
        }


    }
}
