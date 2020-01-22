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
            cmd.CommandText = "insert into ordemservico(datainicial, datafinal, observacao, idcliente, situacao) values (@datainicial, @datafinal, @observacao, @idcliente, @situacao); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@datainicial", modelo.DataInicial);
            cmd.Parameters.AddWithValue("@datafinal", modelo.DataFinal);
            cmd.Parameters.AddWithValue("@observacao", modelo.Observacao);
            cmd.Parameters.AddWithValue("@idcliente", modelo.IdCliente);
            cmd.Parameters.AddWithValue("@situacao", modelo.Situacao);
            conexao.Conectar();
            modelo.IdOS = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModelOrdemServico modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update ordemservico set datainicial=@datainicial, datafinal=@datafinal, observacao=@observacao, idcliente=@idcliente, situacao=@situacao where id=@id;";
            cmd.Parameters.AddWithValue("@datainicial", modelo.DataInicial);
            cmd.Parameters.AddWithValue("@datafinal", modelo.DataFinal);
            cmd.Parameters.AddWithValue("@observacao", modelo.Observacao);
            cmd.Parameters.AddWithValue("@idcliente", modelo.IdCliente);
            cmd.Parameters.AddWithValue("@situacao", modelo.Situacao);
            cmd.Parameters.AddWithValue("@id", modelo.IdOS);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from ordemservico where id = @id;";
            cmd.Parameters.AddWithValue("@id", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable LocalizarTodos()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                conexao.Conectar();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from ordemservico order by id", conexao.StringConexao);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
        public DataTable LocalizarAbertos(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from ordemservico where id like '%" + valor + "%' and situacao = 'ABERTO' order by id", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarFinalizados(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from ordemservico where id like '%" + valor + "%' and situacao = 'FINALIZADO' order by id", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarCancelados(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from ordemservico where id like '%" + valor + "%' and situacao = 'CANCELADO' order by id", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
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
                modelo.DataInicial = Convert.ToString(registro["dataincial"]);
                modelo.DataFinal = Convert.ToString(registro["datafinal"]);
                modelo.Observacao = Convert.ToString(registro["observacao"]);
                modelo.IdCliente = Convert.ToInt32(registro["idcliente"]);
                modelo.Situacao = Convert.ToString(registro["situacao"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }
   
    }
}
