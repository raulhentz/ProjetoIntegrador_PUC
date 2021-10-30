﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PinguinoApp.API.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sku { get; set; }
        public string Codigobarras { get; set; }
        public int Fornecedor { get; set; }
        public string Descricao { get; set; }
        public decimal Precovenda { get; set; }
        public bool Ativo { get; set; }


    }
}
