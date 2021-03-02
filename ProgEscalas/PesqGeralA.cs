using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgEscalas
{
    public partial class PesqGeralA : Form
    {
        public string retornoID, retornoDesc;
        public PesqGeralA()
        {
            InitializeComponent();
        }
        private void PesqGeraS_Load(object sender, EventArgs e)
        {
            retornoID = null;
            retornoDesc = null;
            txtPesq.Clear();
        }

        private void btConfPesq_Click(object sender, EventArgs e)
        {
            int linha = Convert.ToInt32(dgvPesq.CurrentCell.RowIndex);

            retornoID = Convert.ToString(dgvPesq[0, linha].Value.ToString());
            retornoDesc = Convert.ToString(dgvPesq[1, linha].Value.ToString());
            Close();
        }

        private void PesqGeral_Load_1(object sender, EventArgs e)
        {
            txtPesq.Focus();
        }

        private void dgvPesq_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = Convert.ToInt32(dgvPesq.CurrentCell.RowIndex);

            retornoID = Convert.ToString(dgvPesq[0, linha].Value.ToString());
            retornoDesc = Convert.ToString(dgvPesq[1, linha].Value.ToString());
            Close();
        }
    }
}
