using StreetCrash.DAO.LinqToSql;
using StreetCrash.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetCrash.DAO
{
    public class OcorrenciaDAO
    {
        StreetCrashDataContext _context;
        public OcorrenciaDAO()
        {
            _context = new StreetCrashDataContext();
        }
        public void Inserir(Ocorrencia model)
        {
            _context.OCORRENCIAs.InsertOnSubmit(new OCORRENCIA
            {
                CODE_CATEGORIA = model.Code_Categoria,
                CODE_STATUS = model.Code_Status,
                LATITUDE = model.Latitude,
                LONGITUDE = model.Longitude,
                ENDERECO = model.Endereco,
                DATA_CADASTRO = model.Data_Cadastro,
                OUTRO = model.Outro,
                RESOLVIDO = false
            });
            _context.SubmitChanges();
        }

        public void UpdateStatus(UpdateStatus model)
        {
            OCORRENCIA ocorrencia = _context.OCORRENCIAs.Where(o => o.CODE == model.Code).SingleOrDefault();
            ocorrencia.RESOLVIDO = model.Resolvido;
            _context.SubmitChanges();
        } 
        
               
    }
}
