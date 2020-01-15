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
    public class BLLServico
    {
        private DALConexao conexao;
        public BLLServico(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModelServico modelo)
        {
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome é obrigatório!");
            }
            modelo.Nome = modelo.Nome.ToUpper();

            DALServico DALObj = new DALServico(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModelServico modelo)
        {
            if (modelo.IdServico <= 0)
            {
                throw new Exception("Digite o código!");
            }
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome é obrigatório!");
            }
            modelo.Nome = modelo.Nome.ToUpper();

            DALServico DALObj = new DALServico(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALServico DALObj = new DALServico(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable LocalizarAtivos(String valor)
        {
            DALServico DALObj = new DALServico(conexao);
            return DALObj.LocalizarAtivos(valor);
        }

        public DataTable LocalizarInativos(String valor)
        {
            DALServico DALObj = new DALServico(conexao);
            return DALObj.LocalizarInativos(valor);
        }

        public DataTable carregaGrid()
        {
            DALServico DALObj = new DALServico(conexao);
            return DALObj.carregarGrid();
        }

        public ModelServico CarregaModelServico(int codigo)
        {
            DALServico DALObj = new DALServico(conexao);
            return DALObj.CarregaModelServico(codigo);
        }
    }
}

