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
    public class DALDepartamento
    {
        private DALConexao conexao;
        public DALDepartamento(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModelDepartamento modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into departamento(nome, situacao) values (@nome, @situacao); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@situacao", modelo.Situacao);
            conexao.Conectar();
            modelo.IdDep = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModelDepartamento modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update departamento set nome=@nome, situacao=@situacao where id=@id;";
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@situacao", modelo.Situacao);
            cmd.Parameters.AddWithValue("@id", modelo.IdDep);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from departamento where id = @id;";
            cmd.Parameters.AddWithValue("@id", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from departamento where nome like '%" + valor + "%' and situacao = 'A'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarInativos(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from departamento where nome like '%" + valor + "%' and situacao = 'I'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModelDepartamento CarregaModelDepartamento(int codigo)
        {
            ModelDepartamento modelo = new ModelDepartamento();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from departamento where id = @id";
            cmd.Parameters.AddWithValue("@id", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IdDep = Convert.ToInt32(registro["id"]);
                modelo.Nome = Convert.ToString(registro["nome"]);
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
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from departamento where situacao = 'A'", conexao.StringConexao);
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
