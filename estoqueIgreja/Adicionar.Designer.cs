namespace estoqueIgreja
{
    partial class Adicionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adicionar));
            dtpVencimento = new DateTimePicker();
            label6 = new Label();
            cmbCategoria = new ComboBox();
            label3 = new Label();
            txtNome = new TextBox();
            txtPeso = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnAdicionar = new Button();
            btnCancelar = new Button();
            rdbKg = new RadioButton();
            rdbG = new RadioButton();
            rdbMl = new RadioButton();
            rdbL = new RadioButton();
            SuspendLayout();
            // 
            // dtpVencimento
            // 
            dtpVencimento.Format = DateTimePickerFormat.Short;
            dtpVencimento.ImeMode = ImeMode.NoControl;
            dtpVencimento.Location = new Point(288, 187);
            dtpVencimento.Name = "dtpVencimento";
            dtpVencimento.Size = new Size(221, 23);
            dtpVencimento.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(288, 156);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(148, 21);
            label6.TabIndex = 25;
            label6.Text = "Data de vencimento";
            // 
            // cmbCategoria
            // 
            cmbCategoria.Font = new Font("Segoe UI", 12F);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "CEREAIS_E_GRAOS", "MASSAS", "LEGUMINOSAS", "ENLATADOS_E_CONSERVAS", "CARNES_E_FRIOS", "LATICINIOS", "TEMPEROS_E_CONDIMENTOS", "OLEOS_E_GORDURAS", "BEBIDAS" });
            cmbCategoria.Location = new Point(288, 116);
            cmbCategoria.Margin = new Padding(4);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(221, 29);
            cmbCategoria.TabIndex = 22;
            cmbCategoria.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(288, 82);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 21;
            label3.Text = "Categoria";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F);
            txtNome.Location = new Point(43, 181);
            txtNome.Margin = new Padding(4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(221, 29);
            txtNome.TabIndex = 20;
            // 
            // txtPeso
            // 
            txtPeso.Enabled = false;
            txtPeso.Font = new Font("Segoe UI", 12F);
            txtPeso.Location = new Point(43, 116);
            txtPeso.Margin = new Padding(4);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(221, 29);
            txtPeso.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(46, 156);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 18;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(43, 82);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 21);
            label1.TabIndex = 17;
            label1.Text = "Peso";
            label1.Click += label1_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(675, 103);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(126, 47);
            btnAdicionar.TabIndex = 31;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(675, 163);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(126, 53);
            btnCancelar.TabIndex = 32;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // rdbKg
            // 
            rdbKg.AutoSize = true;
            rdbKg.Location = new Point(104, 84);
            rdbKg.Name = "rdbKg";
            rdbKg.Size = new Size(39, 19);
            rdbKg.TabIndex = 33;
            rdbKg.TabStop = true;
            rdbKg.Text = "Kg";
            rdbKg.UseVisualStyleBackColor = true;
            rdbKg.CheckedChanged += rdbKg_CheckedChanged;
            // 
            // rdbG
            // 
            rdbG.AutoSize = true;
            rdbG.Location = new Point(149, 84);
            rdbG.Name = "rdbG";
            rdbG.Size = new Size(32, 19);
            rdbG.TabIndex = 34;
            rdbG.TabStop = true;
            rdbG.Text = "g";
            rdbG.UseVisualStyleBackColor = true;
            // 
            // rdbMl
            // 
            rdbMl.AutoSize = true;
            rdbMl.Location = new Point(225, 85);
            rdbMl.Name = "rdbMl";
            rdbMl.Size = new Size(39, 19);
            rdbMl.TabIndex = 35;
            rdbMl.TabStop = true;
            rdbMl.Text = "ml";
            rdbMl.UseVisualStyleBackColor = true;
            // 
            // rdbL
            // 
            rdbL.AutoSize = true;
            rdbL.Location = new Point(187, 84);
            rdbL.Name = "rdbL";
            rdbL.Size = new Size(31, 19);
            rdbL.TabIndex = 36;
            rdbL.TabStop = true;
            rdbL.Text = "L";
            rdbL.UseVisualStyleBackColor = true;
            // 
            // Adicionar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 322);
            Controls.Add(rdbL);
            Controls.Add(rdbMl);
            Controls.Add(rdbG);
            Controls.Add(rdbKg);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdicionar);
            Controls.Add(dtpVencimento);
            Controls.Add(label6);
            Controls.Add(cmbCategoria);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(txtPeso);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Adicionar";
            Text = "Adicionar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton Vencido;
        private RadioButton rdbPertoVencimento;
        private RadioButton rdbLongeVencimento;
        private Label label7;
        private DateTimePicker dtpVencimento;
        private Label label6;
        private ComboBox cmbCategoria;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtPeso;
        private Label label2;
        private Label label1;
        private Button btnAdicionar;
        private Button btnCancelar;
        private RadioButton rdbKg;
        private RadioButton rdbG;
        private RadioButton rdbMl;
        private RadioButton rdbL;
    }
}