namespace estoqueIgreja
{
    partial class Alterar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alterar));
            btnCancelar = new Button();
            btnAlterar = new Button();
            dtpVencimento = new DateTimePicker();
            label6 = new Label();
            cmbCategoria = new ComboBox();
            label3 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtCodigo = new TextBox();
            rdbL = new RadioButton();
            rdbMl = new RadioButton();
            rdbG = new RadioButton();
            rdbKg = new RadioButton();
            txtPeso = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(664, 160);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(126, 53);
            btnCancelar.TabIndex = 58;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Enabled = false;
            btnAlterar.Location = new Point(664, 93);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(126, 47);
            btnAlterar.TabIndex = 57;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // dtpVencimento
            // 
            dtpVencimento.Enabled = false;
            dtpVencimento.Format = DateTimePickerFormat.Short;
            dtpVencimento.ImeMode = ImeMode.NoControl;
            dtpVencimento.Location = new Point(277, 177);
            dtpVencimento.Name = "dtpVencimento";
            dtpVencimento.Size = new Size(221, 23);
            dtpVencimento.TabIndex = 56;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(277, 146);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(148, 21);
            label6.TabIndex = 55;
            label6.Text = "Data de vencimento";
            // 
            // cmbCategoria
            // 
            cmbCategoria.Enabled = false;
            cmbCategoria.Font = new Font("Segoe UI", 12F);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "CEREAIS_E_GRAOS", "MASSAS", "LEGUMINOSAS", "ENLATADOS_E_CONSERVAS", "CARNES_E_FRIOS", "LATICINIOS", "TEMPEROS_E_CONDIMENTOS", "OLEOS_E_GORDURAS", "BEBIDAS" });
            cmbCategoria.Location = new Point(277, 106);
            cmbCategoria.Margin = new Padding(4);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(221, 29);
            cmbCategoria.TabIndex = 54;
            cmbCategoria.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(277, 72);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 53;
            label3.Text = "Categoria";
            // 
            // txtNome
            // 
            txtNome.Enabled = false;
            txtNome.Font = new Font("Segoe UI", 12F);
            txtNome.Location = new Point(32, 171);
            txtNome.Margin = new Padding(4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(221, 29);
            txtNome.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(35, 146);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 50;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(32, 72);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 49;
            label1.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 12F);
            txtCodigo.Location = new Point(32, 106);
            txtCodigo.Margin = new Padding(4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(224, 29);
            txtCodigo.TabIndex = 51;
            txtCodigo.KeyUp += txtCodigo_KeyUp;
            // 
            // rdbL
            // 
            rdbL.AutoSize = true;
            rdbL.Location = new Point(179, 217);
            rdbL.Name = "rdbL";
            rdbL.Size = new Size(31, 19);
            rdbL.TabIndex = 64;
            rdbL.TabStop = true;
            rdbL.Text = "L";
            rdbL.UseVisualStyleBackColor = true;
            // 
            // rdbMl
            // 
            rdbMl.AutoSize = true;
            rdbMl.Location = new Point(217, 218);
            rdbMl.Name = "rdbMl";
            rdbMl.Size = new Size(39, 19);
            rdbMl.TabIndex = 63;
            rdbMl.TabStop = true;
            rdbMl.Text = "ml";
            rdbMl.UseVisualStyleBackColor = true;
            // 
            // rdbG
            // 
            rdbG.AutoSize = true;
            rdbG.Location = new Point(141, 217);
            rdbG.Name = "rdbG";
            rdbG.Size = new Size(32, 19);
            rdbG.TabIndex = 62;
            rdbG.TabStop = true;
            rdbG.Text = "g";
            rdbG.UseVisualStyleBackColor = true;
            // 
            // rdbKg
            // 
            rdbKg.AutoSize = true;
            rdbKg.Location = new Point(96, 217);
            rdbKg.Name = "rdbKg";
            rdbKg.Size = new Size(39, 19);
            rdbKg.TabIndex = 61;
            rdbKg.TabStop = true;
            rdbKg.Text = "Kg";
            rdbKg.UseVisualStyleBackColor = true;
            // 
            // txtPeso
            // 
            txtPeso.Enabled = false;
            txtPeso.Font = new Font("Segoe UI", 12F);
            txtPeso.Location = new Point(32, 249);
            txtPeso.Margin = new Padding(4);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(221, 29);
            txtPeso.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(29, 215);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(42, 21);
            label4.TabIndex = 59;
            label4.Text = "Peso";
            // 
            // Alterar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 304);
            Controls.Add(rdbL);
            Controls.Add(rdbMl);
            Controls.Add(rdbG);
            Controls.Add(rdbKg);
            Controls.Add(txtPeso);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnAlterar);
            Controls.Add(dtpVencimento);
            Controls.Add(label6);
            Controls.Add(cmbCategoria);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(txtCodigo);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Alterar";
            Text = "Alterar";
            Load += Alterar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAlterar;
        private DateTimePicker dtpVencimento;
        private Label label6;
        private ComboBox cmbCategoria;
        private Label label3;
        private TextBox txtNome;
        private Label label2;
        private Label label1;
        private TextBox txtCodigo;
        private RadioButton rdbL;
        private RadioButton rdbMl;
        private RadioButton rdbG;
        private RadioButton rdbKg;
        private TextBox txtPeso;
        private Label label4;
    }
}