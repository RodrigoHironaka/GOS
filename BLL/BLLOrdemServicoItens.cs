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
    public class BLLOrdemServicoItens
    {
        private DALConexao conexao;
        public BLLOrdemServicoItens(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModelOrdemServicoItens modelo)
        {
            if (modelo.IdOS <= 0)
            {
                throw new Exception("O código da OS deve ser maior que zero!");
            }
            if (modelo.IdServico <= 0)
            {
                throw new Exception("O código do servico deve ser maior que zero!");
            }
            DALOrdemServicoItens DALObj = new DALOrdemServicoItens(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModelOrdemServicoItens modelo)
        {
            if (modelo.IdOSItens <= 0)
            {
                throw new Exception("O código dos itens da OS deve ser maior que zero");
            }
            if (modelo.IdOS <= 0)
            {
                throw new Exception("O código da OS deve ser maior que zero!");
            }
            if (modelo.IdServico <= 0)
            {
                throw new Exception("O código do servico deve ser maior que zero!");
            }
            DALOrdemServicoItens DALObj = new DALOrdemServicoItens(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int idOSitens, int idOs, int idServico)
        {
            DALOrdemServicoItens DALObj = new DALOrdemServicoItens(conexao);
            DALObj.Excluir(idOSitens, idOs, idServico);
        }

        public DataTable Localizar(int codigo)
        {
            DALOrdemServicoItens DALObj = new DALOrdemServicoItens(conexao);
            return DALObj.Localizar(codigo);
        }

        public ModelOrdemServicoItens CarregaModelOrdemServicoItens(int idOSitens, int idOs, int idServico)
        {
            DALOrdemServicoItens DALObj = new DALOrdemServicoItens(conexao);
            return DALObj.CarregaModelOrdemServicoItens(idOSitens, idOs, idServico);
        }

        public void ExcluirTodosOsItens(int idOS)
        {
            if (idOS <= 0)
            {
                throw new Exception("O código da os é obrigatório");
            }

            DALOrdemServicoItens DALObj = new DALOrdemServicoItens(conexao);
            DALObj.ExcluirTodosOsItens(idOS);
        }
    }
}
