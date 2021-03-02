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
using System.IO;
using iTextSharp;//E A BIBLIOTECA ITEXTSHARP E SUAS EXTENÇÕES
using iTextSharp.text;//ESTENSAO 1 (TEXT)
using iTextSharp.text.pdf;//ESTENSAO 2 (PDF)

namespace ProgEscalas
{
    public partial class FormRelatorio : Form
    {
        string local;
        public FormRelatorio()
        {
            InitializeComponent();
        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void rbAtual_CheckedChanged(object sender, EventArgs e)
        {
            DateTime hoje = DateTime.Now.Date;
            try
            {
                using (var db = new dbEscala())
                {
                    dgvRelatorio.DataSource = db.escala.Where(d => d.DT_INICIO <= hoje && d.DT_FINAL > hoje).Select(d => new
                    {
                        Nome = d.sal_aluno.alunos.NOME,
                        Sala = d.sal_aluno.salas.DESCRICAO,
                        Data_Inicio = d.DT_INICIO,
                        Data_Término = d.DT_FINAL
                    }).OrderBy(d => d.Sala).ToList();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void rbCompleto_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new dbEscala())
                {
                    dgvRelatorio.DataSource = db.escala.Select(d => new
                    {
                        Nome = d.sal_aluno.alunos.NOME,
                        Sala = d.sal_aluno.salas.DESCRICAO,
                        Data_Inicio = d.DT_INICIO,
                        Data_Término = d.DT_FINAL
                    }).OrderBy(d => d.Sala).ToList();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btPasta_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPasta.Text = folderBrowserDialog1.SelectedPath;
                local = folderBrowserDialog1.SelectedPath;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtNome.Text != String.Empty && txtPasta.Text != String.Empty)
            {
                btGerar.Enabled = true;
            }
            else
            {
                btGerar.Enabled = false;
            }
            if (dgvRelatorio.Rows.Count >= 1)
                btPasta.Enabled = true;
            if (txtNome.Text != String.Empty && txtPasta.Text != String.Empty)
            {
                btGerar.Enabled = true;
            }
            else
            {
                btGerar.Enabled = false;
            }
        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            try
            {

                //Creating iTextSharp Table from the DataTable data
                PdfPTable pdfTable = new PdfPTable(dgvRelatorio.ColumnCount);
                pdfTable.PaddingTop = 0;
                pdfTable.DefaultCell.Padding = 4;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = 1;
                pdfTable.DefaultCell.BorderWidth = 0;
                //Adding Header row
                foreach (DataGridViewColumn column in dgvRelatorio.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BorderColor = BaseColor.BLACK;
                    cell.BorderWidth = 0;
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    cell.Padding = 8;
                    cell.BorderWidthRight = 1;
                    cell.HorizontalAlignment = 1;
                    pdfTable.AddCell(cell);
                }

                //Adding DataRow
                foreach (DataGridViewRow row in dgvRelatorio.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.DefaultCell.HorizontalAlignment = 1;
                        pdfTable.AddCell(cell.Value.ToString());
                    }

                }

                //Exporting to PDF
                string folderPath = local + @"\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                using (FileStream stream = new FileStream(folderPath + txtNome.Text + ".pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 100f, 100f, 100f, 30f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    //criando a variavel para paragrafo
                    Paragraph paragrafo = new Paragraph();
                    //etipulando o alinhamneto
                    paragrafo.Alignment = Element.ALIGN_CENTER;
                    paragrafo.Font.Size = 35;
                    //Alinhamento Justificado
                    //adicioando texto
                    paragrafo.Add("Escalas"); ;
                    Paragraph pa = new Paragraph();
                    //etipulando o alinhamneto
                    pa.Alignment = Element.ALIGN_CENTER;
                    pa.Font.Size = 35;
                    //Alinhamento Justificado
                    //adicioando texto
                    pa.Add("                                ");
                    Paragraph data = new Paragraph();
                    data.Alignment = Element.ALIGN_LEFT;
                    data.Font.Size = 15;
                    data.Add("Data: " + DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss"));
                    Paragraph seicho = new Paragraph();
                    seicho.Alignment = Element.ALIGN_LEFT;
                    seicho.Font.Size = 15;
                    seicho.Add("Leticia Braga");
                    pdfDoc.Add(paragrafo);
                    pdfDoc.Add(pa);
                    pdfDoc.Add(seicho);
                    pdfDoc.Add(data);
                    pdfDoc.Add(pa);
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documendo gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start(folderPath + txtNome.Text + ".pdf");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro " + err, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
