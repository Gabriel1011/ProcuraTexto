namespace ProcurarTextoNoArquivo
{
    partial class BuscarTextoDentroDePastas
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgArquivos = new System.Windows.Forms.DataGridView();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProcura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NumeroLinha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arquivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extensao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaminhoArquivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DePara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgArquivos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtgArquivos);
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 462);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // dtgArquivos
            // 
            this.dtgArquivos.AllowUserToAddRows = false;
            this.dtgArquivos.AllowUserToDeleteRows = false;
            this.dtgArquivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgArquivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgArquivos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dtgArquivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgArquivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroLinha,
            this.Arquivo,
            this.Extensao,
            this.Nome,
            this.CaminhoArquivo,
            this.DePara});
            this.dtgArquivos.Location = new System.Drawing.Point(9, 16);
            this.dtgArquivos.Name = "dtgArquivos";
            this.dtgArquivos.ReadOnly = true;
            this.dtgArquivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgArquivos.Size = new System.Drawing.Size(621, 440);
            this.dtgArquivos.TabIndex = 0;
            this.dtgArquivos.DoubleClick += new System.EventHandler(this.DtgArquivos_DoubleClick);
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(60, 13);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(452, 20);
            this.txtCaminho.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(555, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Caminho:";
            // 
            // txtProcura
            // 
            this.txtProcura.Location = new System.Drawing.Point(60, 45);
            this.txtProcura.Name = "txtProcura";
            this.txtProcura.Size = new System.Drawing.Size(452, 20);
            this.txtProcura.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Texto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtProcura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtCaminho);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // NumeroLinha
            // 
            this.NumeroLinha.DataPropertyName = "Linha";
            this.NumeroLinha.HeaderText = "Numero da Linha";
            this.NumeroLinha.Name = "NumeroLinha";
            this.NumeroLinha.ReadOnly = true;
            this.NumeroLinha.Width = 80;
            // 
            // Arquivo
            // 
            this.Arquivo.DataPropertyName = "NomeArquivo";
            this.Arquivo.HeaderText = "Arquivo";
            this.Arquivo.Name = "Arquivo";
            this.Arquivo.ReadOnly = true;
            this.Arquivo.Width = 68;
            // 
            // Extensao
            // 
            this.Extensao.DataPropertyName = "Extensao";
            this.Extensao.HeaderText = "extensão arquivo";
            this.Extensao.Name = "Extensao";
            this.Extensao.ReadOnly = true;
            this.Extensao.Width = 104;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "TextoLinha";
            this.Nome.HeaderText = "Texto da Linha";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 95;
            // 
            // CaminhoArquivo
            // 
            this.CaminhoArquivo.HeaderText = "Caminho Arquivo";
            this.CaminhoArquivo.Name = "CaminhoArquivo";
            this.CaminhoArquivo.ReadOnly = true;
            this.CaminhoArquivo.Width = 103;
            // 
            // DePara
            // 
            this.DePara.HeaderText = "De -> Para";
            this.DePara.Name = "DePara";
            this.DePara.ReadOnly = true;
            this.DePara.Width = 77;
            // 
            // BuscarTextoDentroDePastas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 571);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BuscarTextoDentroDePastas";
            this.Text = "BuscarTextoDentroDePastas";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgArquivos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProcura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgArquivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroLinha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arquivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extensao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaminhoArquivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DePara;
    }
}