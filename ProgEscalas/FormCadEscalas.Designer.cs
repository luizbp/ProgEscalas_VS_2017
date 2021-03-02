namespace ProgEscalas
{
    partial class FormCadEscalas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadEscalas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.dtpTermino = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btPesqAluno = new System.Windows.Forms.Button();
            this.txtDescAluno = new System.Windows.Forms.TextBox();
            this.btPesqSala = new System.Windows.Forms.Button();
            this.txtIDAluno = new System.Windows.Forms.TextBox();
            this.txtNomeSala = new System.Windows.Forms.TextBox();
            this.txtIDSala = new System.Windows.Forms.TextBox();
            this.gbEscalas = new System.Windows.Forms.GroupBox();
            this.dgvEscalas = new System.Windows.Forms.DataGridView();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbEscalas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscalas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btAdicionar);
            this.groupBox1.Controls.Add(this.dtpTermino);
            this.groupBox1.Controls.Add(this.dtpInicio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btPesqAluno);
            this.groupBox1.Controls.Add(this.txtDescAluno);
            this.groupBox1.Controls.Add(this.btPesqSala);
            this.groupBox1.Controls.Add(this.txtIDAluno);
            this.groupBox1.Controls.Add(this.txtNomeSala);
            this.groupBox1.Controls.Add(this.txtIDSala);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAdicionar.BackgroundImage")));
            this.btAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAdicionar.FlatAppearance.BorderSize = 0;
            this.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionar.Location = new System.Drawing.Point(622, 172);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(35, 34);
            this.btAdicionar.TabIndex = 27;
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // dtpTermino
            // 
            this.dtpTermino.Location = new System.Drawing.Point(13, 165);
            this.dtpTermino.Name = "dtpTermino";
            this.dtpTermino.Size = new System.Drawing.Size(282, 20);
            this.dtpTermino.TabIndex = 25;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(13, 124);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(282, 20);
            this.dtpInicio.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Data de término:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Data de Inicio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Aluno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Sala:";
            // 
            // btPesqAluno
            // 
            this.btPesqAluno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPesqAluno.BackgroundImage")));
            this.btPesqAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPesqAluno.FlatAppearance.BorderSize = 0;
            this.btPesqAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesqAluno.ForeColor = System.Drawing.Color.Transparent;
            this.btPesqAluno.Location = new System.Drawing.Point(377, 75);
            this.btPesqAluno.Name = "btPesqAluno";
            this.btPesqAluno.Size = new System.Drawing.Size(29, 29);
            this.btPesqAluno.TabIndex = 22;
            this.btPesqAluno.UseVisualStyleBackColor = true;
            this.btPesqAluno.Click += new System.EventHandler(this.btPesqAluno_Click);
            // 
            // txtDescAluno
            // 
            this.txtDescAluno.Location = new System.Drawing.Point(83, 80);
            this.txtDescAluno.Name = "txtDescAluno";
            this.txtDescAluno.ReadOnly = true;
            this.txtDescAluno.Size = new System.Drawing.Size(288, 20);
            this.txtDescAluno.TabIndex = 18;
            // 
            // btPesqSala
            // 
            this.btPesqSala.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPesqSala.BackgroundImage")));
            this.btPesqSala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPesqSala.FlatAppearance.BorderSize = 0;
            this.btPesqSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesqSala.ForeColor = System.Drawing.Color.Transparent;
            this.btPesqSala.Location = new System.Drawing.Point(338, 34);
            this.btPesqSala.Name = "btPesqSala";
            this.btPesqSala.Size = new System.Drawing.Size(29, 29);
            this.btPesqSala.TabIndex = 22;
            this.btPesqSala.UseVisualStyleBackColor = true;
            this.btPesqSala.Click += new System.EventHandler(this.btPesqSala_Click);
            // 
            // txtIDAluno
            // 
            this.txtIDAluno.Location = new System.Drawing.Point(13, 80);
            this.txtIDAluno.Name = "txtIDAluno";
            this.txtIDAluno.ReadOnly = true;
            this.txtIDAluno.Size = new System.Drawing.Size(68, 20);
            this.txtIDAluno.TabIndex = 19;
            // 
            // txtNomeSala
            // 
            this.txtNomeSala.Location = new System.Drawing.Point(83, 39);
            this.txtNomeSala.Name = "txtNomeSala";
            this.txtNomeSala.ReadOnly = true;
            this.txtNomeSala.Size = new System.Drawing.Size(249, 20);
            this.txtNomeSala.TabIndex = 18;
            // 
            // txtIDSala
            // 
            this.txtIDSala.Location = new System.Drawing.Point(13, 39);
            this.txtIDSala.Name = "txtIDSala";
            this.txtIDSala.ReadOnly = true;
            this.txtIDSala.Size = new System.Drawing.Size(68, 20);
            this.txtIDSala.TabIndex = 19;
            // 
            // gbEscalas
            // 
            this.gbEscalas.Controls.Add(this.dgvEscalas);
            this.gbEscalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEscalas.Location = new System.Drawing.Point(12, 230);
            this.gbEscalas.Name = "gbEscalas";
            this.gbEscalas.Size = new System.Drawing.Size(663, 235);
            this.gbEscalas.TabIndex = 10;
            this.gbEscalas.TabStop = false;
            this.gbEscalas.Text = "Escalas Cadastradas ";
            // 
            // dgvEscalas
            // 
            this.dgvEscalas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEscalas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEscalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEscalas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEscalas.Location = new System.Drawing.Point(3, 16);
            this.dgvEscalas.Name = "dgvEscalas";
            this.dgvEscalas.ReadOnly = true;
            this.dgvEscalas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEscalas.Size = new System.Drawing.Size(657, 216);
            this.dgvEscalas.TabIndex = 0;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(597, 471);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 11;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // FormCadEscalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 504);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.gbEscalas);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCadEscalas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Escala";
            this.Load += new System.EventHandler(this.FormCadEscalas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbEscalas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscalas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btPesqAluno;
        private System.Windows.Forms.TextBox txtDescAluno;
        private System.Windows.Forms.Button btPesqSala;
        private System.Windows.Forms.TextBox txtIDAluno;
        private System.Windows.Forms.TextBox txtNomeSala;
        private System.Windows.Forms.TextBox txtIDSala;
        private System.Windows.Forms.DateTimePicker dtpTermino;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.GroupBox gbEscalas;
        private System.Windows.Forms.DataGridView dgvEscalas;
        private System.Windows.Forms.Button btCadastrar;
    }
}