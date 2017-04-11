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
    public partial class frmConsultaReceitas : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet dt;
        String sql;

        public frmConsultaReceitas()
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

        // TRAZER O FORMULARIO JÁ PREENCHIDO COM TODOS OS DADOS
        private void frmRelatorioReceitas_Load(object sender, EventArgs e)
        {
            dt_RecebimentoATE.Visible = false;
            dt_RecebimentoDE.Visible = false;
            lblDE.Visible = false;
            lblATE.Visible = false;

            cmbTipoDespesas.DataSource = carregaTipoReceita();
            cmbTipoDespesas.DisplayMember = "descricao"; //Vai aparecer no form
            cmbTipoDespesas.ValueMember = "ID_tbltipoReceitas";


            if (con.State == ConnectionState.Open)
            {
                sql = "select * from tblReceitas";
                da = new SqlDataAdapter(sql, con);
                da.Fill(dt, "controlador_gastos");
                dgvReceitas.DataSource = dt;
                dgvReceitas.DataMember = "controlador_gastos";
            }
            else
            {
                MessageBox.Show("Não foi possível conectar ao servidor !");
            }
            colunas();

        }

        private void rdbDt_Recebimento_Click(object sender, EventArgs e)
        {
            txtConsulta.Visible = false;
            dt_RecebimentoATE.Visible = true;
            dt_RecebimentoDE.Visible = true;
            lblDE.Visible = true;
            lblATE.Visible = true;
            cmbTipoDespesas.Enabled = false;
        }

        private void rdbTodos_Click(object sender, EventArgs e)
        {
            txtConsulta.Visible = true;
            dt_RecebimentoDE.Visible = false;
            dt_RecebimentoATE.Visible = false;
            lblDE.Visible = false;
            lblATE.Visible = false;
            cmbTipoDespesas.Enabled = false;
        }
        private void rdbIDReceita_CheckedChanged(object sender, EventArgs e)
        {
            txtConsulta.Visible = true;
            dt_RecebimentoDE.Visible = false;
            dt_RecebimentoATE.Visible = false;
            lblDE.Visible = false;
            lblATE.Visible = false;
            cmbTipoDespesas.Enabled = false;
        }
        private void rdbValorReceita_Click(object sender, EventArgs e)
        {
            txtConsulta.Visible = true;
            dt_RecebimentoDE.Visible = false;
            dt_RecebimentoATE.Visible = false;
            lblDE.Visible = false;
            lblATE.Visible = false;
            cmbTipoDespesas.Enabled = false;
        }

        private void rdbTipoDespesa_CheckedChanged(object sender, EventArgs e)
        {
            txtConsulta.Visible = true;
            txtConsulta.Enabled = false;
            dt_RecebimentoDE.Visible = false;
            dt_RecebimentoATE.Visible = false;
            lblDE.Visible = false;
            lblATE.Visible = false;
            cmbTipoDespesas.Enabled = true;
        }
        // SAIR DO FORM UTILIZANDO O ESC
        private void frmConsultaReceitas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }
        private DataTable carregaTipoReceita()
        {
            sql = "select ID_tblTipoReceitas, descricao from tblTipoReceitas order by descricao";
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        private void limpar()
        {
            txtConsulta.Clear();
            dt_RecebimentoDE.Value = DateTime.Today;
            dt_RecebimentoATE.Value = DateTime.Today;
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dt.Clear();
            if (rdbTodos.Checked)
            {
                sql = "select * from tblReceitas";
            }
            else if (rdbIDReceita.Checked)
            {
                sql = String.Format("select * from tblReceitas where ID_tblReceitas = '{0}'", txtConsulta.Text);
            }
            else if (rdbValorReceita.Checked)
            {
                sql = String.Format("select * from tblReceitas where valorReceita = '{0}'", txtConsulta.Text.Replace(",", "."));
            }
            else if (rdbDt_Recebimento.Checked)
            {
                sql = String.Format("select * from tblReceitas where dt_recebimento between '" + dt_RecebimentoDE.Value.ToString("yyyy-MM-dd") + "' and '" + dt_RecebimentoATE.Value.ToString("yyyy-MM-dd") + "'");
            }


            da = new SqlDataAdapter(sql, con);
            da.Fill(dt, "controlador_gastos");
            dgvReceitas.DataSource = dt;
            dgvReceitas.DataMember = "controlador_gastos";
            limpar();
            colunas();
        }
        // PERSONALIZAR CAMPODS GRIDVIEW
        private void colunas()
        {

            dgvReceitas.Columns[0].HeaderText = "Código";
            dgvReceitas.Columns[0].Width = 50;
            dgvReceitas.Columns[1].HeaderText = "Valor R$";
            dgvReceitas.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvReceitas.Columns[2].HeaderText = "Data Recebimento";
            dgvReceitas.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvReceitas.Columns[3].HeaderText = "Observação";
            dgvReceitas.Columns[3].Width = 320;
            dgvReceitas.Columns[4].HeaderText = "Tipo de Receita";
            dgvReceitas.Columns[4].Width = 190;

            // TRAVAR COLUNAS PARA SOMENTE LEITURA
            dgvReceitas.Columns[0].ReadOnly = true;
            dgvReceitas.Columns[1].ReadOnly = true;
            dgvReceitas.Columns[2].ReadOnly = true;
            dgvReceitas.Columns[3].ReadOnly = true;

        }
    }
}





