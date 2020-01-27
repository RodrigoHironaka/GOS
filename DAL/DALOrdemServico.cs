using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DALOrdemServico
    {
        private DALConexao conexao;
        public DALOrdemServico(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModelOrdemServico modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "insert into ordemservico (datainicial, datafinal, observacao, situacao, idcliente) values (@datainicial, @datafinal, @observacao, @situacao, @idcliente); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@datainicial", modelo.DataInicial);
            cmd.Parameters.AddWithValue("@datafinal", modelo.DataFinal);
            cmd.Parameters.AddWithValue("@observacao", modelo.Observacao);
            cmd.Parameters.AddWithValue("@situacao", modelo.Situacao);
            cmd.Parameters.AddWithValue("@idcliente", modelo.IdCliente);
            modelo.IdOS = Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void Alterar(ModelOrdemServico modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "update ordemservico set datainicial=@datainicial, datafinal=@datafinal, observacao=@observacao, situacao=@situacao, idcliente=@idcliente where id=@id;";
            cmd.Parameters.AddWithValue("@datainicial", modelo.DataInicial);
            cmd.Parameters.AddWithValue("@datafinal", modelo.DataFinal);
            cmd.Parameters.AddWithValue("@observacao", modelo.Observacao);
            cmd.Parameters.AddWithValue("@situacao", modelo.Situacao);
            cmd.Parameters.AddWithValue("@idcliente", modelo.IdCliente);
            cmd.Parameters.AddWithValue("@id", modelo.IdOS);
            cmd.ExecuteNonQuery();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "delete from ordemservico where id = @id;";
            cmd.Parameters.AddWithValue("@id", codigo);
            cmd.ExecuteNonQuery();
        }

        public DataTable LocalizarTodos(String valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = "select os.*, c.nome as cliNome, c.razaosocial as cliRazao from ordemservico os " +
                    " inner join cliente c on (os.idcliente = c.id)" +
                     " where (os.id like '%" + valor + "%' or c.razaosocial like '%" + valor + "%' or c.nome like '%" + valor + "%')" +
                    " order by os.id";
                SqlDataAdapter da = new SqlDataAdapter(sql, conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public DataTable LocalizarAbertos(String valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select os.*, c.nome as cliNome, c.razaosocial as cliRazao from ordemservico os" +
                    " inner join cliente c on (os.idcliente = c.id) " +
                    " where (os.id like '%" + valor + "%' or c.razaosocial like '%" + valor + "%' or c.nome like '%" + valor + "%')" +
                    " and os.situacao = 'ABERTO' order by os.id", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }

        }

        public DataTable LocalizarFinalizados(String valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select os.*, c.nome as cliNome, c.razaosocial as cliRazao from ordemservico os" +
                    " inner join cliente c on (os.idcliente = c.id) " +
                    " where (os.id like '%" + valor + "%' or c.razaosocial like '%" + valor + "%' or c.nome like '%" + valor + "%')" +
                    " and os.situacao = 'FINALIZADO' order by os.id", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        public DataTable LocalizarCancelados(String valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select os.*, c.nome as cliNome, c.razaosocial as cliRazao from ordemservico os" +
                    " inner join cliente c on (os.idcliente = c.id) " +
                    " where (os.id like '%" + valor + "%' or c.razaosocial like '%" + valor + "%' or c.nome like '%" + valor + "%')" +
                    " and os.situacao = 'CANCELADO' order by os.id", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }

        }

        public ModelOrdemServico CarregaModelOrdemServico(int codigo)
        {
            ModelOrdemServico modelo = new ModelOrdemServico();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from ordemservico where id = @id";
            cmd.Parameters.AddWithValue("@id", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IdOS = Convert.ToInt32(registro["id"]);
                modelo.DataInicial = Convert.ToString(registro["datainicial"]);
                modelo.DataFinal = Convert.ToString(registro["datafinal"]);
                modelo.Observacao = Convert.ToString(registro["observacao"]);
                modelo.Situacao = Convert.ToString(registro["situacao"]);
                modelo.IdCliente = Convert.ToInt32(registro["idcliente"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }

        public Boolean CancelarOS(int codigo)
        {
            Boolean retorno = true;
            //Atualizar a tabela de OS
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            conexao.Conectar();
            conexao.IniciarTransacao();
            try
            {
                cmd.Transaction = this.conexao.ObjetoTransacao;
                cmd.CommandText = "update ordemservico set situacao= 'CANCELADO'" +
                    "where id=@id;";
                cmd.Parameters.AddWithValue("@id", codigo);
                cmd.ExecuteNonQuery();

                conexao.TerminarTransacao();
                conexao.Desconectar();
            }
            catch
            {
                conexao.CancelaTransacao();
                conexao.Desconectar();
                retorno = false;
            }
            return retorno;
        }

        public DataTable Pesquisa(String valor)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select os.*, c.nome as cliNome, c.razaosocial as cliRazao from ordemservico os" +
                    " inner join cliente c on (os.idcliente = c.id) " +
                    " where (os.id like '%" + valor + "%' or c.razaosocial like '%" + valor + "%' or c.nome like '%" + valor + "%')" +
                    " order by os.id", conexao.StringConexao);
                da.Fill(tabela);
                return tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }

        }
    }
}
