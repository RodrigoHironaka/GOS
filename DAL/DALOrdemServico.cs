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
                modelo.Situacao = Convert.ToString(registro["situacao"]);
                modelo.IdCliente = Convert.ToInt32(registro["idcliente"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }

    }
}
