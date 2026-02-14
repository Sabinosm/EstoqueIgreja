
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estoqueIgreja
{
    public partial class Adicionar : Form
    {
        public Adicionar()
        {
            InitializeComponent();
            EnablePeso();
        }

        private void Insert()
        {
            Alimento novoAlimento = new Alimento();
            string nome = txtNome.Text;
            DateTime dataVencimento = dtpVencimento.Value.Date;

            if (string.IsNullOrEmpty(txtPeso.Text))
            {
                MessageBox.Show("Não deixe o Peso em branco", "Informação Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                
            else if (!int.TryParse(txtPeso.Text.Trim(), out int peso))
            {
                MessageBox.Show("O peso deve somente conter números.", "Informação Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                novoAlimento.SetPeso(GetStringPeso(peso));
            }
                

                try
                {
                    novoAlimento.SetCategoria((_Enum.Categoria)Enum.Parse(typeof(_Enum.Categoria), cmbCategoria.Text));
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Selecione a categoria corretamente", "Informação Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            if (!novoAlimento.SetVenciMento(dataVencimento,true)) return;
            if (!novoAlimento.SetNome(nome)) return;
            novoAlimento.SetInsercao();

            try
            {
                Conexao c = new Conexao();
                c.ExecutarInsert(novoAlimento);
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro: " + e.Message);
                return;
            }

            MessageBox.Show("Item adicionado com sucesso", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);


            Form1 f = Application.OpenForms["Form1"] as Form1;
            if (f != null) f.AtualizarGrid();
            ClearCamps();

        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            Insert();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ClearCamps()
        {
            txtPeso.Text = "";
            txtNome.Text = "";
            cmbCategoria.Text = "Tipo";
            dtpVencimento.Value = DateTime.Now.Date;
            RadioButton[] rdb = [rdbG, rdbKg, rdbMl, rdbL];


            foreach (RadioButton radioButton in rdb)
            {
                radioButton.Checked = false;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EnablePeso()
        {
            RadioButton[] rdb = [rdbG, rdbKg, rdbMl, rdbL];

 
            foreach(RadioButton radioButton in rdb)
            {
                radioButton.CheckedChanged += (sender, e) =>
                {
                    txtPeso.Enabled = rdb.Any(x => x.Checked);
                };
            }
        }
        private string GetStringPeso(int peso)
        {
            RadioButton[] rdb = [rdbG, rdbKg, rdbMl, rdbL];
            RadioButton r = rdb.First(x => x.Checked); 
            return peso + " " + r.Name.Split("rdb")[1].ToLower();
        }

        private void rdbKg_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
