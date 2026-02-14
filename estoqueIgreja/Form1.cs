using ClosedXML.Excel;
using System.Windows.Forms;

namespace estoqueIgreja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexao c = new Conexao();
            Excel.CriandoPlanilha();
            Excel.AtualizacaoTotalAbertura();
            AtualizarGrid();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Form c = new Adicionar();
            c.ShowDialog();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Form c = new Alterar();
            c.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Form c = new Pesquisar();
            c.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Form c = new Excluir();
            c.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Excel.AtualizarPlanilha();
            MessageBox.Show("Planilha atualizada com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void AtualizarGrid()
        {
            Conexao c = new Conexao();
            dtgEstoque.DataSource = null;
            dtgEstoque.DataSource = c.ExecutarSelect();
            ColorirGrid(dtgEstoque);

        }
        public void AtualizarGrid(string sql)
        {
            Conexao c = new Conexao();
            dtgEstoque.DataSource = null;
            dtgEstoque.DataSource = c.ExecutarSelect(sql);
            ColorirGrid(dtgEstoque);

        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conexao c = new Conexao();
            string sql;
            if (cmbFiltro.Text == "Vencidos")
            {
                sql = """
                    SELECT Codigo, Nome, Categoria, Estado, Insercao, Vencimento 
                    FROM alimentos 
                    WHERE estado = 'VENCIDO'
                    ORDER BY codigo ASC, categoria;
                    """;
            }
            else if (cmbFiltro.Text == "Perto do vencimento")
            {
                sql = """
                    SELECT Codigo, Nome, Categoria, Estado, Insercao, Vencimento 
                    FROM alimentos 
                    WHERE estado = 'PERTO_DO_VENCIMENTO'
                    ORDER BY codigo ASC, categoria;
                    """;

            }
            else if (cmbFiltro.Text == "Longe do vencimento")
            {
                sql = """
                    SELECT Codigo, Nome, Categoria, Estado, Insercao, Vencimento 
                    FROM alimentos 
                    WHERE estado = 'LONGE_DO_VENCIMENTO'
                    ORDER BY codigo ASC, categoria;
                    """;
            }
            else if (cmbFiltro.Text == "Recém adicionados")
            {
                sql = """
                    SELECT Codigo, Nome, Categoria, Estado, Insercao, Vencimento
                    FROM alimentos 
                    ORDER BY Insercao DESC, categoria;
                    """;

            }
            else if (cmbFiltro.Text == "Mais antigos")
            {
                sql = """
                    SELECT Codigo, Nome, Categoria, Estado, Insercao, Vencimento 
                    FROM alimentos 
                    ORDER BY Insercao DESC, categoria;
                    """;

            }
            else
            {
                sql = """
                    SELECT Codigo, Nome, Categoria, Estado, Insercao, Vencimento 
                    FROM alimentos 
                    ORDER BY codigo ASC, categoria;
                    """;
            }

            AtualizarGrid(sql);

        }

        private void btnAbrirPlanilha_Click(object sender, EventArgs e)
        {
            Excel.AbrirPlanilha();
        }

        public static void ColorirGrid(DataGridView dtg)
        {

            foreach (DataGridViewRow row in dtg.Rows)
            {
                string? estado = row.Cells["Estado"].Value?.ToString();

                if (estado == "VENCIDO")
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                }
                else if (estado == "PERTO_DO_VENCIMENTO")
                {
                    row.DefaultCellStyle.BackColor = Color.Khaki;
                }
                else if (estado == "LONGE_DO_VENCIMENTO")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }


            }
        }

        private void btnAtualizarPlanilha_Click(object sender, EventArgs e)
        {
            Excel.AtualizarPlanilha();
            MessageBox.Show("Planilha atualizada com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtgEstoque_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn col in dtgEstoque.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Excel.AtualizacaoTotalFechamento();
        }

        private void btnDonwload_Click(object sender, EventArgs e)
        {
            Excel.Download();
        }

        private void btnQrCode_Click(object sender, EventArgs e)
        {
            Form c = new QrCode();
            c.ShowDialog();
        }

        private void ckbEsconderBotoes_CheckedChanged(object sender, EventArgs e)
        {
            Button[] botoes = [
                btnAtualizarBanco,
                btnAdicionar,
                btnDonwload,
                btnQrCode,
                btnSalvar,
                btnExcluir,
                btnPesquisar,
                btnAlterar,
                btnAtualizarPlanilha,
                btnAbrirPlanilha
                ];

            if (ckbEsconderBotoes.Checked)
            {
                foreach (Button b in botoes)
                    b.Visible = false;

                dtgEstoque.Width = 1302;
                dtgEstoque.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            else
            {
                foreach (Button b in botoes)
                    b.Visible = true;
                dtgEstoque.Width = 1049;
                dtgEstoque.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            }
        }

      

        private void btnAtualizarBanco_Click(object sender, EventArgs e)
        {
            Excel.AtualizarBdExcel();
            AtualizarGrid();
            MessageBox.Show("Banco de dados alterado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
