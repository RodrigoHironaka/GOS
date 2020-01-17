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
    public class DALUsuario
    {
        private DALConexao conexao;
        public DALUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModelUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into usuario(nome, senha, nivelacesso, situacao) values (@nome, @senha, @nivelacesso, @situacao); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@senha", modelo.Senha);
            cmd.Parameters.AddWithValue("@nivelacesso", modelo.NivelAcesso);
            cmd.Parameters.AddWithValue("@situacao", modelo.Situacao);
            conexao.Conectar();
            modelo.IdUsuario = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModelUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update usuario set nome=@nome, senha=@senha, nivelacesso=@nivelacesso, situacao=@situacao where id=@id;";
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@senha", modelo.Senha);
            cmd.Parameters.AddWithValue("@nivelacesso", modelo.NivelAcesso);
            cmd.Parameters.AddWithValue("@situacao", modelo.Situacao);
            cmd.Parameters.AddWithValue("@id", modelo.IdUsuario);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from usuario where id = @id;";
            cmd.Parameters.AddWithValue("@id", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable LocalizarAtivos(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from usuario where nome like '%" + valor + "%' and situacao = 'A' order by id", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarInativos(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from usuario where nome like '%" + valor + "%' and situacao = 'I' order by id", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModelUsuario CarregaModelUsuario(int codigo)
        {
            ModelUsuario modelo = new ModelUsuario();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from usuario where id = @id";
            cmd.Parameters.AddWithValue("@id", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IdUsuario = Convert.ToInt32(registro["id"]);
                modelo.Nome = Convert.ToString(registro["nome"]);
                modelo.Senha = Convert.ToString(registro["senha"]);
                modelo.NivelAcesso = Convert.ToString(registro["nivelacesso"]);
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
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from usuario order by id", conexao.StringConexao);
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
