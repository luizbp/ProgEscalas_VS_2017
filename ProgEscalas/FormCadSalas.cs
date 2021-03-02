using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgEscalas.Models;

namespace ProgEscalas
{
    public partial class FormCadSalas : Form
    {
        int linha = 0;
        public FormCadSalas()
        {
            InitializeComponent();
        }

        private void FormCadSalas_Load(object sender, EventArgs e)
        {
            dgvSalas.Columns.Add("Sala", "Sala");
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (TxtSala.Text != String.Empty)
            {
                if (verificarEx() == false)
                {
                    dgvSalas.Rows.Add(TxtSala.Text);
                    TxtSala.Clear();
                    TxtSala.Focus();
                }

                else MessageBox.Show("Esse Sala já esta cadastrada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool verificarEx()
        {
            int count = 0;
            for (int op = 0; op <= dgvSalas.Rows.Count - 1; op++)
            {
                if (TxtSala.Text == Convert.ToString(dgvSalas.Rows[op].Cells[0].Value))
                {
                    count++;
                }
            }
            if (count == 0)
                return false;
            else return true;
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvSalas.Rows.RemoveAt(linha);
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSalas_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvSalas.Rows.Count > 1)
                linha = Convert.ToInt32(dgvSalas.CurrentCell.RowIndex);
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (dgvSalas.RowCount != 1)
            {
                using (var db = new dbEscala())
                {
                    try
                    {
                        for (int op = 0; op < dgvSalas.RowCount - 1; op++)
                        {
                            salas sa = new salas();
                            sa.DESCRICAO = Convert.ToString(dgvSalas.Rows[op].Cells[0].Value);
                            db.Entry(sa).State = System.Data.Entity.EntityState.Added;
                            db.SaveChanges();
                        }
                        MessageBox.Show("Cadastro realizado com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvSalas.Rows.Clear();
                        TxtSala.Focus();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Erro" + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Não há nada cadastrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
