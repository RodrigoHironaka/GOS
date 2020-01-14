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
    public class DALCliente
    {
        private DALConexao conexao;

        public DALCliente(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModelCliente modelo)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into cliente(nome,cpfcnpj,rgie,razaosocial,tipopessoa,cep,endereco,endnumero,complemento,bairro,telefone,celular,celular2,email,cidade,uf, datanasc, datacadastro,situacao,iddepartamento)" +
                " values (@nome,@cpfcnpj,@rgie,@razaosocial,@tipopessoa,@cep,@endereco,@endnumero,@complemento,@bairro,@telefone,@celular,@celular2,@email,@cidade,@uf,@datanasc,@datacadastro,@situacao,@iddepartamento);";
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@cpfcnpj", modelo.CPFCNPJ);
            cmd.Parameters.AddWithValue("@rgie", modelo.RGIE); 
            cmd.Parameters.AddWithValue("@razaosocial", modelo.RazaoSocial);
            cmd.Parameters.AddWithValue("@tipopessoa", modelo.TipoPessoa);
            cmd.Parameters.AddWithValue("@cep", modelo.CEP);
            cmd.Parameters.AddWithValue("@endereco", modelo.Endereco);
            cmd.Parameters.AddWithValue("@endnumero", modelo.EndNumero);
            cmd.Parameters.AddWithValue("@complemento", modelo.Complemento);
            cmd.Parameters.AddWithValue("@bairro", modelo.Bairro);
            cmd.Parameters.AddWithValue("@telefone", modelo.Telefone);
            cmd.Parameters.AddWithValue("@celular", modelo.Celular);
            cmd.Parameters.AddWithValue("@celular2", modelo.Celular2);
            cmd.Parameters.AddWithValue("@email", modelo.Email);
            cmd.Parameters.AddWithValue("@cidade", modelo.Cidade);
            cmd.Parameters.AddWithValue("@uf", modelo.UF);
            cmd.Parameters.AddWithValue("@datanascimento", modelo.DataNasc);
            cmd.Parameters.AddWithValue("@datacadastro", modelo.DataCadastro); 
            cmd.Parameters.AddWithValue("@situacao", modelo.Situacao);
            cmd.Parameters.AddWithValue("@iddepartamento", modelo.IdDepartamento);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Alterar(ModelCliente modelo)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update cliente set nome=@nome,cpfcnpj=@cpfcnpj,rgie=@rgie,razaosocial=@razaosocial,tipopessoa=@tipopessoa,cep=@cep,endereco=@endereco,endnumero=@endnumero,complemento=@complemento,bairro=@bairro,telefone=@telefone,celular=@celular,celular2=@celular2,email=@email,cidade=@cidade,uf=@uf, datanasc=@datanasc, datacadastro=@datacadastro,situacao=@situacao,iddepartamento=@iddepartamento where id=@id;";
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);
            cmd.Parameters.AddWithValue("@cpfcnpj", modelo.CPFCNPJ);
            cmd.Parameters.AddWithValue("@rgie", modelo.RGIE);
            cmd.Parameters.AddWithValue("@razaosocial", modelo.RazaoSocial);
            cmd.Parameters.AddWithValue("@tipopessoa", modelo.TipoPessoa);
            cmd.Parameters.AddWithValue("@cep", modelo.CEP);
            cmd.Parameters.AddWithValue("@endereco", modelo.Endereco);
            cmd.Parameters.AddWithValue("@endnumero", modelo.EndNumero);
            cmd.Parameters.AddWithValue("@complemento", modelo.Complemento);
            cmd.Parameters.AddWithValue("@bairro", modelo.Bairro);
            cmd.Parameters.AddWithValue("@telefone", modelo.Telefone);
            cmd.Parameters.AddWithValue("@celular", modelo.Celular);
            cmd.Parameters.AddWithValue("@celular2", modelo.Celular2);
            cmd.Parameters.AddWithValue("@email", modelo.Email);
            cmd.Parameters.AddWithValue("@cidade", modelo.Cidade);
            cmd.Parameters.AddWithValue("@uf", modelo.UF);
            cmd.Parameters.AddWithValue("@datanascimento", modelo.DataNasc);
            cmd.Parameters.AddWithValue("@datacadastro", modelo.DataCadastro);
            cmd.Parameters.AddWithValue("@situacao", modelo.Situacao);
            cmd.Parameters.AddWithValue("@iddepartamento", modelo.IdDepartamento);
            cmd.Parameters.AddWithValue("@id", modelo.IdCliente);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from cliente where id = @id;";
            cmd.Parameters.AddWithValue("@id", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            string sql = "select * from cliente where razaosocial like '%" + valor + "%'" + " or id like '%" + valor + "%'" + " or nome like '%" + valor + "%' and situacao = 'A'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarInativos(String valor)
        {
            DataTable tabela = new DataTable();
            string sql = "select * from cliente where razaosocial like '%" + valor + "%'" + " or id like '%" + valor + "%'" + " or nome like '%" + valor + "%' and situacao = 'I'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModelCliente CarregaModelCliente(int codigo)
        {
            ModelCliente modelo = new ModelCliente();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from cliente where id = @id";
            cmd.Parameters.AddWithValue("@id", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IdCliente = Convert.ToInt32(registro["id"]);
                modelo.Nome = Convert.ToString(registro["nome"]);
                modelo.CPFCNPJ = Convert.ToString(registro["cpfcnpj"]);
                modelo.RGIE = Convert.ToString(registro["rgie"]);
                modelo.RazaoSocial = Convert.ToString(registro["razaosocial"]);
                modelo.TipoPessoa = Convert.ToString(registro["tipopessoa"]);
                modelo.CEP = Convert.ToString(registro["cep"]);
                modelo.Endereco = Convert.ToString(registro["endereco"]);
                modelo.EndNumero = Convert.ToString(registro["endnumero"]);
                modelo.Complemento = Convert.ToString(registro["complemento"]);
                modelo.Bairro = Convert.ToString(registro["bairro"]);
                modelo.Telefone = Convert.ToString(registro["telefone"]);
                modelo.Celular = Convert.ToString(registro["celular"]);
                modelo.Celular2 = Convert.ToString(registro["celular2"]);
                modelo.Email = Convert.ToString(registro["email"]);
                modelo.Cidade = Convert.ToString(registro["cidade"]);
                modelo.UF = Convert.ToString(registro["uf"]);
                modelo.DataNasc = Convert.ToDateTime(registro["datanasc"]);
                modelo.DataCadastro = Convert.ToString(registro["datacadastro"]);
                modelo.Situacao = Convert.ToString(registro["situacao"]);
                modelo.IdDepartamento = Convert.ToInt32(registro["iddepartamento"]);
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
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from cliente where situacao = 'A'", conexao.StringConexao);
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
