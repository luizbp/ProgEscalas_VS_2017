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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            try
            {
                dbEscala db = new dbEscala();
                int teste = db.alunos.Count();
            }
            catch
            {
                MessageBox.Show("Erro ao tentar conexão com o banco, contate um administrador!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }
            InitializeComponent();
        }

        private void visitantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadAluno fo = new FormCadAluno();
            fo.ShowDialog();
            carregar();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadSalas fo = new FormCadSalas();
            fo.ShowDialog();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            timer1.Start();
            DateTime hoje = DateTime.Now.Date;
            try
            {
                using (var db = new dbEscala())
                {
                    dgvEscalas.DataSource = db.escala.Where(d => d.DT_INICIO <= hoje && d.DT_FINAL >= hoje && d.USE == 1).Select(d => new
                    {
                        Nome = d.sal_aluno.alunos.NOME,
                        Sala = d.sal_aluno.salas.DESCRICAO,
                        Data_Inicio = d.DT_INICIO,
                        Data_Término = d.DT_FINAL
                    }).OrderBy(d => d.Sala).ToList();

                    dgvAlunos.DataSource = db.escala.Where(d => d.sal_aluno.alunos.ATIVO == 1).Select(d => new
                    {
                        Nome = d.sal_aluno.alunos.NOME,
                        CPF = d.sal_aluno.alunos.CPF,
                        Escalas = d.sal_aluno.salas.DESCRICAO,
                        DataEscala = d.DT_FINAL

                    }).OrderBy(d => d.Nome).ToList();

                    config cf = db.config.Find(1);
                    int hj = DateTime.Now.Day;//dias atuais
                    int dt = cf.DT_FINAL.Day;// dias da escala gravada
                    int date = dt - hj;// verifica quantos dias faltam para o término da escala
                    lbDtInicio.Text = cf.DT_INICIO.ToString("dd/MM/yyyy");
                    lbDtFinal.Text = cf.DT_FINAL.ToString("dd/MM/yyyy");
                    if (date > 0)
                        lbFaltam.Text = "Faltam " + date + " dias para o fim da escala";
                    else lbFaltam.Text = "Ultima escala Finalizada!!";

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvAlunos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DateTime hoje = DateTime.Now.Date;
            if (e.ColumnIndex == 3 && Convert.ToDateTime(e.Value) <= hoje)
            {
                dgvAlunos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.ForestGreen;
            }
            if (e.ColumnIndex == 3 && Convert.ToDateTime(e.Value) > hoje)
            {
                dgvAlunos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.OrangeRed;
            }
            //if (e.ColumnIndex == 3 && Convert.ToDateTime(e.Value).AddDays(30) > hoje)
            //{
            //    dgvAlunos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkRed;
            //}

        }

        private void visitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadEscalas fo = new FormCadEscalas();
            try
            {
                using (var db = new dbEscala())
                {
                    config cf = db.config.Find(1);
                    if (cf.DT_FINAL.Date >= DateTime.Now.Date)
                    {
                        if (MessageBox.Show("A última escala ainda está em andamento, deseja prosseguir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            fo.ShowDialog();
                            carregar();
                        }
                    }
                    else fo.ShowDialog(); carregar();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHr.Text = Convert.ToString(DateTime.Now.ToString("HH:mm:ss"));
            lbDate.Text = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy"));
        }

        private void lbDtFinal_Click(object sender, EventArgs e)
        {

        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorio fo = new FormRelatorio();
            fo.ShowDialog();
            carregar();
        }

        private void carregar()
        {
            DateTime hoje = DateTime.Now.Date;
            try
            {
                using (var db = new dbEscala())
                {
                    dgvEscalas.DataSource = db.escala.Where(d => d.DT_INICIO <= hoje && d.DT_FINAL >= hoje && d.USE == 1).Select(d => new
                    {
                        Nome = d.sal_aluno.alunos.NOME,
                        Sala = d.sal_aluno.salas.DESCRICAO,
                        Data_Inicio = d.DT_INICIO,
                        Data_Término = d.DT_FINAL
                    }).OrderBy(d => d.Sala).ToList();

                    dgvAlunos.DataSource = db.escala.Where(d => d.sal_aluno.alunos.ATIVO == 1).Select(d => new
                    {
                        Nome = d.sal_aluno.alunos.NOME,
                        CPF = d.sal_aluno.alunos.CPF,
                        Escalas = d.sal_aluno.salas.DESCRICAO,
                        DataEscala = d.DT_FINAL

                    }).OrderBy(d => d.Nome).ToList();

                    config cf = db.config.Find(1);
                    int hj = DateTime.Now.Day;//dias atuais
                    int dt = cf.DT_FINAL.Day;// dias da escala gravada
                    int date = dt - hj;// verifica quantos dias faltam para o término da escala
                    lbDtInicio.Text = cf.DT_INICIO.ToString("dd/MM/yyyy");
                    lbDtFinal.Text = cf.DT_FINAL.ToString("dd/MM/yyyy");
                    if (date > 0)
                        lbFaltam.Text = "Faltam " + date + " dias para o fim da escala";
                    else lbFaltam.Text = "Ultima escala Finalizada!!";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void suporteOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormSuporte fo = new FormSuporte();
            // fo.Show();
            System.Diagnostics.Process.Start("https://tawk.to/chat/599b3619dbb01a218b4dd8c4/default/?$_tawk_popout=true");
        }

        private void informaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSobre fo = new FormSobre();
            fo.ShowDialog();
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((MessageBox.Show("Encerrar programa?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                System.Environment.Exit(0);
            else e.Cancel = true;
                    
                
        }
    }
}
