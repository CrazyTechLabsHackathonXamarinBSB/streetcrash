using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetCrash.Model
{
    public class Ocorrencia
    {
        public int Code { get; set; }
        public long Code_Categoria { get; set; }
        public short Code_Status { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Endereco { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public string Outro { get; set; }        
        public bool Resolvido { get; set; }
    }

    public class UpdateStatus
    {
        public int Code { get; set; }
        public bool Resolvido { get; set; }
    }
}
