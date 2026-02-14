using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoqueIgreja
{
    internal class Excel
    {
        public static string user = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        public static string caminhoOneDrive = Path.Combine(user, "OneDrive");
        public static string caminhoPasta = Path.Combine(caminhoOneDrive, "Estoque Igreja");
        public static string caminho = Path.Combine(caminhoPasta, "EstoqueIgreja.xlsx");


        public static void CriandoPlanilha()
        {

            XLWorkbook wb;
            Directory.CreateDirectory(caminhoPasta);

            if (File.Exists(caminho))
            {
                wb = new XLWorkbook(caminho); // abre existente
            }
            else
            {
                GerarPlanilha();
            }

        }

        public static void AtualizarPlanilha()
        {
            Conexao c = new Conexao();
            using var wb = new XLWorkbook(caminho);
            var ws = wb.Worksheet(1);
            ws.Rows("2:5000").Clear();
            ws.Cell("A2").InsertData(c.ExecutarSelect().Rows);
            wb.Save();
        }
        public static DataTable GerarDataTableExcel()
        {
            DataTable dt = new DataTable();

            using var wb = new XLWorkbook(caminho);
            var ws = wb.Worksheet(1);

            bool primeiraLinha = true;

            foreach (var linha in ws.RowsUsed())
            {
                if (primeiraLinha)
                {
                    foreach (var cell in linha.Cells())
                        dt.Columns.Add(cell.GetString());

                    primeiraLinha = false;
                }
                else
                {
                    dt.Rows.Add();

                    int i = 0;
                    foreach (var cell in linha.Cells())
                    {
                        dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
                        i++;
                    }
                }
            }

            return dt;
        }
        public static void AtualizarBdExcel()
        {
            Conexao c = new Conexao();
            c.RecriarBanco(GerarDataTableExcel());


        }
        public static void BaixarPlanilha()
        {

        }
        public static void QrCode()
        {

        }


        private static void GerarPlanilha()
        {

            XLWorkbook wb = new XLWorkbook(); // cria novo
            var ws = wb.Worksheets.Add("Estoque");

            // títulos
            ws.Cell("A1").Value = "Codigo";
            ws.Cell("B1").Value = "Nome";
            ws.Cell("C1").Value = "Categoria";
            ws.Cell("D1").Value = "Estado";
            ws.Cell("E1").Value = "Insercao";
            ws.Cell("F1").Value = "Vencimento";
            ws.Cell("G1").Value = "Peso";

            // estilo do cabeçalho
            var header = ws.Range("A1:G1");
            header.Style.Font.Bold = true;
            header.Style.Fill.BackgroundColor = XLColor.FromArgb(61, 133, 198);
            header.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            header.Style.Font.FontColor = XLColor.White;


            ws.Columns().AdjustToContents();
            foreach (var col in ws.ColumnsUsed())
            {
                col.Width += 5;
            }

            ws.Columns().AdjustToContents();
            ws.Cells().Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            ws.Cells().Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

            wb.SaveAs(caminho); // salva pela primeira vez
        }

        public static void AtualizacaoTotalAbertura()
        {
            AtualizarBdExcel();
            AtualizarPlanilha();
        }
        public static void AtualizacaoTotalFechamento()
        {
            AtualizarPlanilha();
            AtualizarBdExcel();
        }

        public static void Download()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Arquivo Excel (*.xlsx)|*.xlsx";
                sfd.Title = "Salvar planilha";
                sfd.FileName = "EstoqueIgreja.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string caminhoArquivo = sfd.FileName;
                    using var wbPlanilha = new XLWorkbook(caminho);
                    wbPlanilha.SaveAs(caminhoArquivo);
                }
            }
        }

        public static void AbrirPlanilha()
        {
            if (File.Exists(caminho))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = caminho,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("Arquivo não encontrado.");
            }
        }
    }


}
