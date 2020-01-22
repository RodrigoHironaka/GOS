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
    public class BLLOrdemServico
    {
        private DALConexao conexao;
        public BLLOrdemServico(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModelOrdemServico modelo)
        {
            if (modelo.IdCliente <= 0)
            {
                throw new Exception("O cliente é obrigatório!");
            }
            DALOrdemServico DALObj = new DALOrdemServico(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModelOrdemServico modelo)
        {
            if (modelo.IdOS <= 0)
            {
                throw new Exception("Código da OS vazio!");
            }
            if (modelo.IdCliente <= 0)
            {
                throw new Exception("O cliente é obrigatório!");
            }
            DALOrdemServico DALObj = new DALOrdemServico(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALOrdemServico DALObj = new DALOrdemServico(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable LocalizarTodos()
        {
            DALOrdemServico DALObj = new DALOrdemServico(conexao);
            return DALObj.LocalizarTodos();
        }

        public DataTable LocalizarAbertos(String valor)
        {
            DALOrdemServico DALObj = new DALOrdemServico(conexao);
            return DALObj.LocalizarAbertos(valor);
        }

        public DataTable LocalizarFinalizados(String valor)
        {
            DALOrdemServico DALObj = new DALOrdemServico(conexao);
            return DALObj.LocalizarFinalizados(valor);
        }

        public DataTable LocalizarCancelados(String valor)
        {
            DALOrdemServico DALObj = new DALOrdemServico(conexao);
            return DALObj.LocalizarCancelados(valor);
        }

        public ModelOrdemServico CarregaModelOrdemServico(int codigo)
        {
            DALOrdemServico DALObj = new DALOrdemServico(conexao);
            return DALObj.CarregaModelOrdemServico(codigo);
        }
    }
}
