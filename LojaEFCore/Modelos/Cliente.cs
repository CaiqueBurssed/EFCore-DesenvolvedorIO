﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LojaEFCore.Domain
{
    class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }

    }
}
