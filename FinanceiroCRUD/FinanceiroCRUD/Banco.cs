using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace FinanceiroCRUD
{
    internal class Banco
    {
            private string connectionString = @"Data Source=localhost;Initial Catalog=financeiroBD;User ID=Financei; password=senha123; Integrated Security=True;TrustServerCertificate=true;";
            private SqlConnection cn;

        public Lancamentos Consultar(int id)
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                using (SqlCommand comando = new SqlCommand(
                    "SELECT Id, Descricao, Valor, Data, Tipo FROM Lancamentos WHERE Id = @id", conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    conexao.Open();

                    using (SqlDataReader rdr = comando.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            var l = new Lancamentos
                            {
                                Id = rdr.GetInt32(rdr.GetOrdinal("Id")),
                                Descricao = rdr.GetString(rdr.GetOrdinal("Descricao")),
                                Valor = rdr.GetDecimal(rdr.GetOrdinal("Valor")),
                                Data = rdr.GetDateTime(rdr.GetOrdinal("Data")),
                                Tipo = rdr.GetString(rdr.GetOrdinal("Tipo"))[0]
                            };
                            return l;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro ao consultar transação: " + ex.Message);
            }

            return null;
        }

        public DataTable executarConsultaGenerica(string sql)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(connectionString);
                SqlCommand comando = new SqlCommand(sql, conexao);
                SqlDataAdapter da = new SqlDataAdapter(comando);

                DataTable tabela = new DataTable();
                da.Fill(tabela);

                return tabela;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro ao consultar: " + ex.Message);
                return null;
            }
        }
        public bool Adicionar(Lancamentos l)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(connectionString);
                conexao.Open();

                string sql = "INSERT INTO Lancamentos (Descricao, Valor, Data, Tipo) VALUES (@d, @v, @dt, @t)";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@d", l.Descricao);
                comando.Parameters.AddWithValue("@v", l.Valor);
                comando.Parameters.AddWithValue("@dt", l.Data);
                comando.Parameters.AddWithValue("@t", l.Tipo);

                int linhas = comando.ExecuteNonQuery();
                conexao.Close();

                return linhas > 0;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro ao inserir: " + ex.Message);
                return false;
            }
        }
        public bool Atualizar(int id, string descricao, decimal valor, string tipo, DateTime data)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(connectionString);
                conexao.Open();

                string sql = "UPDATE Lancamentos SET Descricao=@d, Valor=@v, Tipo=@t, Data=@dt WHERE Id=@id";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@d", descricao);
                comando.Parameters.AddWithValue("@v", valor);
                comando.Parameters.AddWithValue("@t", tipo);
                comando.Parameters.AddWithValue("@dt", data);
                comando.Parameters.AddWithValue("@id", id);

                int linhas = comando.ExecuteNonQuery();
                conexao.Close();

                return linhas > 0;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro ao atualizar: " + ex.Message);
                return false;
            }
        }
        public bool Excluir(int id)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(connectionString);
                conexao.Open();

                string sql = "DELETE FROM Lancamentos WHERE Id=@id";

                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.AddWithValue("@id", id);

                int linhas = comando.ExecuteNonQuery();
                conexao.Close();

                return linhas > 0;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro ao excluir: " + ex.Message);
                return false;
            }
        }
        public decimal CalcularSaldo()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(connectionString);
                conexao.Open();

                string sql = "SELECT SUM(CASE WHEN Tipo='E' THEN Valor ELSE -Valor END) FROM Lancamentos";

                SqlCommand comando = new SqlCommand(sql, conexao);
                object result = comando.ExecuteScalar();

                conexao.Close();

                return result == DBNull.Value ? 0 : Convert.ToDecimal(result);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro ao calcular saldo: " + ex.Message);
                return 0;
            }
        }
    }
}
