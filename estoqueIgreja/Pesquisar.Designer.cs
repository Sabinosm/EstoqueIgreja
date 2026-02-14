namespace estoqueIgreja
{
    partial class Pesquisar
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisar));
            btnCancelar = new Button();
            btnPesquisar = new Button();
            dtpVencimento = new DateTimePicker();
            label6 = new Label();
            cmbCategoria = new ComboBox();
            label3 = new Label();
            txtNome = new TextBox();
            txtCodigo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            dtpInsercao = new DateTimePicker();
            label5 = new Label();
            dtgPesquisa = new DataGridView();
            ckNome = new CheckBox();
            ckCategoria = new CheckBox();
            ckVencimento = new CheckBox();
            ckInsercao = new CheckBox();
            ckCode = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dtgPesquisa).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(988, 165);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 53);
            btnCancelar.TabIndex = 68;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Enabled = false;
            btnPesquisar.Location = new Point(988, 104);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 47);
            btnPesquisar.TabIndex = 67;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // dtpVencimento
            // 
            dtpVencimento.Enabled = false;
            dtpVencimento.Format = DateTimePickerFormat.Short;
            dtpVencimento.ImeMode = ImeMode.NoControl;
            dtpVencimento.Location = new Point(27, 313);
            dtpVencimento.Name = "dtpVencimento";
            dtpVencimento.Size = new Size(221, 23);
            dtpVencimento.TabIndex = 66;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(24, 289);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(148, 21);
            label6.TabIndex = 65;
            label6.Text = "Data de vencimento";
            // 
            // cmbCategoria
            // 
            cmbCategoria.Enabled = false;
            cmbCategoria.Font = new Font("Segoe UI", 12F);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "CEREAIS_E_GRAOS", "MASSAS", "LEGUMINOSAS", "ENLATADOS_E_CONSERVAS", "CARNES_E_FRIOS", "LATICINIOS", "TEMPEROS_E_CONDIMENTOS", "OLEOS_E_GORDURAS", "BEBIDAS" });
            cmbCategoria.Location = new Point(24, 243);
            cmbCategoria.Margin = new Padding(4);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(221, 29);
            cmbCategoria.TabIndex = 64;
            cmbCategoria.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(24, 218);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 63;
            label3.Text = "Categoria";
            // 
            // txtNome
            // 
            txtNome.Enabled = false;
            txtNome.Font = new Font("Segoe UI", 12F);
            txtNome.Location = new Point(24, 176);
            txtNome.Margin = new Padding(4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(221, 29);
            txtNome.TabIndex = 62;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Font = new Font("Segoe UI", 12F);
            txtCodigo.Location = new Point(21, 104);
            txtCodigo.Margin = new Padding(4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(224, 29);
            txtCodigo.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(24, 150);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 60;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(24, 79);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 59;
            label1.Text = "Código";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(24, 23);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 69;
            label4.Text = "Buscar por";
            // 
            // dtpInsercao
            // 
            dtpInsercao.Enabled = false;
            dtpInsercao.Format = DateTimePickerFormat.Short;
            dtpInsercao.ImeMode = ImeMode.NoControl;
            dtpInsercao.Location = new Point(27, 376);
            dtpInsercao.Name = "dtpInsercao";
            dtpInsercao.Size = new Size(221, 23);
            dtpInsercao.TabIndex = 71;
            dtpInsercao.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(24, 352);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(125, 21);
            label5.TabIndex = 70;
            label5.Text = "Data de inserção";
            // 
            // dtgPesquisa
            // 
            dtgPesquisa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgPesquisa.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgPesquisa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dtgPesquisa.DefaultCellStyle = dataGridViewCellStyle1;
            dtgPesquisa.Location = new Point(313, 102);
            dtgPesquisa.Name = "dtgPesquisa";
            dtgPesquisa.Size = new Size(669, 295);
            dtgPesquisa.TabIndex = 72;
            dtgPesquisa.CellContentClick += dtgPesquisa_CellContentClick;
            dtgPesquisa.DataBindingComplete += dtgPesquisa_DataBindingComplete;
            // 
            // ckNome
            // 
            ckNome.AutoSize = true;
            ckNome.Location = new Point(263, 185);
            ckNome.Name = "ckNome";
            ckNome.Size = new Size(15, 14);
            ckNome.TabIndex = 74;
            ckNome.UseVisualStyleBackColor = true;
            // 
            // ckCategoria
            // 
            ckCategoria.AutoSize = true;
            ckCategoria.Location = new Point(263, 252);
            ckCategoria.Name = "ckCategoria";
            ckCategoria.Size = new Size(15, 14);
            ckCategoria.TabIndex = 75;
            ckCategoria.UseVisualStyleBackColor = true;
            // 
            // ckVencimento
            // 
            ckVencimento.AutoSize = true;
            ckVencimento.Location = new Point(263, 320);
            ckVencimento.Name = "ckVencimento";
            ckVencimento.Size = new Size(15, 14);
            ckVencimento.TabIndex = 76;
            ckVencimento.UseVisualStyleBackColor = true;
            // 
            // ckInsercao
            // 
            ckInsercao.AutoSize = true;
            ckInsercao.Location = new Point(263, 383);
            ckInsercao.Name = "ckInsercao";
            ckInsercao.Size = new Size(15, 14);
            ckInsercao.TabIndex = 77;
            ckInsercao.UseVisualStyleBackColor = true;
            ckInsercao.CheckedChanged += ckDataInsercao_CheckedChanged;
            // 
            // ckCode
            // 
            ckCode.AutoSize = true;
            ckCode.Location = new Point(263, 113);
            ckCode.Name = "ckCode";
            ckCode.Size = new Size(15, 14);
            ckCode.TabIndex = 78;
            ckCode.UseVisualStyleBackColor = true;
            // 
            // Pesquisar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 494);
            Controls.Add(ckCode);
            Controls.Add(ckInsercao);
            Controls.Add(ckVencimento);
            Controls.Add(ckCategoria);
            Controls.Add(ckNome);
            Controls.Add(dtgPesquisa);
            Controls.Add(dtpInsercao);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnPesquisar);
            Controls.Add(dtpVencimento);
            Controls.Add(label6);
            Controls.Add(cmbCategoria);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(txtCodigo);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Pesquisar";
            Text = "Pesquisar";
            Load += Pesquisar_Load;
            ((System.ComponentModel.ISupportInitialize)dtgPesquisa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnPesquisar;
        private DateTimePicker dtpVencimento;
        private Label label6;
        private ComboBox cmbCategoria;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtCodigo;
        private Label label2;
        private Label label1;
        private Label label4;
        private DateTimePicker dtpInsercao;
        private Label label5;
        private DataGridView dtgPesquisa;
        private CheckBox ckCodigo;
        private CheckBox ckNome;
        private CheckBox ckVencimento;
        private CheckBox ckCategoria;
        private CheckBox ckInsercao;
        private CheckBox ckCode;
    }
}