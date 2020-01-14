using System;
using System.Collections.Generic;


namespace Model
{
    public class ModeloOrdemServico
    {
        public int IdOS { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public String Situacao { get; set; }
        public String Observacao { get; set; }
        public int IdCliente { get; set; }

    }
}
