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
    public partial class frmConsultaDespesas : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet dt;
        string sql;
        public frmConsultaDespesas()
        {
            InitializeComponent();
            dt = new DataSet();
            con = new SqlConnection("Data Source=LAIZENEVES-PC\\SQLEXPRESS;Initial Catalog=controlador_gastos;Persist Security Info=True;User ID=sa;Password=06032017");
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível conectar ao servidor" + ex.Message.ToString());
            }
        }
        private void frmConsultaDespesas_Load(object sender, EventArgs e)
        {
            lblDE.Visible = false;
            lblATE.Visible = false;
            dt_DE.Visible = false;
            dt_ATE.Visible = false;

            if (con.State == ConnectionState.Open)
            {
                sql = "select * from tblDespesas";
                da = new SqlDataAdapter(sql, con);
                da.Fill(dt, "controlador_gastos");
                dgvDespesas.DataSource = dt;
                dgvDespesas.DataMember = "controlador_gastos";
            }
            else
            {
                MessageBox.Show("Não foi possível conectar ao servidor !");
            }
            colunas();
        }

        private void frmConsultaDespesas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            cmbTipoDespesas.Enabled = false;
            txtConsulta.Enabled = false;
            lblDE.Visible = false;
            lblATE.Visible = false;
            dt_DE.Visible = false;
            dt_ATE.Visible = false;
        }
        private void rdbIDReceita_CheckedChanged(object sender, EventArgs e)
        {
            cmbTipoDespesas.Enabled = false;
            txtConsulta.Enabled = true;
            txtConsulta.Visible = true;
            lblDE.Visible = false;
            lblATE.Visible = false;
            dt_DE.Visible = false;
            dt_ATE.Visible = false;
        }

        private void rdbValorReceita_CheckedChanged(object sender, EventArgs e)
        {
            cmbTipoDespesas.Enabled = false;
            txtConsulta.Enabled = true;
            txtConsulta.Visible = true;
            lblDE.Visible = false;
            lblATE.Visible = false;
            dt_DE.Visible = false;
            dt_ATE.Visible = false;
        }

        private void rdbDt_Pagamento_CheckedChanged(object sender, EventArgs e)
        {
            cmbTipoDespesas.Enabled = false;
            txtConsulta.Enabled = false;
            txtConsulta.Visible = false;
            lblDE.Visible = true;
            lblATE.Visible = false;
            dt_DE.Visible = true;
            dt_ATE.Visible = true;
        }

        private void rdbDT_Vencimento_CheckedChanged(object sender, EventArgs e)
        {
            cmbTipoDespesas.Enabled = false;
            txtConsulta.Enabled = false;
            txtConsulta.Visible = false;
            lblDE.Visible = true;
            lblATE.Visible = false;
            dt_DE.Visible = true;
            dt_ATE.Visible = true;
        }
        private void limpar()
        {
            txtConsulta.Clear();
            dt_DE.Value = DateTime.Today;
            dt_ATE.Value = DateTime.Today;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dt.Clear();
            if (rdbTodos.Checked)
            {
                sql = "select * from tblDespesas";
            }
            else if (rdbIDReceita.Checked)
            {
                sql = String.Format("select * from tblDespesas where ID_tblDespesas = '{0}'", txtConsulta.Text);
            }
            else if (rdbValorReceita.Checked)
            {
                sql = String.Format("select * from tblDespesas where valorTotal = '{0}'", txtConsulta.Text.Replace(",", "."));
            }
            else if (rdbDt_Pagamento.Checked)
            {
                sql = String.Format("select * from tblDespesas where dt_pagamento between '" + dt_DE.Value.ToString("yyyy-MM-dd") + "' and '" + dt_ATE.Value.ToString("yyyy-MM-dd") + "'");
            }
            else if (rdbDT_Vencimento.Checked)
            {
                sql = String.Format("select * from tblDespesas where dt_vencimento between '" + dt_DE.Value.ToString("yyyy-MM-dd") + "' and '" + dt_ATE.Value.ToString("yyyy-MM-dd") + "'");
            }


            da = new SqlDataAdapter(sql, con);
            da.Fill(dt, "controlador_gastos");
            dgvDespesas.DataSource = dt;
            dgvDespesas.DataMember = "controlador_gastos";
            limpar();

        }
        private void colunas()
        {
            dgvDespesas.Columns[0].HeaderText = "Código";
            dgvDespesas.Columns[0].Width = 40;
            dgvDespesas.Columns[1].HeaderText = "Valor R$";
            dgvDespesas.Columns[1].Width = 60;
            dgvDespesas.Columns[2].HeaderText = "Juros R$";
            dgvDespesas.Columns[2].Width = 60;
            dgvDespesas.Columns[3].HeaderText = "Data Venc";
            dgvDespesas.Columns[3].Width = 150;
            dgvDespesas.Columns[4].HeaderText = "Data Pagamento";
            dgvDespesas.Columns[4].Width = 150;
            dgvDespesas.Columns[5].HeaderText = "Valor Pago";
            dgvDespesas.Columns[5].Width = 60;
            dgvDespesas.Columns[6].HeaderText = "Observação";
            dgvDespesas.Columns[6].Width = 200;
            dgvDespesas.Columns[7].HeaderText = "Tipo Despesa";
            dgvDespesas.Columns[7].Width = 70;

            // TRAVAR COLUNAS PARA SOMENTE LEITURA
            dgvDespesas.Columns[0].ReadOnly = true;
            dgvDespesas.Columns[1].ReadOnly = true;
            dgvDespesas.Columns[2].ReadOnly = true;
            dgvDespesas.Columns[3].ReadOnly = true;
            dgvDespesas.Columns[4].ReadOnly = true;
            dgvDespesas.Columns[5].ReadOnly = true;
            dgvDespesas.Columns[6].ReadOnly = true;
            dgvDespesas.Columns[7].ReadOnly = true;
        }

   

    }
}
