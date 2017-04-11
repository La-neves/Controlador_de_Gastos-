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
    public partial class frmTelaRelatorioReceita : Form
    {
        public frmTelaRelatorioReceita()
        {
            InitializeComponent();
        }

        private void frmTelaRelatorioReceita_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'controlador_gastosDataSet.tblReceitas' table. You can move, or remove it, as needed.
            this.tblReceitasTableAdapter.Fill(this.controlador_gastosDataSet.tblReceitas);

            this.reportViewer1.RefreshReport();
        }
    }
}
