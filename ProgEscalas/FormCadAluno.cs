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
    public partial class FormCadAluno : Form
    {
        int linha = 0;
        public FormCadAluno()
        {
            InitializeComponent();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != String.Empty && dgvSalas.RowCount != 1 && mskCpf.Text != String.Empty)
            {
                if (verifica_cpf(mskCpf.Text))
                {
                    //if (verificar_data())
                    //{
                        if (verificarEx() == false)
                        {
                            int nSalas = dgvSalas.RowCount - 1;

                            for (int op = 0; op < nSalas; op++)
                            {
                                dgvAlunos.Rows.Add(txtNome.Text, mskCpf.Text, Convert.ToDateTime(dtpInicio.Text), Convert.ToDateTime(dtpTermino.Text), Convert.ToInt32(dgvSalas.Rows[op].Cells[0].Value));
                            }
                            dgvSalas.Rows.Clear();
                            mskCpf.Clear();
                            txtNome.Clear();
                            txtNome.Focus();

                        }
                        else MessageBox.Show("Esse aluno já esta cadastrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("As datas não não correspondentes!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //    dtpInicio.Focus();
                    //}
                }
                else MessageBox.Show("Este Aluno já existe!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FormCadAluno_Load(object sender, EventArgs e)
        {
            dgvAlunos.Columns.Add("Nome", "Nome");
            dgvAlunos.Columns.Add("CPF", "CPF");
            dgvAlunos.Columns.Add("Entrada", "Entrada");
            dgvAlunos.Columns.Add("Saida", "Saida");
            dgvAlunos.Columns.Add("IDSala", "IDSaLa");
            dgvSalas.Columns.Add("ID", "ID");
            dgvSalas.Columns.Add("Sala", "Sala");
        }

        private bool verificarEx()
        {
            int count = 0;
            for (int op = 0; op <= dgvAlunos.Rows.Count - 1; op++)
            {
                if (mskCpf.Text == Convert.ToString(dgvAlunos.Rows[op].Cells[1].Value))
                {
                    count++;
                }
            }
            if (count == 0)
                return false;
            else return true;
        }

        private void dgvAlunos_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvAlunos.Rows.RemoveAt(linha);
            }
            catch
            {
                MessageBox.Show("Nenhum registro selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        PesqGeralS pesq = new PesqGeralS();
        private void btPesqNome_Click(object sender, EventArgs e)
        {
            pesq.Load += pesqDiag_Load;
            pesq.btPesqDoc.Click += btPDiag_Click;
            pesq.ShowDialog();
            preencheCampos(txtIDSala, txtNomeSala, pesq.retornoID, pesq.retornoDesc);
        }

        private void pesqDiag_Load(object sender, EventArgs e)
        {
            using (var db = new dbEscala())
            {
                pesq.dgvPesq.DataSource = db.salas.Select(d => new
                {
                    ID = d.ID,
                    DESCRIÇÃO = d.DESCRICAO
                }).ToList();
            }
        }
        private void btPDiag_Click(object sender, EventArgs e)
        {
            dbEscala db = new dbEscala();
            pesq.dgvPesq.DataSource = pesquisarAluno(pesq.txtPesq.Text);
            db.Dispose();

        }
        private object pesquisarAluno(string pesquisa)
        {
            dbEscala db = new dbEscala();

            return db.salas.Where(d => d.DESCRICAO.Contains(pesquisa)).Select(d => new
            {
                ID = d.ID,
                DESCRIÇÃO = d.DESCRICAO,

            }).ToList();
        }
        private void preencheCampos(object sender1, object sender2, string ID, string Desc)
        {
            TextBox tID = sender1 as TextBox;
            if (!string.IsNullOrWhiteSpace(ID))
                tID.Text = ID;
            tID.BackColor = Color.White;


            TextBox tDesc = sender2 as TextBox;
            if (!string.IsNullOrWhiteSpace(Desc))
                tDesc.Text = Desc;


        }

        private void btAddSala_Click(object sender, EventArgs e)
        {
            if (txtIDSala.Text != String.Empty && txtNomeSala.Text != String.Empty)
            {
                dgvSalas.Rows.Add(txtIDSala.Text, txtNomeSala.Text);
                txtNomeSala.Clear();
                txtIDSala.Clear();
            }
            else
            {
                MessageBox.Show("Selecione uma Sala!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvSalas_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvSalas.Rows.Count > 1)
                linha = Convert.ToInt32(dgvSalas.CurrentCell.RowIndex);
        }

        private void deletarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                dgvSalas.Rows.RemoveAt(linha);
            }
            catch
            {
                MessageBox.Show("Nenhum registro selecionado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (dgvAlunos.RowCount > 1)
            {
                DateTime hoje = DateTime.Now.Date;
                try
                {
                    using (var db = new dbEscala())
                    {

                        for (int op = 0; op < dgvAlunos.RowCount - 1; op++)
                        {
                            string cpf = Convert.ToString(dgvAlunos.Rows[op].Cells[1].Value);
                            int prima = db.alunos.Where(d => d.CPF == cpf).Count();
                            if (prima != 0)
                            {
                                int idaluno = db.alunos.Where(d => d.CPF == cpf).FirstOrDefault().ID;
                                alunos al = db.alunos.Find(idaluno);
                                sal_aluno sa = new sal_aluno();
                                sa.IDALUNO = al.ID;
                                sa.IDSALA = Convert.ToInt32(dgvAlunos.Rows[op].Cells[4].Value);
                                db.Entry(sa).State = System.Data.Entity.EntityState.Added;
                                db.SaveChanges();
                                escala es = new escala();
                                es.IDSAL_ALUNO = sa.ID;
                                es.DT_INICIO = hoje;
                                es.DT_FINAL = hoje;
                                db.Entry(es).State = System.Data.Entity.EntityState.Added;
                                db.SaveChanges();
                            }
                            else
                            {
                                alunos al = new alunos();
                                al.NOME = Convert.ToString(dgvAlunos.Rows[op].Cells[0].Value);
                                al.CPF = Convert.ToString(dgvAlunos.Rows[op].Cells[1].Value);
                                al.DT_INICIO = Convert.ToDateTime(dgvAlunos.Rows[op].Cells[2].Value);
                                al.DT_FINAL = Convert.ToDateTime(dgvAlunos.Rows[op].Cells[3].Value);
                                al.ATIVO = 1;
                                al.DELETADO = 0;
                                db.Entry(al).State = System.Data.Entity.EntityState.Added;
                                db.SaveChanges();
                                sal_aluno sa = new sal_aluno();
                                sa.IDALUNO = al.ID;
                                sa.IDSALA = Convert.ToInt32(dgvAlunos.Rows[op].Cells[4].Value);
                                db.Entry(sa).State = System.Data.Entity.EntityState.Added;
                                db.SaveChanges();
                                escala es = new escala();
                                es.IDSAL_ALUNO = sa.ID;
                                es.DT_INICIO = hoje;
                                es.DT_FINAL = hoje;
                                db.Entry(es).State = System.Data.Entity.EntityState.Added;
                                db.SaveChanges();
                            }
                        }
                        dgvAlunos.Rows.Clear();
                        MessageBox.Show("Aluno cadastrado com sucesso!!! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNome.Focus();

                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Nenhum Aluno cadastrado!! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private bool verifica_cpf(string cpf)
        {
            int count = 0;
            try
            {
                using (var db = new dbEscala())
                {
                    if (db.alunos.Count() != 0)
                    {
                        int prima = db.alunos.First().ID - 1;
                        int caluno = db.alunos.Count();
                        for (int op = 1; op < caluno + 1; op++)
                        {
                            int ID = prima + op;
                            alunos al = db.alunos.Find(ID);
                            if (cpf == al.CPF)
                                count++;
                        }
                    }
                }
            }catch (Exception err)
            {
                
            }
            if (count != 0)
                return false;
            else return true;
        }

        private void mskCpf_Click(object sender, EventArgs e)
        {
            mskCpf.SelectAll();
        }

        private bool verificar_data()
        {
            DateTime inicio = Convert.ToDateTime(dtpInicio.Text);
            DateTime fim = Convert.ToDateTime(dtpTermino.Text);
            if (inicio > fim || inicio.Day < DateTime.Now.Day)
                return false;
            else return true;
        }

        private void gbCadastro_Enter(object sender, EventArgs e)
        {

        }

    }
}
