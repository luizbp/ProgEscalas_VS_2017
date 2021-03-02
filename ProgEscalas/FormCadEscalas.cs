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
    public partial class FormCadEscalas : Form
    {
        public FormCadEscalas()
        {
            InitializeComponent();
        }
        //----------------------------------PESQUISA DAS SALAS--------------------------------------------
        PesqGeralS pesq = new PesqGeralS();
        private void btPesqSala_Click(object sender, EventArgs e)
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
            pesq.dgvPesq.DataSource = pesquisarSala(pesq.txtPesq.Text);
            db.Dispose();

        }
        private object pesquisarSala(string pesquisa)
        {
            dbEscala db = new dbEscala();

            return db.salas.Where(d => d.DESCRICAO.Contains(pesquisa)).Select(d => new
            {
                ID = d.ID,
                DESCRIÇÃO = d.DESCRICAO,

            }).ToList();
        }
        //------------------------------ FIM PESQUISA DAS SALAS -------------------------------------------------
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

        //------------------------------- PESQUISA DOS ALUNOS ---------------------------------------------
        PesqGeralA pesq2 = new PesqGeralA();
        private void btPesqAluno_Click(object sender, EventArgs e)
        {
            if (txtIDSala.Text != String.Empty)
            {
                pesq2.Load += pesqAluno_Load;
                pesq2.btPesqDoc.Click += btPAluno_Click;
                pesq2.ShowDialog();
                preencheCampos(txtIDAluno, txtDescAluno, pesq2.retornoID, pesq2.retornoDesc);
            }
            else MessageBox.Show("Selecione a sala desejada!! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void pesqAluno_Load(object sender, EventArgs e)
        {
            int idsala = Convert.ToInt32(txtIDSala.Text);
            DateTime hoje = DateTime.Now.Date;
            try
            {
                using (var db = new dbEscala())
                {
                    pesq2.dgvPesq.DataSource = db.escala.Where(d => d.sal_aluno.IDSALA == idsala
                                                                && d.sal_aluno.alunos.ATIVO == 1
                                                                && d.DT_FINAL <= hoje
                                                                && d.sal_aluno.alunos.DT_INICIO <= hoje
                                                                && d.sal_aluno.alunos.DT_FINAL >= hoje
                                                                ).Select(d => new
                    {
                        ID = d.sal_aluno.IDALUNO,
                        NOME = d.sal_aluno.alunos.NOME,
                        CPF = d.sal_aluno.alunos.CPF
                    }).ToList();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btPAluno_Click(object sender, EventArgs e)
        {
            dbEscala db = new dbEscala();
            pesq2.dgvPesq.DataSource = pesquisarAluno(pesq.txtPesq.Text);
            db.Dispose();

        }
        private object pesquisarAluno(string pesquisa)
        {
            DateTime hoje = DateTime.Now.Date;
            DateTime dtliberada = hoje.AddDays(-30);
            int idsala = Convert.ToInt32(txtIDSala.Text);
            dbEscala db = new dbEscala();

            return db.escala.Where(d => d.sal_aluno.alunos.NOME.Contains(pesquisa) 
                                    && d.sal_aluno.IDSALA == idsala
                                    && d.sal_aluno.alunos.ATIVO == 1
                                    && d.DT_FINAL <= dtliberada
                                    && d.sal_aluno.alunos.DT_INICIO >= hoje
                                    && d.sal_aluno.alunos.DT_FINAL <= hoje
                                    ).Select(d => new
            {
                ID = d.sal_aluno.IDALUNO,
                NOME = d.sal_aluno.alunos.NOME,
                CPF = d.sal_aluno.alunos.CPF
            }).ToList();
        }
        //------------------------------ FIM PESQUISA ALUNO ---------------------------------------------
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (txtIDAluno.Text != String.Empty && txtIDSala.Text != String.Empty)
            {
                if (verifica_cadastro())
                {
                    int idsala = Convert.ToInt32(txtIDSala.Text);
                    int idaluno = Convert.ToInt32(txtIDAluno.Text);
                    if (verificar_data())
                    {
                        using (var db = new dbEscala())
                        {
                            int idsalaaluno = db.sal_aluno.Where(d => d.IDALUNO == idaluno && d.IDSALA == idsala).FirstOrDefault().ID;
                            dgvEscalas.Rows.Add(txtDescAluno.Text, idsalaaluno, Convert.ToDateTime(dtpInicio.Text), Convert.ToDateTime(dtpTermino.Text), txtIDAluno.Text);
                            txtDescAluno.Clear();
                            txtIDAluno.Clear();
                            txtIDSala.Clear();
                            txtNomeSala.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("As datas não não correspondentes!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dtpInicio.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Este Aluno já esta cadastrado!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

        }

        private bool verificar_data()
        {
            DateTime inicio = Convert.ToDateTime(dtpInicio.Text);
            DateTime fim = Convert.ToDateTime(dtpTermino.Text);
            if (inicio > fim || inicio.Day < DateTime.Now.Day)
                return false;
            else return true;
        }

        private bool verifica_cadastro()
        {
            int count = 0;
            try
            {
                using (var db = new dbEscala())
                {
                    if (dgvEscalas.RowCount > 1)
                    {
                        for(int op = 0; op < dgvEscalas.RowCount - 1; op++)
                        {
                            int id = Convert.ToInt32(dgvEscalas.Rows[op].Cells[4].Value);
                            if (Convert.ToInt32(txtIDAluno.Text) == id)
                                count++;
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (count != 0)
                return false;
            else return true;
        }

        private void FormCadEscalas_Load(object sender, EventArgs e)
        {
            dgvEscalas.Columns.Add("Nome", "Nome");
            dgvEscalas.Columns.Add("IDSA", "IDSA");
            dgvEscalas.Columns.Add("Dt Inicio", "Dt Inicio");
            dgvEscalas.Columns.Add("Dt Término", "Dt Término");
            dgvEscalas.Columns.Add("IDALUNO", "IDALUNO");

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new dbEscala())
                {
                    if (dgvEscalas.RowCount > 1)
                    {

                        for (int op = 0; op < dgvEscalas.RowCount - 1; op++)
                        {
                            int idsal = Convert.ToInt32(dgvEscalas.Rows[op].Cells[1].Value);
                            int ides = db.escala.Where(d => d.IDSAL_ALUNO == idsal).FirstOrDefault().ID;
                            escala es = db.escala.Find(ides);
                            es.DT_INICIO = Convert.ToDateTime(dtpInicio.Text);
                            es.DT_FINAL = Convert.ToDateTime(dtpTermino.Text).AddDays(30);
                            es.USE = 1;
                            db.Entry(es).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                            

                        }
                        config cf = db.config.Find(1);
                        cf.DT_INICIO = Convert.ToDateTime(dtpInicio.Text);
                        cf.DT_FINAL = Convert.ToDateTime(dtpTermino.Text);
                        db.Entry(cf).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Escalas cadastradas com sucesso!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDescAluno.Clear();
                        txtIDAluno.Clear();
                        txtIDSala.Clear();
                        txtNomeSala.Clear();
                        dgvEscalas.Rows.Clear();

                    }
                    else MessageBox.Show("Nenhum aluno cadastrado ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
