using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class ModelUsuario
    {
        public int IdUsuario { get; set; }
        public String Nome { get; set; }
        public String Senha { get; set; }
        public String NivelAcesso { get; set; }
        public String Situacao { get; set; }

    }
}
