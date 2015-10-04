using StreetCrash.DAO.LinqToSql;
using StreetCrash.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetCrash.DAO
{
    public class ImagemDAO
    {
        StreetCrashDataContext _context;
        public ImagemDAO()
        {
            _context = new StreetCrashDataContext();
        }

        public void Inserir(Imagem model)
        { 
            _context.IMAGEMs.InsertOnSubmit(new IMAGEM
            {
                CODE_OCORRENCIA = model.Code_Ocorrencia,
                IMAGEM1 = new System.Data.Linq.Binary(model.Imagem_Ocorrencia.ToArray()),
                DESCRICAO = model.Descricao
            }); 
            _context.SubmitChanges();
        }
    }
}
