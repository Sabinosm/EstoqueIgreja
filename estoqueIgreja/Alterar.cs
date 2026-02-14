using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estoqueIgreja
{
    public partial class Alterar : Form
    {
        public Alterar()
        {
            InitializeComponent();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Update();

        }
        

        private void Update()
        {
            Conexao c = new Conexao();
            Alimento novoAlimento = new Alimento();
            string nome = txtNome.Text;
            DateTime dataVencimento = dtpVencimento.Value.Date;
            RadioButton[] rdbs = [rdbG, rdbKg, rdbMl, rdbL];
            RadioButton r = rdbs.First(x => x.Checked);
            string peso = txtPeso.Text + " " + r.Name.Split("rdb")[1].ToLower();

            try
            {
                novoAlimento.SetCategoria((_Enum.Categoria)Enum.Parse(typeof(_Enum.Categoria), cmbCategoria.Text));
            }
            catch (ArgumentException e)
            {
                MessageBox.Show("Selecione a categoria corretamente", "Informação Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!novoAlimento.SetVenciMento(dataVencimento,true)) return;
            if (!novoAlimento.SetNome(nome)) return;
            novoAlimento.SetCodigo(int.Parse(txtCodigo.Text));
            novoAlimento.SetPeso(peso);

            try
            {

                c.ExecutarUpdate(novoAlimento);
                MessageBox.Show("Item Alterado com sucesso", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearCamps();
                AlterarEstadoEnabled(false);
                Form1? f = Application.OpenForms["Form1"] as Form1;
                if (f != null) f.AtualizarGrid();

            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro: " + e.Message);
                return;
            }

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

        private void Alterar_Load(object sender, EventArgs e)
        {
            AlterarEstadoEnabled(false);
        }

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (!CheckCode()) { txtCodigo.Text = ""; return; }

                AlterarEstadoEnabled(true);

                Conexao c = new Conexao();
                Alimento alimentoAtualizado = c.SelectAlimento(int.Parse(txtCodigo.Text));
                txtCodigo.Text = alimentoAtualizado.GetCodigo().ToString();
                txtNome.Text = alimentoAtualizado.GetNome();
                cmbCategoria.Text = alimentoAtualizado.GetCategoria().ToString();
                dtpVencimento.Value = alimentoAtualizado.GetVencimento().Date;
                txtPeso.Text = GetIntPeso(alimentoAtualizado.GetPeso()).ToString();

            }

        }

        public void ClearCamps()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            cmbCategoria.Text = "Tipo";
            dtpVencimento.Value = DateTime.Now.Date;
            txtPeso.Text = "";
            RadioButton[] rdbs = [
            rdbKg,
            rdbL,
            rdbG,
            rdbMl
          ];

            foreach (RadioButton r in rdbs)
                r.Checked=false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlterarEstadoEnabled(bool estado) {

            txtCodigo.Enabled = !estado;
            txtNome.Enabled = estado;
            dtpVencimento.Enabled = estado;
            cmbCategoria.Enabled = estado;
            btnAlterar.Enabled = estado;
            RadioButton[] rdbs = [
            rdbKg,
            rdbL,
            rdbG,
            rdbMl
          ];
            txtPeso.Enabled = estado;

            foreach (RadioButton r in rdbs)
                r.Enabled=estado;
                
        }


        private int GetIntPeso(string peso)
        {
            string[] pesoSeparado = peso.Split(" ");

            RadioButton[] rdbs = [
            rdbKg,
            rdbL,
            rdbG,
            rdbMl
          ];

            foreach (RadioButton radioButton in rdbs)
            {



                if (radioButton.Name.Split("rdb")[1].ToLower() == pesoSeparado[1].ToLower())
                {
                    radioButton.Checked = true;
                }
                    

            }

            if (int.TryParse(pesoSeparado[0], out int resultado))
                return resultado;
            else
                return 0;
        }

        
    }
}
