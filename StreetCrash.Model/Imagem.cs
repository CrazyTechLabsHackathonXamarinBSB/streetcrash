﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetCrash.Model
{
    public class Imagem
    {
        public int Code { get; set; }
        public long Code_Ocorrencia { get; set; }
        public byte[] Imagem_Ocorrencia { get; set; }
        public string Descricao { get; set; }
    }
}
