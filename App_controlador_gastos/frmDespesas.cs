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
    public partial class frmDespesas : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet dt;
        String sql;

        decimal valor = 0, juros = 0, totalPagar = 0;

        public frmDespesas()
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


        private void frmDespesas_Load(object sender, EventArgs e)
        {
            btnInserir.Enabled = false;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            txtID.Enabled = true;
            txtJuros.Enabled = false;
            txtValor.Enabled = false;
            txtObservacao.Enabled = false;
            txtTotalPagar.Enabled = false;
            txtValor.Enabled = false;
            dt_Pagamento.Enabled = false;
            dt_Vencimento.Enabled = false;
            cmbTipoDespesa.Enabled = false;
            btnPesquisar.Enabled = false;

            // CARREGAR DADOS DO METODO carregaTipoDespesa
            cmbTipoDespesa.DataSource = carregaTipoDespesa();
            cmbTipoDespesa.DisplayMember = "descricao";
            cmbTipoDespesa.ValueMember = "ID_tblTipoDespesas";

            // tooltip
            // configurar o atraso da ferramenta
            ttpID.AutoPopDelay = 5000;
            ttpID.InitialDelay = 1000;
            ttpID.ReshowDelay = 500;
            // habilitar o tooltrip
            ttpID.ShowAlways = true;
            //definir aonde tooltip vai aparecer  
            ttpID.SetToolTip(this.txtID, "F3 para Selecionar os registros");
        }

        private void lblNovo_Click(object sender, EventArgs e)
        {
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnInserir.Enabled = true;
            txtID.Enabled = false;
            txtValor.Enabled = true;
            txtJuros.Enabled = true;
            txtTotalPagar.Enabled = false;
            txtObservacao.Enabled = true;
            dt_Pagamento.Enabled = true;
            dt_Vencimento.Enabled = true;
            cmbTipoDespesa.Enabled = true;
            btnPesquisar.Enabled = false;
        }

        private void lblAlterar1_Click_1(object sender, EventArgs e)
        {
            btnInserir.Enabled = false;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = true;
            txtID.Enabled = true;
            txtValor.Enabled = true;
            txtJuros.Enabled = true;
            txtTotalPagar.Enabled = false;
            txtObservacao.Enabled = true;
            dt_Pagamento.Enabled = true;
            dt_Vencimento.Enabled = true;
            cmbTipoDespesa.Enabled = true;
            btnPesquisar.Enabled = true;
        }

        private void lblExcluir_Click(object sender, EventArgs e)
        {
            btnInserir.Enabled = false;
            btnExcluir.Enabled = true;
            btnAlterar.Enabled = false;
            txtID.Enabled = true;
            txtValor.Enabled = false;
            txtJuros.Enabled = false;
            txtTotalPagar.Enabled = false;
            txtObservacao.Enabled = false;
            dt_Pagamento.Enabled = false;
            dt_Vencimento.Enabled = false;
            cmbTipoDespesa.Enabled = false;
            btnPesquisar.Enabled = true;
        }
        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                frmConsultaDespesas consultaReceitasAtalho = new frmConsultaDespesas();
                consultaReceitasAtalho.ShowDialog();
            }

        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmConsultaDespesas consultaReceitasAtalho = new frmConsultaDespesas();
            consultaReceitasAtalho.ShowDialog();
        }

        void soma()
        {

            if (txtValor.Text != "")
            {
                valor = decimal.Parse(txtValor.Text);
                juros = decimal.Parse(txtJuros.Text);

                totalPagar = juros + valor;

                txtTotalPagar.Text = totalPagar.ToString();
            }
        }
        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            soma();
        }

        private void txtJuros_TextChanged(object sender, EventArgs e)
        {
            soma();
        }
        // METOTO PARA LIMPAR TEXTBOX 
        private void limpar()
        {
            txtID.Clear();
            txtValor.Clear();
            txtJuros.Clear();
            txtTotalPagar.Clear();
            txtObservacao.Clear();
            //VOLTAR DATA PARA O DIA
            dt_Pagamento.Value = DateTime.Today;
            dt_Vencimento.Value = DateTime.Today;
            txtID.Focus();
        }
        // COXEÇÃO COM O BANCO PARA RETORNAR DADOS PARA COMBOX
        private DataTable carregaTipoDespesa()
        {
            sql = "select ID_tblTipoDespesas, descricao from tblTipoDespesas order by descricao";
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            return dt;
        }

        // INSERIR OS DADOS
        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                if (txtValor.Text != "0,00" && txtValor.Text != "")
                {
                    sql = String.Format("insert into tblDespesas (ID_tblTipoDespesas, valorDespesa, juros, dt_vencimento, dt_pagamento, valorTotal, observacao) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", cmbTipoDespesa.SelectedValue.ToString(), txtValor.Text.Replace(",", "."), txtJuros.Text.Replace(",", "."), dt_Vencimento.Value.ToString("yyyy-MM-dd"), dt_Pagamento.Value.ToString("yyyy-MM-dd"), txtTotalPagar.Text.Replace(",", "."), txtObservacao.Text);
                    da = new SqlDataAdapter(sql, con);
                    da.Fill(dt, "controlador_gastos");
                    MessageBox.Show("Cadastro efetuado com sucesso !");
                    limpar();
                }
                else
                {
                    MessageBox.Show("Favor informar os campos obrigatórios !");
                }
            }
            else
            {
                MessageBox.Show("Não foi possível conectar ao servidor !");
            }
        }

        private void frmDespesas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }
        // ALTERAR OS DADOS
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                if (txtID.Text != "" && txtValor.Text != "" && txtValor.Text != "0,00")
                {
                    sql = string.Format("Update tblDespesas set ID_tblTipoDespesas = '{0}', valorDespesa = '{1}', juros = '{2}', dt_vencimento = '{3}', dt_pagamento = '{4}', valorTotal = '{5}', observacao = '{6}' where ID_tblDespesas = '{7}'", cmbTipoDespesa.SelectedValue.ToString(), txtValor.Text.Replace(",", "."), txtJuros.Text.Replace(",", "."), dt_Vencimento.Value.ToString("yyyy-MM-dd"), dt_Pagamento.Value.ToString("yyyy-MM-dd"), txtTotalPagar.Text.Replace(",", "."), txtObservacao.Text, txtID.Text);
                    da = new SqlDataAdapter(sql, con);
                    da.Fill(dt, "controlador_gastos");
                    MessageBox.Show("Cadastro alterado com sucesso");
                    limpar();
                }
                else
                {
                    MessageBox.Show("Favor informar os campos obrigatórios !");
                }
            }
            else
            {
                MessageBox.Show("Não foi possível conectar ao servidor !");
            }

        }
        // EXLUIR OS DADOS
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                if (txtID.Text != "")
                {
                    sql = String.Format("Delete from tblDespesas where ID_tblDespesas = '{0}'", txtID.Text);
                    da = new SqlDataAdapter(sql, con);
                    da.Fill(dt, "controlador_gastos");
                    MessageBox.Show("Cadastro excluído com sucesso !");
                    limpar();
                }
                else
                {
                    MessageBox.Show("Favor informar os campos obrigatórios !");
                }
            }
            else
            {
                MessageBox.Show("Não foi possível conectar ao servidor !");
            }

        }
    }
}