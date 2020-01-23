using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALOrdemServicoItens
    {
        private DALConexao conexao;
        public DALOrdemServicoItens(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModelOrdemServicoItens modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "insert into ordemservicoitens (idos, idservico, detalhes) values (@idos, @idservico, @detalhes); select @@IDENTITY;";
            //cmd.Parameters.AddWithValue("@id", modelo.IdOSItens);
            cmd.Parameters.AddWithValue("@idos", modelo.IdOS);
            cmd.Parameters.AddWithValue("@idservico", modelo.IdServico);
            cmd.Parameters.AddWithValue("@detalhes", modelo.Detalhes);
            modelo.IdOS = Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void Alterar(ModelOrdemServicoItens modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "update ordemservicoitens set idos=@idos, idservico=@idservico, detalhes=@detalhes where id=@id;";
            cmd.Parameters.AddWithValue("@idos", modelo.IdOS);
            cmd.Parameters.AddWithValue("@idservico", modelo.IdServico);
            cmd.Parameters.AddWithValue("@detalhes", modelo.Detalhes);;
            cmd.Parameters.AddWithValue("@id", modelo.IdOSItens);
            cmd.ExecuteNonQuery();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "delete from ordemservicoitens where id = @id;";
            cmd.Parameters.AddWithValue("@id", codigo);
            cmd.ExecuteNonQuery();
        }

        //public DataTable Localizar(int cod)
        //{
        //    DataTable tabela = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter("select osi.* from ordemservicoitens osi i inner join servico s  on(d) where i.ven_cod = "
        //        + cod.ToString(), conexao.StringConexao);
        //    da.Fill(tabela);
        //    return tabela;
        //}

        public ModelOrdemServicoItens CarregaModelOrdemServicoItens(int codigo)
        {
            ModelOrdemServicoItens modelo = new ModelOrdemServicoItens();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from ordemservicoitens where id = @id";
            cmd.Parameters.AddWithValue("@id", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IdOSItens = Convert.ToInt32(registro["id"]);
                modelo.IdOS = Convert.ToInt32(registro["idos"]);
                modelo.IdServico = Convert.ToInt32(registro["idservico"]);
                modelo.Detalhes = Convert.ToString(registro["detalhes"]);

            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }

        public void ExcluirTodosOsItens(int OScod)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "delete from ordemservicoitens where id = @id ";
            cmd.Parameters.AddWithValue("@id", OScod);

            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }
    }
}
