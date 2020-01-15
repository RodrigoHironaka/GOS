using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLUsuario
    {
        private DALConexao conexao;
        public BLLUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModelUsuario modelo)
        {
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome é obrigatório!");
            }
            modelo.Nome = modelo.Nome.ToUpper();

            if (modelo.Senha.Trim().Length == 0)
            {
                throw new Exception("A senha é obrigatória!");
            }
            if (modelo.Senha.Length < 3)
            {
                throw new Exception("O nome digitado não atinge o limite permitido de 3 caracteres!");
            } 
            modelo.Senha = modelo.Senha.ToUpper();

            if (modelo.NivelAcesso.Trim().Length == 0)
            {
                throw new Exception("O nível de acesso é obrigatório!");
            }

            DALUsuario DALObj = new DALUsuario(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModelUsuario modelo)
        {
            if (modelo.IdUsuario <= 0)
            {
                throw new Exception("Digite o código!");
            }
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome é obrigatório!");
            }
            modelo.Nome = modelo.Nome.ToUpper();

            if (modelo.Senha.Trim().Length == 0)
            {
                throw new Exception("A senha é obrigatória!");
            }
            if (modelo.Senha.Length < 3)
            {
                throw new Exception("A senha digitada não atinge o limite permitido de 3 caracteres!");
            }
            modelo.Senha = modelo.Senha.ToUpper();

            if (modelo.NivelAcesso.Trim().Length == 0)
            {
                throw new Exception("O nível de acesso é obrigatório!");
            }

            DALUsuario DALObj = new DALUsuario(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALUsuario DALObj = new DALUsuario(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable LocalizarAtivos(String valor)
        {
            DALUsuario DALObj = new DALUsuario(conexao);
            return DALObj.LocalizarAtivos(valor);
        }

        public DataTable LocalizarInativos(String valor)
        {
            DALUsuario DALObj = new DALUsuario(conexao);
            return DALObj.LocalizarInativos(valor);
        }

        public DataTable carregaGrid()
        {
            DALUsuario DALObj = new DALUsuario(conexao);
            return DALObj.carregarGrid();
        }

        public ModelUsuario CarregaModelUsuario(int codigo)
        {
            DALUsuario DALObj = new DALUsuario(conexao);
            return DALObj.CarregaModelUsuario(codigo);
        }
    }
}
