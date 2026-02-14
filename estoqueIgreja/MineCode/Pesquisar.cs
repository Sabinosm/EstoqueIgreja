using Microsoft.Data.Sqlite;
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
    public partial class Pesquisar : Form
    {


        public Pesquisar()
        {
            InitializeComponent();
            VerificarCk();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Pesquisar_Load(object sender, EventArgs e)
        {
            Form1.ColorirGrid(dtgPesquisa);
        }

        public void VerificarCk()
        {

            CheckBox[] checkBoxes =
            {
                ckCode,
                ckNome,
                ckCategoria,
                ckInsercao,
                ckVencimento
            };

            Control[] controles =
                {
                    txtCodigo,
                    txtNome,
                    cmbCategoria,
                    dtpInsercao,
                    dtpVencimento
                };

            for (int i = 0; i < checkBoxes.Length; i++)
            {
                int index = i;

                checkBoxes[i].CheckedChanged += (sender, e) =>
                {
                    controles[index].Enabled = checkBoxes[index].Checked;
                    btnPesquisar.Enabled = checkBoxes.Any(x => x.Checked);

                };
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Conexao c = new Conexao();

            Control[] controles =
                {
                    txtCodigo,
                    txtNome,
                    cmbCategoria,
                    dtpInsercao,
                    dtpVencimento
                };

            foreach (Control control in controles)
            {
                if (string.IsNullOrEmpty(control.Text.ToString()) && control.Enabled)
                {
                    MessageBox.Show("Insira um valor válido, um dos valores selecionados está vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

            }

            if (VerificarFormatacao()) dtgPesquisa.DataSource = c.PesquisarAlimentos(controles.Select(x => x.Enabled ? x : null).ToArray());
            Form1.ColorirGrid(dtgPesquisa);
            ReiniciarCampos();

        }



        private void ckDataInsercao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private bool VerificarFormatacao()
        {
            if (txtCodigo.Enabled == true && !int.TryParse(txtCodigo.Text.Trim(), out int i))
            {
                MessageBox.Show("Insira um valor válido, o código contém somente números", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtNome.Enabled == true && txtNome.Text == "")
            {
                MessageBox.Show("Insira um valor válido, o nome está vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbCategoria.Enabled == true && cmbCategoria.Text == "Tipo")
            {
                MessageBox.Show("Escolha um tipo, senão desabilite a opção", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void ReiniciarCampos()
        {
            CheckBox[] checkBoxes =
            {
                ckCode,
                ckNome,
                ckCategoria,
                ckInsercao,
                ckVencimento
            };

            Control[] controles =
                {
                    txtCodigo,
                    txtNome,
                    cmbCategoria,
                    dtpInsercao,
                    dtpVencimento
                };

            for (int i = 0; i < checkBoxes.Length; i++)
            {
                int index = i;
                controles[index].ResetText();
                controles[index].Enabled = false;
                checkBoxes[index].Checked = false;



            }

            btnPesquisar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ReiniciarCampos();
            dtgPesquisa.DataSource = "";
        }

        private void dtgPesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgPesquisa_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn col in dtgPesquisa.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}

