﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetCrash.Model
{
    public class Comentario
    {
        public long Code { get; set; }
        public long Code_Ocorrencia { get; set; }
        public string Descricao { get; set; }
        public DateTime Data_Cadastro { get; set; }
    }
}
