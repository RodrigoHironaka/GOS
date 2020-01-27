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
            cmd.CommandText = "update ordemservicoitens set detalhes=@detalhes where id=@id and idos= @idos and idservico= @idservico;";
            cmd.Parameters.AddWithValue("@idos", modelo.IdOS);
            cmd.Parameters.AddWithValue("@idservico", modelo.IdServico);
            cmd.Parameters.AddWithValue("@detalhes", modelo.Detalhes);;
            cmd.Parameters.AddWithValue("@id", modelo.IdOSItens);
            cmd.ExecuteNonQuery();
        }

        public void Excluir(int idOSitens, int idOs, int idServico)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "delete from ordemservicoitens where id = @id and id=@id and idos= @idos and idservico= @idservico;";
            cmd.Parameters.AddWithValue("@id", idOSitens);
            cmd.Parameters.AddWithValue("@idos", idOs);
            cmd.Parameters.AddWithValue("@idservico", idServico);
            cmd.ExecuteNonQuery();
        }

        public DataTable Localizar(int codigo)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select osi.*, s.id as idser, s.nome as nomeser from ordemservicoitens osi " + 
                " inner join servico s on (osi.idservico = s.id)"+
                " where osi.idos = " + codigo.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModelOrdemServicoItens CarregaModelOrdemServicoItens(int idOSitens, int idOs, int idServico)
        {
            ModelOrdemServicoItens modelo = new ModelOrdemServicoItens();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from ordemservicoitens where id = @id and idos = @idos and idservico = @idservico";
            cmd.Parameters.AddWithValue("@id", idOSitens);
            cmd.Parameters.AddWithValue("@idos", idOs);
            cmd.Parameters.AddWithValue("@idservico", idServico);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IdOSItens = idOSitens;
                modelo.IdOS = idOs;
                modelo.IdServico = idServico;
                modelo.Detalhes = Convert.ToString(registro["detalhes"]);

            }
            registro.Close();
            conexao.Desconectar();
            return modelo;
        }

        public void ExcluirTodosOsItens( int idOs)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.Transaction = this.conexao.ObjetoTransacao;
            cmd.CommandText = "delete from ordemservicoitens where idos= @idos";
            cmd.Parameters.AddWithValue("@idos", idOs);

            //conexao.Conectar();
            cmd.ExecuteNonQuery();
            //conexao.Desconectar();
        }
    }
}
