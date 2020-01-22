using System;
using System.Collections.Generic;


namespace Model
{
    public class ModelOrdemServico
    {
        public int IdOS { get; set; }
        public string DataInicial { get; set; }
        public string DataFinal { get; set; }
        public string Situacao { get; set; }
        public string Observacao { get; set; }
        public int IdCliente { get; set; }

    }
}
