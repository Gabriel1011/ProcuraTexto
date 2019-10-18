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
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProcura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQuantidade = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgArquivos = new System.Windows.Forms.DataGridView();
            this.Arquivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroLinha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extensao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaminhoArquivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DePara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tabelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtgContadores = new System.Windows.Forms.DataGridView();
            this.Tabela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeTabela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgArquivos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContadores)).BeginInit();
            this.SuspendLayout();
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
            this.button1.Location = new System.Drawing.Point(762, 45);
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
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtProcura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtCaminho);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(843, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.AutoSize = true;
            this.txtQuantidade.Location = new System.Drawing.Point(580, 17);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(19, 13);
            this.txtQuantidade.TabIndex = 7;
            this.txtQuantidade.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Linhas:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 97);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(844, 407);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgArquivos);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(836, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Referencias";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.Arquivo,
            this.NumeroLinha,
            this.Extensao,
            this.Nome,
            this.CaminhoArquivo,
            this.DePara,
            this.Tabelas});
            this.dtgArquivos.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtgArquivos.Location = new System.Drawing.Point(3, 5);
            this.dtgArquivos.Name = "dtgArquivos";
            this.dtgArquivos.ReadOnly = true;
            this.dtgArquivos.RowHeadersWidth = 51;
            this.dtgArquivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgArquivos.Size = new System.Drawing.Size(828, 379);
            this.dtgArquivos.TabIndex = 1;
            this.dtgArquivos.DoubleClick += new System.EventHandler(this.DtgArquivos_DoubleClick);
            // 
            // Arquivo
            // 
            this.Arquivo.DataPropertyName = "NomeArquivo";
            this.Arquivo.HeaderText = "Arquivo";
            this.Arquivo.MinimumWidth = 6;
            this.Arquivo.Name = "Arquivo";
            this.Arquivo.ReadOnly = true;
            this.Arquivo.Width = 68;
            // 
            // NumeroLinha
            // 
            this.NumeroLinha.DataPropertyName = "Linha";
            this.NumeroLinha.HeaderText = "Numero da Linha";
            this.NumeroLinha.MinimumWidth = 6;
            this.NumeroLinha.Name = "NumeroLinha";
            this.NumeroLinha.ReadOnly = true;
            this.NumeroLinha.Width = 80;
            // 
            // Extensao
            // 
            this.Extensao.DataPropertyName = "Extensao";
            this.Extensao.HeaderText = "extensão arquivo";
            this.Extensao.MinimumWidth = 6;
            this.Extensao.Name = "Extensao";
            this.Extensao.ReadOnly = true;
            this.Extensao.Width = 104;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "TextoLinha";
            this.Nome.HeaderText = "Texto da Linha";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 95;
            // 
            // CaminhoArquivo
            // 
            this.CaminhoArquivo.HeaderText = "Caminho Arquivo";
            this.CaminhoArquivo.MinimumWidth = 6;
            this.CaminhoArquivo.Name = "CaminhoArquivo";
            this.CaminhoArquivo.ReadOnly = true;
            this.CaminhoArquivo.Width = 103;
            // 
            // DePara
            // 
            this.DePara.HeaderText = "De -> Para";
            this.DePara.MinimumWidth = 6;
            this.DePara.Name = "DePara";
            this.DePara.ReadOnly = true;
            this.DePara.Width = 77;
            // 
            // Tabelas
            // 
            this.Tabelas.HeaderText = "Tabela";
            this.Tabelas.MinimumWidth = 6;
            this.Tabelas.Name = "Tabelas";
            this.Tabelas.ReadOnly = true;
            this.Tabelas.Width = 65;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtgContadores);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(836, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contadores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgContadores
            // 
            this.dtgContadores.AllowUserToAddRows = false;
            this.dtgContadores.AllowUserToDeleteRows = false;
            this.dtgContadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgContadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgContadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgContadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tabela,
            this.quantidadeTabela});
            this.dtgContadores.Location = new System.Drawing.Point(4, 5);
            this.dtgContadores.Margin = new System.Windows.Forms.Padding(2);
            this.dtgContadores.Name = "dtgContadores";
            this.dtgContadores.ReadOnly = true;
            this.dtgContadores.RowHeadersWidth = 51;
            this.dtgContadores.RowTemplate.Height = 24;
            this.dtgContadores.Size = new System.Drawing.Size(828, 372);
            this.dtgContadores.TabIndex = 0;
            // 
            // Tabela
            // 
            this.Tabela.HeaderText = "Tabela";
            this.Tabela.MinimumWidth = 6;
            this.Tabela.Name = "Tabela";
            this.Tabela.ReadOnly = true;
            this.Tabela.Width = 65;
            // 
            // quantidadeTabela
            // 
            this.quantidadeTabela.HeaderText = "Qauntidade por Tabela";
            this.quantidadeTabela.MinimumWidth = 6;
            this.quantidadeTabela.Name = "quantidadeTabela";
            this.quantidadeTabela.ReadOnly = true;
            this.quantidadeTabela.Width = 99;
            // 
            // BuscarTextoDentroDePastas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 515);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "BuscarTextoDentroDePastas";
            this.Text = "BuscarTextoDentroDePastas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgArquivos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgContadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProcura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtQuantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgContadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeTabela;
        private System.Windows.Forms.DataGridView dtgArquivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arquivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroLinha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extensao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaminhoArquivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DePara;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tabelas;
    }
}