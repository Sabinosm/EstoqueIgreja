namespace estoqueIgreja
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dtgEstoque = new DataGridView();
            label4 = new Label();
            btnAdicionar = new Button();
            btnExcluir = new Button();
            btnPesquisar = new Button();
            btnAlterar = new Button();
            btnAtualizarBanco = new Button();
            btnQrCode = new Button();
            btnDonwload = new Button();
            cmbFiltro = new ComboBox();
            btnSalvar = new Button();
            btnAtualizarPlanilha = new Button();
            ckbEsconderBotoes = new CheckBox();
            btnAbrirPlanilha = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgEstoque).BeginInit();
            SuspendLayout();
            // 
            // dtgEstoque
            // 
            dtgEstoque.AllowUserToAddRows = false;
            dtgEstoque.AllowUserToDeleteRows = false;
            dtgEstoque.AllowUserToResizeColumns = false;
            dtgEstoque.AllowUserToResizeRows = false;
            dtgEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgEstoque.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEstoque.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgEstoque.DefaultCellStyle = dataGridViewCellStyle2;
            dtgEstoque.GridColor = SystemColors.InfoText;
            dtgEstoque.Location = new Point(57, 91);
            dtgEstoque.Margin = new Padding(4);
            dtgEstoque.Name = "dtgEstoque";
            dtgEstoque.ReadOnly = true;
            dtgEstoque.RowHeadersWidth = 30;
            dtgEstoque.Size = new Size(1049, 687);
            dtgEstoque.TabIndex = 5;
            dtgEstoque.DataBindingComplete += dtgEstoque_DataBindingComplete;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(57, 53);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(161, 21);
            label4.TabIndex = 6;
            label4.Text = "Alimentos no estoque";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(1147, 91);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(212, 66);
            btnAdicionar.TabIndex = 17;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(1147, 319);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(212, 76);
            btnExcluir.TabIndex = 18;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(1147, 238);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(212, 75);
            btnPesquisar.TabIndex = 19;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(1147, 163);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(212, 69);
            btnAlterar.TabIndex = 20;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnAtualizarBanco
            // 
            btnAtualizarBanco.Location = new Point(1147, 606);
            btnAtualizarBanco.Name = "btnAtualizarBanco";
            btnAtualizarBanco.Size = new Size(212, 39);
            btnAtualizarBanco.TabIndex = 23;
            btnAtualizarBanco.Text = "Atualizar Banco de dados";
            btnAtualizarBanco.UseVisualStyleBackColor = true;
            btnAtualizarBanco.Click += btnAtualizarBanco_Click;
            // 
            // btnQrCode
            // 
            btnQrCode.Location = new Point(1147, 696);
            btnQrCode.Name = "btnQrCode";
            btnQrCode.Size = new Size(212, 39);
            btnQrCode.TabIndex = 24;
            btnQrCode.Text = "QR code";
            btnQrCode.UseVisualStyleBackColor = true;
            btnQrCode.Click += btnQrCode_Click;
            // 
            // btnDonwload
            // 
            btnDonwload.Location = new Point(1147, 741);
            btnDonwload.Name = "btnDonwload";
            btnDonwload.Size = new Size(212, 39);
            btnDonwload.TabIndex = 25;
            btnDonwload.Text = "Download";
            btnDonwload.UseVisualStyleBackColor = true;
            btnDonwload.Click += btnDonwload_Click;
            // 
            // cmbFiltro
            // 
            cmbFiltro.FormattingEnabled = true;
            cmbFiltro.Items.AddRange(new object[] { "Vencidos", "Perto do vencimento", "Longe do vencimento", "Recém adicionados", "Mais antigos", "Nenhum" });
            cmbFiltro.Location = new Point(837, 55);
            cmbFiltro.Name = "cmbFiltro";
            cmbFiltro.Size = new Size(269, 29);
            cmbFiltro.TabIndex = 27;
            cmbFiltro.Text = "Filtro";
            cmbFiltro.SelectedIndexChanged += cmbFiltro_SelectedIndexChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(1147, 401);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(212, 76);
            btnSalvar.TabIndex = 28;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAtualizarPlanilha
            // 
            btnAtualizarPlanilha.Location = new Point(1147, 651);
            btnAtualizarPlanilha.Name = "btnAtualizarPlanilha";
            btnAtualizarPlanilha.Size = new Size(212, 39);
            btnAtualizarPlanilha.TabIndex = 29;
            btnAtualizarPlanilha.Text = "Atualizar Planilha";
            btnAtualizarPlanilha.UseVisualStyleBackColor = true;
            btnAtualizarPlanilha.Click += btnAtualizarPlanilha_Click;
            // 
            // ckbEsconderBotoes
            // 
            ckbEsconderBotoes.AutoSize = true;
            ckbEsconderBotoes.CheckAlign = ContentAlignment.MiddleRight;
            ckbEsconderBotoes.Location = new Point(1216, 57);
            ckbEsconderBotoes.Name = "ckbEsconderBotoes";
            ckbEsconderBotoes.Size = new Size(143, 25);
            ckbEsconderBotoes.TabIndex = 30;
            ckbEsconderBotoes.Text = "Esconder botões";
            ckbEsconderBotoes.UseVisualStyleBackColor = true;
            ckbEsconderBotoes.CheckedChanged += ckbEsconderBotoes_CheckedChanged;
            // 
            // btnAbrirPlanilha
            // 
            btnAbrirPlanilha.Location = new Point(1147, 561);
            btnAbrirPlanilha.Name = "btnAbrirPlanilha";
            btnAbrirPlanilha.Size = new Size(212, 39);
            btnAbrirPlanilha.TabIndex = 31;
            btnAbrirPlanilha.Text = "Abrir Planilha";
            btnAbrirPlanilha.UseVisualStyleBackColor = true;
            btnAbrirPlanilha.Click += btnAbrirPlanilha_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1484, 878);
            Controls.Add(btnAbrirPlanilha);
            Controls.Add(ckbEsconderBotoes);
            Controls.Add(btnAtualizarPlanilha);
            Controls.Add(btnSalvar);
            Controls.Add(cmbFiltro);
            Controls.Add(btnDonwload);
            Controls.Add(btnQrCode);
            Controls.Add(btnAtualizarBanco);
            Controls.Add(btnAlterar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAdicionar);
            Controls.Add(label4);
            Controls.Add(dtgEstoque);
            Font = new Font("Segoe UI", 12F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Estoque Igreja";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtgEstoque;
        private Label label4;
        private Button btnAdicionar;
        private Button btnExcluir;
        private Button btnPesquisar;
        private Button btnAlterar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tls;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem oitoToolStripMenuItem;
        private Button btnAtualizarBanco;
        private Button btnQrCode;
        private Button btnDonwload;
        private ComboBox cmbFiltro;
        private Button btnSalvar;
        private Button btnAtualizarPlanilha;
        private CheckBox ckbEsconderBotoes;
        private Button btnAbrirPlanilha;
    }
}
