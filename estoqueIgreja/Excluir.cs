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
    public partial class Excluir : Form
    {
        public Excluir()
        {
            InitializeComponent();
        }

        private void Excluir_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao c = new Conexao();
                if (c.ExecutarExcluir(c.SelectAlimento(int.Parse(txtCodigo.Text))))
                {
                    MessageBox.Show("Item de código: " + txtCodigo.Text + " excluído com sucesso", "Operação Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodigo.Text = "";
                }
                else
                {
                    MessageBox.Show("Nenhum item com esse código foi encontrado", "Informação Inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodigo.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }

            Form1? f = Application.OpenForms["Form1"] as Form1;
            if (f != null) f.AtualizarGrid();

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private bool CheckCode()
        {
            int codigo;
            if (int.TryParse(txtCodigo.Text, out codigo))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Digite um código válido", "Informação Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (!CheckCode()) { txtCodigo.Text = ""; return; }

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
