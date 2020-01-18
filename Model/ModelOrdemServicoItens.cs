using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelOrdemServicoItens
    {
        public int IdOSItens { get; set; }
        public int IdServico { get; set; }
        public int IdOS { get; set; }
        public String Detalhes { get; set; }
    }
}
