using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoqueIgreja
{
    internal class Conexao
    {
        private static bool tabelaCriada = false;

        public Conexao()
        {
           Directory.CreateDirectory(caminhoPasta);

            if (!tabelaCriada)
            {
                CriarTabela();
                tabelaCriada = true;
            }
        }

        public static string user = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        public static string caminhoOneDrive = Path.Combine(user, "OneDrive");
        public static string caminhoPasta = Path.Combine(caminhoOneDrive, "Estoque Igreja");
        public static string caminhoBanco = Path.Combine(caminhoPasta, "estoqueIgreja.db");
        public string dataSource = "Data Source=" + caminhoBanco;

        public void ExecutarInsert(Alimento alimento)
        {
            alimento.SetCodigo();
            string vencimento = alimento.GetVencimento().Date.ToString("yyyy-MM-dd");
            string insercao = alimento.GetInsercao().Date.ToString("yyyy-MM-dd");
            string categoria = alimento.GetCategoria().ToString();
            string estado = alimento.GetEstado().ToString();
            int codigo = alimento.GetCodigo();
            string nome = alimento.GetNome();
            string peso = alimento.GetPeso();

            try
            {
                using (var conn = new SqliteConnection(dataSource))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "INSERT INTO alimentos (Nome, Estado, Categoria, Insercao, Vencimento, Codigo, Peso) \n" +
                        "VALUES (@nome, @estado, @categoria, @insercao, @vencimento, @codigo, @peso);";
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@categoria", categoria);
                    cmd.Parameters.AddWithValue("@insercao", insercao);
                    cmd.Parameters.AddWithValue("@vencimento", vencimento);
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.Parameters.AddWithValue("@peso", peso);
                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocorreu um erro:\n" + e.Message);
            }
        }
        public void ExecutarInsert(string vencimento, string insercao, string categoria, string nome, int codigo, string peso)
        {
            
             Alimento alimento = new Alimento();
             alimento.SetVenciMentoSemValidacao(DateTime.Parse(vencimento));
             alimento.SetInsercao(DateTime.Parse(insercao));
             alimento.SetCodigo(codigo);
             alimento.SetCategoria((_Enum.Categoria)Enum.Parse(typeof(_Enum.Categoria), categoria.Trim()));
         
             
             string estado = alimento.GetEstado().ToString();
             vencimento = alimento.GetVencimento().Date.ToString("yyyy-MM-dd");
             insercao = alimento.GetInsercao().Date.ToString("yyyy-MM-dd");
             categoria = alimento.GetCategoria().ToString();
             codigo = alimento.GetCodigo();
             
             

           
            

            try
            {
                using (var conn = new SqliteConnection(dataSource))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "INSERT INTO alimentos (Nome, Estado, Categoria, Insercao, Vencimento,Codigo, Peso) \n" +
                        "VALUES (@nome, @estado, @categoria, @insercao, @vencimento, @codigo, @peso);";
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@categoria", categoria);
                    cmd.Parameters.AddWithValue("@insercao", insercao);
                    cmd.Parameters.AddWithValue("@vencimento", vencimento);
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.Parameters.AddWithValue("@peso", peso);

                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro:" + e.Message);
            }
        }

        private void CriarTabela()
        {
            

            try
            {
                using (var conn = new SqliteConnection())
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS alimentos (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Codigo INTEGER NOT NULL UNIQUE,
                    Nome TEXT NOT NULL,
                    Estado TEXT NOT NULL,
                    Categoria TEXT NOT NULL,
                    Insercao TEXT NOT NULL,
                    Vencimento TEXT NOT NULL,
                    Peso TEXT NOT NULL
                )";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro:" + e.Message);
            }

        }

        public bool ExecutarExcluir(Alimento alimento)
        {

            try
            {
                using (var conn = new SqliteConnection(dataSource))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();

                    cmd.CommandText = @"
                   DELETE FROM alimentos
                   WHERE codigo = @codigo
                ";
                    cmd.Parameters.AddWithValue("@codigo", alimento.GetCodigo());
                    int linhas = cmd.ExecuteNonQuery();

                    if (linhas == 0) return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro:" + e.Message);
            }
            return true;
        }

        public void ExecutarUpdate(Alimento alimento)
        {
            int linhasAfetadas;
            string vencimento = alimento.GetVencimento().Date.ToString();
            string insercao = alimento.GetInsercao().Date.ToString();
            string categoria = alimento.GetCategoria().ToString();
            string estado = alimento.GetEstado().ToString();
            int codigo = alimento.GetCodigo();
            string nome = alimento.GetNome();
            string peso = alimento.GetPeso();

            try
            {
                using (var conn = new SqliteConnection(dataSource))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = """
                        UPDATE alimentos
                        SET Nome = @nome, 
                        Estado = @estado, 
                        Categoria = @categoria, 
                        Insercao = @insercao, 
                        Vencimento = @vencimento,
                        Peso = @peso
                        WHERE Codigo = @codigo;
                        """;
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@categoria", categoria);
                    cmd.Parameters.AddWithValue("@insercao", insercao);
                    cmd.Parameters.AddWithValue("@vencimento", vencimento);
                    cmd.Parameters.AddWithValue("@peso", peso);
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    linhasAfetadas = cmd.ExecuteNonQuery();
                    if (linhasAfetadas == 0) MessageBox.Show("Produto não encontrado!", "Informação Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro:" + e.Message);
       
            }
        }

        public DataTable ExecutarSelect()
        {

            DataTable tabela = new DataTable();
            using (var conn = new SqliteConnection(dataSource))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "SELECT Codigo, Nome, Categoria, Estado, Insercao, Vencimento, Peso FROM alimentos ORDER BY codigo ASC, categoria;";
                using (var reader = cmd.ExecuteReader())
                {
                    tabela.Load(reader);
                }
            }

           return tabela;
        }
        /// <summary>
        ///  Realiza um SELECT
        /// </summary>
        /// <param name="sql">Uma query sql contendo o select</param>
        /// <returns>Retorna um dataTable</returns>
        public DataTable ExecutarSelect(string sql)
        {

            DataTable tabela = new DataTable();
            using (var conn = new SqliteConnection(dataSource))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = sql;
                using (var reader = cmd.ExecuteReader())
                {
                    tabela.Load(reader);
                }
            }

            return tabela;
        }


        public Alimento SelectAlimento(int codigo)
        {
            Alimento alimento = new Alimento();

            using (var conn = new SqliteConnection(dataSource))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "SELECT codigo, nome, categoria, vencimento,insercao, peso FROM alimentos WHERE codigo = @codigo";
                cmd.Parameters.AddWithValue("@codigo", codigo);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        alimento = new Alimento();
                        alimento.SetNome(reader["Nome"].ToString());
                        alimento.SetCategoria((_Enum.Categoria)Enum.Parse(typeof(_Enum.Categoria), reader["Categoria"].ToString()));
                        alimento.SetVenciMento(DateTime.Parse(reader["Vencimento"].ToString()).Date,false);
                        alimento.SetInsercao(DateTime.Parse(reader["Insercao"].ToString()).Date);
                        alimento.SetCodigo(Convert.ToInt32(reader["Codigo"]));
                        alimento.SetPeso(reader["Peso"].ToString());

                    }
                }
            }

            return alimento;
        }

        public DataTable PesquisarAlimentos(Control?[] co)
        {

            DateTimePicker? dtpInsercao = co[3] as DateTimePicker;
            DateTimePicker? dtpVencimento = co[4] as DateTimePicker;

            int? c = string.IsNullOrEmpty(co[0]?.Text.Trim()) ? null : int.Parse(co[0]!.Text.Trim());
            string? n = co[1]?.Text.Trim();
            string? ca = co[2]?.Text.Trim();
            string? dataI = dtpInsercao?.Value.Date.ToString("yyyy-MM-dd").Trim();
            string? dataV = dtpVencimento?.Value.Date.ToString("yyyy-MM-dd").Trim();

            int? codigo = c;
            string? nome = string.IsNullOrEmpty(n) ? null : n;
            string? categoria = string.IsNullOrEmpty(ca) ? null : ca;
            string? insercao = string.IsNullOrEmpty(dataI) ? null : dataI!;
            string? vencimento = string.IsNullOrEmpty(dataV) ? null : dataV!;



            using var conn = new SqliteConnection(dataSource);
            using var cmd = conn.CreateCommand();

            var sql = "SELECT * FROM alimentos WHERE 1=1";

            if (codigo.HasValue)    
            {
                sql += " AND codigo = @codigo";
                cmd.Parameters.AddWithValue("@codigo", codigo.Value);
            }

            if (!string.IsNullOrWhiteSpace(nome))
            {
                sql += " AND nome LIKE @nome";
                cmd.Parameters.AddWithValue("@nome", $"%{nome}%");
            }

            if (!string.IsNullOrWhiteSpace(categoria) && categoria != "NENHUM"  && categoria != "TIPO")
            {
                sql += " AND categoria = @categoria";
                cmd.Parameters.AddWithValue("@categoria", categoria);
            }

            if (!string.IsNullOrEmpty(insercao))
            {
                sql += " AND insercao >= @insercao";
                cmd.Parameters.AddWithValue("@insercao", insercao);
            }

            if (!string.IsNullOrEmpty(vencimento))
            {
                sql += " AND vencimento <= @vencimento";
                cmd.Parameters.AddWithValue("@vencimento", vencimento);
            }

            sql += " ORDER BY codigo ASC, categoria";
            cmd.CommandText = sql;

            conn.Open();
            var tabela = new DataTable();
            using (var reader = cmd.ExecuteReader())
            {
                if (!reader.HasRows) MessageBox.Show("Produto não encontrado!", "Informação Inválida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            tabela.Load(cmd.ExecuteReader());
            
            return tabela;
        }

        public void RecriarBanco(DataTable tabela)
        {
            using (var conn = new SqliteConnection(dataSource))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "DELETE FROM alimentos";
                cmd.ExecuteNonQuery();


            }
            foreach (DataRow row in tabela.Rows)
            {
                string nome = row["Nome"].ToString();
                string categoria = row["Categoria"].ToString();
                string vencimento = row["Vencimento"].ToString();
                string insercao = row["Insercao"].ToString();
                string peso = row["Peso"].ToString();
                int codigo = Convert.ToInt32(row["Codigo"]);

                ExecutarInsert(vencimento, insercao, categoria, nome, codigo, peso);
            }

        }

        public int GerarCodigoProduto()
        {
            using (var conn = new SqliteConnection(dataSource))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                
                string sql = "SELECT MAX(Codigo) FROM alimentos";
                cmd.CommandText = sql;
                object result = cmd.ExecuteScalar();

                if (result == DBNull.Value)
                    return 1000;

                return Convert.ToInt32(result) + 1;
            }
            
        }
    }
}
