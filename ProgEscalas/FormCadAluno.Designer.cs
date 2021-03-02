namespace ProgEscalas
{
    partial class FormCadAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadAluno));
            this.gbCadastro = new System.Windows.Forms.GroupBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btPesqNome = new System.Windows.Forms.Button();
            this.txtNomeSala = new System.Windows.Forms.TextBox();
            this.txtIDSala = new System.Windows.Forms.TextBox();
            this.btAddSala = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.dbSalas = new System.Windows.Forms.GroupBox();
            this.dgvSalas = new System.Windows.Forms.DataGridView();
            this.cmsSalas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpTermino = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.cmsAluno = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAlunos = new System.Windows.Forms.GroupBox();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.gbCadastro.SuspendLayout();
            this.dbSalas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalas)).BeginInit();
            this.cmsSalas.SuspendLayout();
            this.cmsAluno.SuspendLayout();
            this.gbAlunos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCadastro
            // 
            this.gbCadastro.Controls.Add(this.mskCpf);
            this.gbCadastro.Controls.Add(this.label4);
            this.gbCadastro.Controls.Add(this.btPesqNome);
            this.gbCadastro.Controls.Add(this.txtNomeSala);
            this.gbCadastro.Controls.Add(this.txtIDSala);
            this.gbCadastro.Controls.Add(this.btAddSala);
            this.gbCadastro.Controls.Add(this.btAdicionar);
            this.gbCadastro.Controls.Add(this.dbSalas);
            this.gbCadastro.Controls.Add(this.dtpTermino);
            this.gbCadastro.Controls.Add(this.dtpInicio);
            this.gbCadastro.Controls.Add(this.label3);
            this.gbCadastro.Controls.Add(this.txtNome);
            this.gbCadastro.Controls.Add(this.label2);
            this.gbCadastro.Controls.Add(this.label5);
            this.gbCadastro.Controls.Add(this.label1);
            this.gbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastro.Location = new System.Drawing.Point(12, 12);
            this.gbCadastro.Name = "gbCadastro";
            this.gbCadastro.Size = new System.Drawing.Size(655, 380);
            this.gbCadastro.TabIndex = 3;
            this.gbCadastro.TabStop = false;
            this.gbCadastro.Text = "Cadastro";
            this.gbCadastro.Enter += new System.EventHandler(this.gbCadastro_Enter);
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(15, 72);
            this.mskCpf.Mask = "000000000/00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(111, 20);
            this.mskCpf.TabIndex = 2;
            this.mskCpf.Click += new System.EventHandler(this.mskCpf_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sala:";
            // 
            // btPesqNome
            // 
            this.btPesqNome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPesqNome.BackgroundImage")));
            this.btPesqNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPesqNome.FlatAppearance.BorderSize = 0;
            this.btPesqNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesqNome.ForeColor = System.Drawing.Color.Transparent;
            this.btPesqNome.Location = new System.Drawing.Point(316, 185);
            this.btPesqNome.Name = "btPesqNome";
            this.btPesqNome.Size = new System.Drawing.Size(29, 29);
            this.btPesqNome.TabIndex = 6;
            this.btPesqNome.UseVisualStyleBackColor = true;
            this.btPesqNome.Click += new System.EventHandler(this.btPesqNome_Click);
            // 
            // txtNomeSala
            // 
            this.txtNomeSala.Location = new System.Drawing.Point(85, 192);
            this.txtNomeSala.Name = "txtNomeSala";
            this.txtNomeSala.ReadOnly = true;
            this.txtNomeSala.Size = new System.Drawing.Size(225, 20);
            this.txtNomeSala.TabIndex = 12;
            // 
            // txtIDSala
            // 
            this.txtIDSala.Location = new System.Drawing.Point(15, 192);
            this.txtIDSala.Name = "txtIDSala";
            this.txtIDSala.ReadOnly = true;
            this.txtIDSala.Size = new System.Drawing.Size(68, 20);
            this.txtIDSala.TabIndex = 13;
            // 
            // btAddSala
            // 
            this.btAddSala.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAddSala.BackgroundImage")));
            this.btAddSala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAddSala.FlatAppearance.BorderSize = 0;
            this.btAddSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddSala.Location = new System.Drawing.Point(351, 185);
            this.btAddSala.Name = "btAddSala";
            this.btAddSala.Size = new System.Drawing.Size(29, 29);
            this.btAddSala.TabIndex = 7;
            this.btAddSala.UseVisualStyleBackColor = true;
            this.btAddSala.Click += new System.EventHandler(this.btAddSala_Click);
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAdicionar.BackgroundImage")));
            this.btAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAdicionar.FlatAppearance.BorderSize = 0;
            this.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionar.Location = new System.Drawing.Point(613, 338);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(35, 34);
            this.btAdicionar.TabIndex = 8;
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // dbSalas
            // 
            this.dbSalas.Controls.Add(this.dgvSalas);
            this.dbSalas.Location = new System.Drawing.Point(12, 218);
            this.dbSalas.Name = "dbSalas";
            this.dbSalas.Size = new System.Drawing.Size(639, 114);
            this.dbSalas.TabIndex = 9;
            this.dbSalas.TabStop = false;
            this.dbSalas.Text = "Salas Cadastrados ";
            // 
            // dgvSalas
            // 
            this.dgvSalas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSalas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalas.ContextMenuStrip = this.cmsSalas;
            this.dgvSalas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalas.Location = new System.Drawing.Point(3, 16);
            this.dgvSalas.Name = "dgvSalas";
            this.dgvSalas.ReadOnly = true;
            this.dgvSalas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalas.Size = new System.Drawing.Size(633, 95);
            this.dgvSalas.TabIndex = 0;
            this.dgvSalas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvSalas_MouseDown);
            // 
            // cmsSalas
            // 
            this.cmsSalas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletarToolStripMenuItem1});
            this.cmsSalas.Name = "cmsSalas";
            this.cmsSalas.Size = new System.Drawing.Size(112, 26);
            // 
            // deletarToolStripMenuItem1
            // 
            this.deletarToolStripMenuItem1.Name = "deletarToolStripMenuItem1";
            this.deletarToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.deletarToolStripMenuItem1.Text = "Deletar";
            this.deletarToolStripMenuItem1.Click += new System.EventHandler(this.deletarToolStripMenuItem1_Click);
            // 
            // dtpTermino
            // 
            this.dtpTermino.Location = new System.Drawing.Point(15, 153);
            this.dtpTermino.Name = "dtpTermino";
            this.dtpTermino.Size = new System.Drawing.Size(295, 20);
            this.dtpTermino.TabIndex = 4;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(15, 112);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(295, 20);
            this.dtpInicio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data de término:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(473, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data de Inicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(592, 608);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 9;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // cmsAluno
            // 
            this.cmsAluno.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletarToolStripMenuItem});
            this.cmsAluno.Name = "contextMenuStrip1";
            this.cmsAluno.Size = new System.Drawing.Size(112, 26);
            // 
            // deletarToolStripMenuItem
            // 
            this.deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            this.deletarToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.deletarToolStripMenuItem.Text = "Deletar";
            this.deletarToolStripMenuItem.Click += new System.EventHandler(this.deletarToolStripMenuItem_Click);
            // 
            // gbAlunos
            // 
            this.gbAlunos.Controls.Add(this.dgvAlunos);
            this.gbAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAlunos.Location = new System.Drawing.Point(22, 398);
            this.gbAlunos.Name = "gbAlunos";
            this.gbAlunos.Size = new System.Drawing.Size(645, 207);
            this.gbAlunos.TabIndex = 11;
            this.gbAlunos.TabStop = false;
            this.gbAlunos.Text = "Alunos Cadastrados ";
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAlunos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.ContextMenuStrip = this.cmsAluno;
            this.dgvAlunos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlunos.Location = new System.Drawing.Point(3, 16);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.ReadOnly = true;
            this.dgvAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlunos.Size = new System.Drawing.Size(639, 188);
            this.dgvAlunos.TabIndex = 0;
            // 
            // FormCadAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 639);
            this.Controls.Add(this.gbAlunos);
            this.Controls.Add(this.gbCadastro);
            this.Controls.Add(this.btCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Alunos";
            this.Load += new System.EventHandler(this.FormCadAluno_Load);
            this.gbCadastro.ResumeLayout(false);
            this.gbCadastro.PerformLayout();
            this.dbSalas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalas)).EndInit();
            this.cmsSalas.ResumeLayout(false);
            this.cmsAluno.ResumeLayout(false);
            this.gbAlunos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCadastro;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.DateTimePicker dtpTermino;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsAluno;
        private System.Windows.Forms.ToolStripMenuItem deletarToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btPesqNome;
        private System.Windows.Forms.TextBox txtNomeSala;
        private System.Windows.Forms.TextBox txtIDSala;
        private System.Windows.Forms.Button btAddSala;
        private System.Windows.Forms.GroupBox dbSalas;
        private System.Windows.Forms.DataGridView dgvSalas;
        private System.Windows.Forms.GroupBox gbAlunos;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.ContextMenuStrip cmsSalas;
        private System.Windows.Forms.ToolStripMenuItem deletarToolStripMenuItem1;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label label5;
    }
}