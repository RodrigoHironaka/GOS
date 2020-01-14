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
    public class BLLDepartamento
    {
        private DALConexao conexao;
        public BLLDepartamento(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModelDepartamento modelo)
        {
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome é obrigatório!");
            }
            modelo.Nome = modelo.Nome.ToUpper();

            DALDepartamento DALObj = new DALDepartamento(conexao);
            DALObj.Incluir(modelo);
        }

        public void Alterar(ModelDepartamento modelo)
        {
            if (modelo.IdDep <= 0)
            {
                throw new Exception("Digite o código!");
            }
            if (modelo.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome é obrigatório!");
            }
            modelo.Nome = modelo.Nome.ToUpper();

            DALDepartamento DALObj = new DALDepartamento(conexao);
            DALObj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALDepartamento DALObj = new DALDepartamento(conexao);
            DALObj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALDepartamento DALObj = new DALDepartamento(conexao);
            return DALObj.Localizar(valor);
        }

        public DataTable LocalizarInativos(String valor)
        {
            DALDepartamento DALObj = new DALDepartamento(conexao);
            return DALObj.LocalizarInativos(valor);
        }

        public DataTable carregaGrid()
        {
            DALDepartamento DALObj = new DALDepartamento(conexao);
            return DALObj.carregarGrid();
        }

        public ModelDepartamento CarregaModelDepartamento(int codigo)
        {
            DALDepartamento DALObj = new DALDepartamento(conexao);
            return DALObj.CarregaModelDepartamento(codigo);
        }
    }
}
