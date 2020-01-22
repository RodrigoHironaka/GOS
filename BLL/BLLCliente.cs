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
    public class BLLCliente
    {
        private DALConexao conexao;
        public BLLCliente(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModelCliente modelo)
        {
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome é obrigatório!");
            }
            modelo.Nome = modelo.Nome.ToUpper();

            DALCliente DALObj = new DALCliente(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModelCliente modelo)
        {
            if (modelo.IdCliente <= 0)
            {
                throw new Exception("Digite o código!");
            }
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome é obrigatório!");
            }
            modelo.Nome = modelo.Nome.ToUpper();

            DALCliente DALObj = new DALCliente(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALCliente DALObj = new DALCliente(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable LocalizarAtivos(String valor)
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.LocalizarAtivos(valor);
        }

        public DataTable LocalizarInativos(String valor)
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.LocalizarInativos(valor);
        }

        public DataTable carregaGrid()
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.carregarGrid();
        }
        public DataTable LocalizarTodosAtivos()
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.LocalizarTodosAtivos();
        }

        public ModelCliente CarregaModelCliente(int codigo)
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.CarregaModelCliente(codigo);
        }

        public DataTable CarregaComboDepartamentos()
        {
            DALCliente DALObj = new DALCliente(conexao);
            return DALObj.CarregaComboDepartamentos();
        }
    }
}
