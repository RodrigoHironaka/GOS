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
    public class DALServico
    {
        private DALConexao conexao;
        public DALServico(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModelServico modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into servico(nome, descricao, situacao) values (@nome, @descricao, @situacao); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);
            cmd.Parameters.AddWithValue("@situacao", modelo.Situacao);
            conexao.Conectar();
            modelo.IdServico = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModelServico modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update servico set nome=@nome, descricao=@descricao, situacao=@situacao where id=@id;";
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);
            cmd.Parameters.AddWithValue("@situacao", modelo.Situacao);
            cmd.Parameters.AddWithValue("@id", modelo.IdServico);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from servico where id = @id;";
            cmd.Parameters.AddWithValue("@id", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable LocalizarAtivos(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from servico where nome like '%" + valor + "%' and situacao = 'A' order by id", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarInativos(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from servico where nome like '%" + valor + "%' and situacao = 'I' order by id", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModelServico CarregaModelServico(int codigo)
        {
            ModelServico modelo = new ModelServico();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from servico where id = @id";
            cmd.Parameters.AddWithValue("@id", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IdServico = Convert.ToInt32(registro["id"]);
                modelo.Nome = Convert.ToString(registro["nome"]);
                modelo.Descricao = Convert.ToString(registro["descricao"]);
                modelo.Situacao = Convert.ToString(registro["situacao"]);
            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }

        public DataTable carregarGrid()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                conexao.Conectar();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from servico order by id", conexao.StringConexao);
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
    }
}
