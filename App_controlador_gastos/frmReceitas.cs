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
    public partial class frmReceitas : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet dt;
        String sql;

        public frmReceitas()
        {
            InitializeComponent(); dt = new DataSet();
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

        private void frmReceitas_Load(object sender, EventArgs e)
        {
            btnInserir.Enabled = false;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            txtObservacao.Enabled = false;
            txtValor.Enabled = false;
            txtObservacao.Enabled = false;
            cmbTipoReceita.Enabled = false;
            dt_Recebimento.Enabled = false;
            btnPesquisar.Enabled = false;


            cmbTipoReceita.DataSource = carregaTipoReceita();
            cmbTipoReceita.DisplayMember = "descricao"; //Vai aparecer no form
            cmbTipoReceita.ValueMember = "ID_tbltipoReceitas";
            
            // CONFIGURAR ATRASO DA FERRAMENTA TOOLTRIP
            ttpID.AutoPopDelay = 5000;
            ttpID.InitialDelay = 1000;
            ttpID.ReshowDelay = 500;
            // HABILITAR O TOOLTRIP
            ttpID.ShowAlways = true;
            //DEFINIR ONDE O TOOLTRIP VAI APARECER 
            ttpID.SetToolTip(this.txtID_Receita, "F3 para abrir tela de consulta");
        }
        private void lblNovo_Click(object sender, EventArgs e)
        {
            btnInserir.Enabled = true;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            txtID_Receita.Enabled = false;
            txtValor.Enabled = true;
            cmbTipoReceita.Enabled = true;
            txtObservacao.Enabled = true;
            dt_Recebimento.Enabled = true;
            btnPesquisar.Enabled = false;
        }
        private void lblAlterar1_Click(object sender, EventArgs e)
        {
            btnInserir.Enabled = false;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = true;
            txtID_Receita.Enabled = true;
            txtValor.Enabled = true;
            cmbTipoReceita.Enabled = true;
            txtObservacao.Enabled = true;
            dt_Recebimento.Enabled = true;
            btnPesquisar.Enabled = true;
        }

        private void lblExcluir_Click(object sender, EventArgs e)
        {
            btnInserir.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = true;
            txtID_Receita.Enabled = true;
            txtValor.Enabled = false;
            cmbTipoReceita.Enabled = false;
            txtObservacao.Enabled = false;
            dt_Recebimento.Enabled = false;
            btnPesquisar.Enabled = true;
        }

        // TECLA DE ATALHO PRA CHAMAR TODOS OS DADOS F3
        private void txtID_Receita_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            {
                frmConsultaReceitas consultaReceitasAtalho = new frmConsultaReceitas();
                consultaReceitasAtalho.ShowDialog();
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmConsultaReceitas consultaReceitasAtalho = new frmConsultaReceitas();
            consultaReceitasAtalho.ShowDialog();
        }

        private void frmReceitas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }

        }
        // COXEÇÃO COM O BANCO PARA RETORNAR DADOS PARA COMBOX
        private DataTable carregaTipoReceita()
        {
            sql = "select ID_tblTipoReceitas, descricao from tblTipoReceitas order by descricao";
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            return dt;
        }
        // METODO PARA LIMPAR
        private void limpar()
        {
            txtID_Receita.Clear();
            txtValor.Clear();
            txtObservacao.Clear();
            dt_Recebimento.Value = DateTime.Today;
            txtID_Receita.Focus();
        }
        // BOTÃO INSERIR
        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                if (txtValor.Text != "" && txtValor.Text != "0,00")
                {
                    sql = String.Format("insert into tblReceitas (valorReceita, dt_recebimento, observacao, ID_tblTipoReceitas) values ('{0}','{1}','{2}','{3}')", txtValor.Text.Replace(",", "."), dt_Recebimento.Value.ToString("yyyy-MM-dd"), txtObservacao.Text, cmbTipoReceita.SelectedValue.ToString());
                    da = new SqlDataAdapter(sql, con);
                    da.Fill(dt, "controlador_gastos");
                    MessageBox.Show("Cadastro realizado com sucesso");
                    limpar();
                }
                else
                {
                    MessageBox.Show("Favor preencher os campos obrigatórios !");
                }
            }
            else
            {
                MessageBox.Show("Não foi possível conectar ao servidor !");
            }
        }
        // BOTÃO ALTERAR
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                if (txtID_Receita.Text != "" && txtValor.Text != "0,00" && txtValor.Text != "")
                {
                    sql = String.Format("Update tblReceitas set valorReceita = '{0}', dt_recebimento = '{1}', observacao = '{2}', ID_tblTipoReceitas = '{3}' where ID_tblReceitas = '{4}'", txtValor.Text.Replace(",", "."), dt_Recebimento.Value.ToString("yyyy-MM-dd"), txtObservacao.Text, cmbTipoReceita.SelectedValue.ToString(), txtID_Receita.Text);
                    da = new SqlDataAdapter(sql, con);
                    da.Fill(dt, "controlador_gastos");
                    MessageBox.Show("Cadastro alterado com sucesso");
                    limpar();
                }
                else
                {
                    MessageBox.Show("Favor preencher os campos obrigatórios !");
                }
            }
            else
            {
                MessageBox.Show("Não foi possível conectar ao servidor !");
            }
        }
        // BOTÃO EXCLUIR
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                if (txtID_Receita.Text != "")
                {
                    sql = String.Format("delete from tblReceitas where ID_tblReceitas = '{0}'", txtID_Receita.Text);
                        da = new SqlDataAdapter(sql, con);
                    da.Fill(dt, "controlador_gastos");
                    MessageBox.Show("Cadastro excluído com sucesso !");
                    limpar();
                }
                else
                {
                    MessageBox.Show("Favor preencher os campos obrigatórios !");
                }
            }
            else
            {
                MessageBox.Show("Não foi possível conectar ao servidor !");
            }
        }
    }
}
