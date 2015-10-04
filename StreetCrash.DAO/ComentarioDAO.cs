using StreetCrash.DAO.LinqToSql;
using StreetCrash.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetCrash.DAO
{
    public class ComentarioDAO
    {
        StreetCrashDataContext _context;
        public ComentarioDAO()
        {
            _context = new StreetCrashDataContext();
        }
        public void Inserir(Comentario model)
        {
            _context.COMENTARIOs.InsertOnSubmit(new COMENTARIO
            {
                CODE_OCORRENCIA = model.Code_Ocorrencia,
                DESCRICAO = model.Descricao
            });
            _context.SubmitChanges();
        }
    }
}
