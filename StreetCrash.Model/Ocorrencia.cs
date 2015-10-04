using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetCrash.Model
{
    public class Ocorrencia
    {
        public long Code { get; set; }
        public Categoria Categoria { get; set; }
        public Status Status { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Endereco { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public string Outro { get; set; }
        public bool Resolvido { get; set; }
    }

    public class Detalhe_Ocorrencia : Ocorrencia
    {
        public List<Imagem> Imagens { get; set; }
        public List<Comentario> Comentarios { get; set; }
    }

    public class Raio
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }

    public class UpdateStatus
    {
        public int Code { get; set; }
        public bool Resolvido { get; set; }
    }
}
