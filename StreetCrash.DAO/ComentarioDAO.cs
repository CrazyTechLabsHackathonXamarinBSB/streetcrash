using StreetCrash.DAO.LinqToSql;
using StreetCrash.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace StreetCrash.DAO
{
    public class ComentarioDAO
    {
        StreetCrashDataContext _context;
        public ComentarioDAO()
        {
            _context = new StreetCrashDataContext();
        }
        public string Inserir(Comentario model)
        {
            try
            {
                COMENTARIO cmt = new COMENTARIO();
                cmt.CODE_OCORRENCIA = model.Code_Ocorrencia;
                cmt.DATA_CADASTRO = DateTime.Now;
                cmt.DESCRICAO = model.Descricao;

                _context.COMENTARIOs.InsertOnSubmit(cmt);
                _context.SubmitChanges();
                return "Comentário cadastrado com sucesso.";
            }
            catch(Exception)
            {
                throw new Exception("Erro ao cadastrar comentário. Por favor tente novamente.");
            }
        }

        public IEnumerable<Comentario> ConsultaComentario(long code_Ocorrencia, int number_page)
        {
            try
            {
                using (var txt = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
                {
                    return _context.PRC_LISTAR_COMENTARIO(code_Ocorrencia, number_page).Select(n => new Comentario
                    {
                        Code = (long)n.CODE,
                        Code_Ocorrencia = n.CODE_OCORRENCIA,
                        Data_Cadastro = n.DATA_CADASTRO,
                        Descricao = n.DESCRICAO
                    });
                }
            }
            catch(Exception)
            {
                throw new Exception("Erro a listar comentários. Por favor tente novamente");
            }
        }
    }
}
