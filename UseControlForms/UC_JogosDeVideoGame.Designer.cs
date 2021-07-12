namespace Acervo.UseControlForms
{
    partial class UC_JogosDeVideoGame
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Grb_Busca = new System.Windows.Forms.GroupBox();
            this.Dgv_Busca = new System.Windows.Forms.DataGridView();
            this.Lbl_Busca = new System.Windows.Forms.Label();
            this.Grb_Proprietario = new System.Windows.Forms.GroupBox();
            this.Lbl_T = new System.Windows.Forms.Label();
            this.Rdb_T = new System.Windows.Forms.RadioButton();
            this.Lbl_R = new System.Windows.Forms.Label();
            this.Rdb_R = new System.Windows.Forms.RadioButton();
            this.Lbl_D = new System.Windows.Forms.Label();
            this.Rdb_D = new System.Windows.Forms.RadioButton();
            this.Grb_Edicao = new System.Windows.Forms.GroupBox();
            this.Txt_Desenvolvedora = new System.Windows.Forms.TextBox();
            this.Lbl_Desenvolvedora = new System.Windows.Forms.Label();
            this.Lbl_Publicador = new System.Windows.Forms.Label();
            this.Txt_Publicador = new System.Windows.Forms.TextBox();
            this.Grb_Outros = new System.Windows.Forms.GroupBox();
            this.Lbl_Observacoes = new System.Windows.Forms.Label();
            this.Txt_Observacoes = new System.Windows.Forms.TextBox();
            this.Grb_Livro = new System.Windows.Forms.GroupBox();
            this.Cmb_Midia = new System.Windows.Forms.ComboBox();
            this.Cmb_Plataforma = new System.Windows.Forms.ComboBox();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Txt_Titulo = new System.Windows.Forms.TextBox();
            this.Lbl_Genero = new System.Windows.Forms.Label();
            this.Txt_Genero = new System.Windows.Forms.TextBox();
            this.Lbl_Plataforma = new System.Windows.Forms.Label();
            this.Lbl_Colecao = new System.Windows.Forms.Label();
            this.Txt_Colecao = new System.Windows.Forms.TextBox();
            this.Lbl_Midia = new System.Windows.Forms.Label();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.Lbl_Id = new System.Windows.Forms.Label();
            this.Grb_Busca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Busca)).BeginInit();
            this.Grb_Proprietario.SuspendLayout();
            this.Grb_Edicao.SuspendLayout();
            this.Grb_Outros.SuspendLayout();
            this.Grb_Livro.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grb_Busca
            // 
            this.Grb_Busca.Controls.Add(this.Dgv_Busca);
            this.Grb_Busca.Controls.Add(this.Lbl_Busca);
            this.Grb_Busca.Location = new System.Drawing.Point(10, 330);
            this.Grb_Busca.Name = "Grb_Busca";
            this.Grb_Busca.Size = new System.Drawing.Size(1040, 460);
            this.Grb_Busca.TabIndex = 20;
            this.Grb_Busca.TabStop = false;
            this.Grb_Busca.Text = "Busca de Fichas no Acervo";
            // 
            // Dgv_Busca
            // 
            this.Dgv_Busca.AllowUserToAddRows = false;
            this.Dgv_Busca.AllowUserToDeleteRows = false;
            this.Dgv_Busca.AllowUserToResizeColumns = false;
            this.Dgv_Busca.AllowUserToResizeRows = false;
            this.Dgv_Busca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Busca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Busca.ColumnHeadersHeight = 30;
            this.Dgv_Busca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_Busca.Location = new System.Drawing.Point(10, 35);
            this.Dgv_Busca.Name = "Dgv_Busca";
            this.Dgv_Busca.ReadOnly = true;
            this.Dgv_Busca.RowHeadersVisible = false;
            this.Dgv_Busca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Busca.Size = new System.Drawing.Size(1020, 410);
            this.Dgv_Busca.TabIndex = 16;
            this.Dgv_Busca.DoubleClick += new System.EventHandler(this.Dgv_Busca_DoubleClick);
            // 
            // Lbl_Busca
            // 
            this.Lbl_Busca.AutoSize = true;
            this.Lbl_Busca.Location = new System.Drawing.Point(10, 20);
            this.Lbl_Busca.Name = "Lbl_Busca";
            this.Lbl_Busca.Size = new System.Drawing.Size(103, 13);
            this.Lbl_Busca.TabIndex = 14;
            this.Lbl_Busca.Text = "Resultado da Busca";
            // 
            // Grb_Proprietario
            // 
            this.Grb_Proprietario.Controls.Add(this.Lbl_T);
            this.Grb_Proprietario.Controls.Add(this.Rdb_T);
            this.Grb_Proprietario.Controls.Add(this.Lbl_R);
            this.Grb_Proprietario.Controls.Add(this.Rdb_R);
            this.Grb_Proprietario.Controls.Add(this.Lbl_D);
            this.Grb_Proprietario.Controls.Add(this.Rdb_D);
            this.Grb_Proprietario.Location = new System.Drawing.Point(932, 10);
            this.Grb_Proprietario.Name = "Grb_Proprietario";
            this.Grb_Proprietario.Size = new System.Drawing.Size(118, 35);
            this.Grb_Proprietario.TabIndex = 19;
            this.Grb_Proprietario.TabStop = false;
            // 
            // Lbl_T
            // 
            this.Lbl_T.AutoSize = true;
            this.Lbl_T.Location = new System.Drawing.Point(99, 14);
            this.Lbl_T.Name = "Lbl_T";
            this.Lbl_T.Size = new System.Drawing.Size(14, 13);
            this.Lbl_T.TabIndex = 13;
            this.Lbl_T.Text = "T";
            // 
            // Rdb_T
            // 
            this.Rdb_T.AutoSize = true;
            this.Rdb_T.Location = new System.Drawing.Point(84, 14);
            this.Rdb_T.Name = "Rdb_T";
            this.Rdb_T.Size = new System.Drawing.Size(14, 13);
            this.Rdb_T.TabIndex = 13;
            this.Rdb_T.TabStop = true;
            this.Rdb_T.UseVisualStyleBackColor = true;
            // 
            // Lbl_R
            // 
            this.Lbl_R.AutoSize = true;
            this.Lbl_R.Location = new System.Drawing.Point(60, 14);
            this.Lbl_R.Name = "Lbl_R";
            this.Lbl_R.Size = new System.Drawing.Size(15, 13);
            this.Lbl_R.TabIndex = 12;
            this.Lbl_R.Text = "R";
            // 
            // Rdb_R
            // 
            this.Rdb_R.AutoSize = true;
            this.Rdb_R.Location = new System.Drawing.Point(45, 14);
            this.Rdb_R.Name = "Rdb_R";
            this.Rdb_R.Size = new System.Drawing.Size(14, 13);
            this.Rdb_R.TabIndex = 12;
            this.Rdb_R.TabStop = true;
            this.Rdb_R.UseVisualStyleBackColor = true;
            // 
            // Lbl_D
            // 
            this.Lbl_D.AutoSize = true;
            this.Lbl_D.Location = new System.Drawing.Point(21, 14);
            this.Lbl_D.Name = "Lbl_D";
            this.Lbl_D.Size = new System.Drawing.Size(15, 13);
            this.Lbl_D.TabIndex = 11;
            this.Lbl_D.Text = "D";
            // 
            // Rdb_D
            // 
            this.Rdb_D.AutoSize = true;
            this.Rdb_D.Location = new System.Drawing.Point(6, 14);
            this.Rdb_D.Name = "Rdb_D";
            this.Rdb_D.Size = new System.Drawing.Size(14, 13);
            this.Rdb_D.TabIndex = 11;
            this.Rdb_D.TabStop = true;
            this.Rdb_D.UseVisualStyleBackColor = true;
            // 
            // Grb_Edicao
            // 
            this.Grb_Edicao.Controls.Add(this.Txt_Desenvolvedora);
            this.Grb_Edicao.Controls.Add(this.Lbl_Desenvolvedora);
            this.Grb_Edicao.Controls.Add(this.Lbl_Publicador);
            this.Grb_Edicao.Controls.Add(this.Txt_Publicador);
            this.Grb_Edicao.Location = new System.Drawing.Point(10, 170);
            this.Grb_Edicao.Name = "Grb_Edicao";
            this.Grb_Edicao.Size = new System.Drawing.Size(1040, 65);
            this.Grb_Edicao.TabIndex = 17;
            this.Grb_Edicao.TabStop = false;
            this.Grb_Edicao.Text = "Informações Comerciais";
            // 
            // Txt_Desenvolvedora
            // 
            this.Txt_Desenvolvedora.Location = new System.Drawing.Point(10, 35);
            this.Txt_Desenvolvedora.Name = "Txt_Desenvolvedora";
            this.Txt_Desenvolvedora.Size = new System.Drawing.Size(505, 20);
            this.Txt_Desenvolvedora.TabIndex = 7;
            // 
            // Lbl_Desenvolvedora
            // 
            this.Lbl_Desenvolvedora.AutoSize = true;
            this.Lbl_Desenvolvedora.Location = new System.Drawing.Point(10, 20);
            this.Lbl_Desenvolvedora.Name = "Lbl_Desenvolvedora";
            this.Lbl_Desenvolvedora.Size = new System.Drawing.Size(85, 13);
            this.Lbl_Desenvolvedora.TabIndex = 7;
            this.Lbl_Desenvolvedora.Text = "Desenvolvedora";
            // 
            // Lbl_Publicador
            // 
            this.Lbl_Publicador.AutoSize = true;
            this.Lbl_Publicador.Location = new System.Drawing.Point(525, 20);
            this.Lbl_Publicador.Name = "Lbl_Publicador";
            this.Lbl_Publicador.Size = new System.Drawing.Size(57, 13);
            this.Lbl_Publicador.TabIndex = 8;
            this.Lbl_Publicador.Text = "Publicador";
            // 
            // Txt_Publicador
            // 
            this.Txt_Publicador.Location = new System.Drawing.Point(525, 35);
            this.Txt_Publicador.Name = "Txt_Publicador";
            this.Txt_Publicador.Size = new System.Drawing.Size(505, 20);
            this.Txt_Publicador.TabIndex = 8;
            // 
            // Grb_Outros
            // 
            this.Grb_Outros.Controls.Add(this.Lbl_Observacoes);
            this.Grb_Outros.Controls.Add(this.Txt_Observacoes);
            this.Grb_Outros.Location = new System.Drawing.Point(10, 245);
            this.Grb_Outros.Name = "Grb_Outros";
            this.Grb_Outros.Size = new System.Drawing.Size(1040, 65);
            this.Grb_Outros.TabIndex = 18;
            this.Grb_Outros.TabStop = false;
            this.Grb_Outros.Text = "Informações Gerais";
            // 
            // Lbl_Observacoes
            // 
            this.Lbl_Observacoes.AutoSize = true;
            this.Lbl_Observacoes.Location = new System.Drawing.Point(10, 20);
            this.Lbl_Observacoes.Name = "Lbl_Observacoes";
            this.Lbl_Observacoes.Size = new System.Drawing.Size(70, 13);
            this.Lbl_Observacoes.TabIndex = 10;
            this.Lbl_Observacoes.Text = "Observações";
            // 
            // Txt_Observacoes
            // 
            this.Txt_Observacoes.Location = new System.Drawing.Point(10, 35);
            this.Txt_Observacoes.Name = "Txt_Observacoes";
            this.Txt_Observacoes.Size = new System.Drawing.Size(1020, 20);
            this.Txt_Observacoes.TabIndex = 10;
            // 
            // Grb_Livro
            // 
            this.Grb_Livro.Controls.Add(this.Cmb_Midia);
            this.Grb_Livro.Controls.Add(this.Cmb_Plataforma);
            this.Grb_Livro.Controls.Add(this.Lbl_Titulo);
            this.Grb_Livro.Controls.Add(this.Txt_Titulo);
            this.Grb_Livro.Controls.Add(this.Lbl_Genero);
            this.Grb_Livro.Controls.Add(this.Txt_Genero);
            this.Grb_Livro.Controls.Add(this.Lbl_Plataforma);
            this.Grb_Livro.Controls.Add(this.Lbl_Colecao);
            this.Grb_Livro.Controls.Add(this.Txt_Colecao);
            this.Grb_Livro.Controls.Add(this.Lbl_Midia);
            this.Grb_Livro.Location = new System.Drawing.Point(10, 55);
            this.Grb_Livro.Name = "Grb_Livro";
            this.Grb_Livro.Size = new System.Drawing.Size(1040, 105);
            this.Grb_Livro.TabIndex = 16;
            this.Grb_Livro.TabStop = false;
            this.Grb_Livro.Text = "Informações do Jogo";
            // 
            // Cmb_Midia
            // 
            this.Cmb_Midia.FormattingEnabled = true;
            this.Cmb_Midia.Location = new System.Drawing.Point(860, 74);
            this.Cmb_Midia.Name = "Cmb_Midia";
            this.Cmb_Midia.Size = new System.Drawing.Size(80, 21);
            this.Cmb_Midia.TabIndex = 5;
            // 
            // Cmb_Plataforma
            // 
            this.Cmb_Plataforma.FormattingEnabled = true;
            this.Cmb_Plataforma.Location = new System.Drawing.Point(950, 74);
            this.Cmb_Plataforma.Name = "Cmb_Plataforma";
            this.Cmb_Plataforma.Size = new System.Drawing.Size(80, 21);
            this.Cmb_Plataforma.TabIndex = 6;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Location = new System.Drawing.Point(10, 20);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Titulo.TabIndex = 2;
            this.Lbl_Titulo.Text = "Título";
            // 
            // Txt_Titulo
            // 
            this.Txt_Titulo.Location = new System.Drawing.Point(10, 35);
            this.Txt_Titulo.Name = "Txt_Titulo";
            this.Txt_Titulo.Size = new System.Drawing.Size(1020, 20);
            this.Txt_Titulo.TabIndex = 2;
            // 
            // Lbl_Genero
            // 
            this.Lbl_Genero.AutoSize = true;
            this.Lbl_Genero.Location = new System.Drawing.Point(10, 60);
            this.Lbl_Genero.Name = "Lbl_Genero";
            this.Lbl_Genero.Size = new System.Drawing.Size(42, 13);
            this.Lbl_Genero.TabIndex = 3;
            this.Lbl_Genero.Text = "Gênero";
            // 
            // Txt_Genero
            // 
            this.Txt_Genero.Location = new System.Drawing.Point(10, 75);
            this.Txt_Genero.Name = "Txt_Genero";
            this.Txt_Genero.Size = new System.Drawing.Size(415, 20);
            this.Txt_Genero.TabIndex = 3;
            // 
            // Lbl_Plataforma
            // 
            this.Lbl_Plataforma.AutoSize = true;
            this.Lbl_Plataforma.Location = new System.Drawing.Point(950, 59);
            this.Lbl_Plataforma.Name = "Lbl_Plataforma";
            this.Lbl_Plataforma.Size = new System.Drawing.Size(57, 13);
            this.Lbl_Plataforma.TabIndex = 6;
            this.Lbl_Plataforma.Text = "Plataforma";
            // 
            // Lbl_Colecao
            // 
            this.Lbl_Colecao.AutoSize = true;
            this.Lbl_Colecao.Location = new System.Drawing.Point(435, 59);
            this.Lbl_Colecao.Name = "Lbl_Colecao";
            this.Lbl_Colecao.Size = new System.Drawing.Size(46, 13);
            this.Lbl_Colecao.TabIndex = 4;
            this.Lbl_Colecao.Text = "Coleção";
            // 
            // Txt_Colecao
            // 
            this.Txt_Colecao.Location = new System.Drawing.Point(435, 74);
            this.Txt_Colecao.Name = "Txt_Colecao";
            this.Txt_Colecao.Size = new System.Drawing.Size(415, 20);
            this.Txt_Colecao.TabIndex = 4;
            // 
            // Lbl_Midia
            // 
            this.Lbl_Midia.AutoSize = true;
            this.Lbl_Midia.Location = new System.Drawing.Point(860, 59);
            this.Lbl_Midia.Name = "Lbl_Midia";
            this.Lbl_Midia.Size = new System.Drawing.Size(34, 13);
            this.Lbl_Midia.TabIndex = 5;
            this.Lbl_Midia.Text = "Mídia";
            // 
            // Txt_Id
            // 
            this.Txt_Id.Location = new System.Drawing.Point(10, 25);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Size = new System.Drawing.Size(100, 20);
            this.Txt_Id.TabIndex = 14;
            // 
            // Lbl_Id
            // 
            this.Lbl_Id.AutoSize = true;
            this.Lbl_Id.Location = new System.Drawing.Point(10, 10);
            this.Lbl_Id.Name = "Lbl_Id";
            this.Lbl_Id.Size = new System.Drawing.Size(18, 13);
            this.Lbl_Id.TabIndex = 15;
            this.Lbl_Id.Text = "ID";
            // 
            // UC_JogosDeVideoGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Grb_Busca);
            this.Controls.Add(this.Grb_Proprietario);
            this.Controls.Add(this.Grb_Edicao);
            this.Controls.Add(this.Grb_Outros);
            this.Controls.Add(this.Grb_Livro);
            this.Controls.Add(this.Txt_Id);
            this.Controls.Add(this.Lbl_Id);
            this.Name = "UC_JogosDeVideoGame";
            this.Size = new System.Drawing.Size(1060, 800);
            this.Grb_Busca.ResumeLayout(false);
            this.Grb_Busca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Busca)).EndInit();
            this.Grb_Proprietario.ResumeLayout(false);
            this.Grb_Proprietario.PerformLayout();
            this.Grb_Edicao.ResumeLayout(false);
            this.Grb_Edicao.PerformLayout();
            this.Grb_Outros.ResumeLayout(false);
            this.Grb_Outros.PerformLayout();
            this.Grb_Livro.ResumeLayout(false);
            this.Grb_Livro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Grb_Busca;
        private System.Windows.Forms.Label Lbl_Busca;
        private System.Windows.Forms.GroupBox Grb_Proprietario;
        private System.Windows.Forms.Label Lbl_T;
        private System.Windows.Forms.RadioButton Rdb_T;
        private System.Windows.Forms.Label Lbl_R;
        private System.Windows.Forms.RadioButton Rdb_R;
        private System.Windows.Forms.Label Lbl_D;
        private System.Windows.Forms.RadioButton Rdb_D;
        private System.Windows.Forms.GroupBox Grb_Edicao;
        private System.Windows.Forms.TextBox Txt_Desenvolvedora;
        private System.Windows.Forms.Label Lbl_Desenvolvedora;
        private System.Windows.Forms.Label Lbl_Publicador;
        private System.Windows.Forms.TextBox Txt_Publicador;
        private System.Windows.Forms.GroupBox Grb_Outros;
        private System.Windows.Forms.Label Lbl_Observacoes;
        private System.Windows.Forms.TextBox Txt_Observacoes;
        private System.Windows.Forms.GroupBox Grb_Livro;
        private System.Windows.Forms.ComboBox Cmb_Plataforma;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.TextBox Txt_Titulo;
        private System.Windows.Forms.Label Lbl_Genero;
        private System.Windows.Forms.TextBox Txt_Genero;
        private System.Windows.Forms.Label Lbl_Plataforma;
        private System.Windows.Forms.Label Lbl_Colecao;
        private System.Windows.Forms.TextBox Txt_Colecao;
        private System.Windows.Forms.Label Lbl_Midia;
        private System.Windows.Forms.TextBox Txt_Id;
        private System.Windows.Forms.Label Lbl_Id;
        private System.Windows.Forms.ComboBox Cmb_Midia;
        private System.Windows.Forms.DataGridView Dgv_Busca;
    }
}
