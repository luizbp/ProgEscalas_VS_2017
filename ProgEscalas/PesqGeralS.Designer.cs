﻿namespace ProgEscalas
{
    partial class PesqGeralS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesqGeralS));
            this.btConfPesq = new System.Windows.Forms.Button();
            this.dgvPesq = new System.Windows.Forms.DataGridView();
            this.btPesqDoc = new System.Windows.Forms.Button();
            this.txtPesq = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesq)).BeginInit();
            this.SuspendLayout();
            // 
            // btConfPesq
            // 
            this.btConfPesq.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btConfPesq.BackgroundImage")));
            this.btConfPesq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btConfPesq.FlatAppearance.BorderSize = 0;
            this.btConfPesq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfPesq.Location = new System.Drawing.Point(470, 295);
            this.btConfPesq.Name = "btConfPesq";
            this.btConfPesq.Size = new System.Drawing.Size(40, 40);
            this.btConfPesq.TabIndex = 34;
            this.btConfPesq.UseVisualStyleBackColor = true;
            this.btConfPesq.Click += new System.EventHandler(this.btConfPesq_Click);
            // 
            // dgvPesq
            // 
            this.dgvPesq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPesq.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPesq.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvPesq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesq.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvPesq.Location = new System.Drawing.Point(5, 43);
            this.dgvPesq.Name = "dgvPesq";
            this.dgvPesq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesq.Size = new System.Drawing.Size(500, 246);
            this.dgvPesq.TabIndex = 33;
            this.dgvPesq.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesq_CellDoubleClick);
            // 
            // btPesqDoc
            // 
            this.btPesqDoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPesqDoc.BackgroundImage")));
            this.btPesqDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPesqDoc.FlatAppearance.BorderSize = 0;
            this.btPesqDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesqDoc.Location = new System.Drawing.Point(470, 3);
            this.btPesqDoc.Name = "btPesqDoc";
            this.btPesqDoc.Size = new System.Drawing.Size(35, 34);
            this.btPesqDoc.TabIndex = 32;
            this.btPesqDoc.UseVisualStyleBackColor = true;
            // 
            // txtPesq
            // 
            this.txtPesq.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesq.Location = new System.Drawing.Point(5, 11);
            this.txtPesq.Name = "txtPesq";
            this.txtPesq.Size = new System.Drawing.Size(459, 20);
            this.txtPesq.TabIndex = 31;
            // 
            // PesqGeralS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 335);
            this.Controls.Add(this.btConfPesq);
            this.Controls.Add(this.dgvPesq);
            this.Controls.Add(this.btPesqDoc);
            this.Controls.Add(this.txtPesq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PesqGeralS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar";
            this.Load += new System.EventHandler(this.PesqGeraS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btConfPesq;
        public System.Windows.Forms.DataGridView dgvPesq;
        public System.Windows.Forms.Button btPesqDoc;
        public System.Windows.Forms.TextBox txtPesq;
    }
}