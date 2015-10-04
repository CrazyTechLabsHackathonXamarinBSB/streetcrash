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
    public class ImagemDAO
    {
        StreetCrashDataContext _context;
        public ImagemDAO()
        {
            _context = new StreetCrashDataContext();
        }

        public string Inserir(Imagem model)
        {
            try
            {
                IMAGEM img = new IMAGEM();
                img.CODE_OCORRENCIA = model.Code_Ocorrencia;
                img.DATA_CADASTRO = DateTime.Now;
                img.DESCRICAO = model.Descricao;
                img.IMAGEM1 = new System.Data.Linq.Binary(model.Imagem_Ocorrencia);

                _context.IMAGEMs.InsertOnSubmit(img);
                _context.SubmitChanges();
                return "Imagem cadastrada com sucesso.";
            }
            catch(Exception)
            {
                throw new Exception("Erro ao inserir uma imagem. Por favor tente novamente.");
            }
        }

        public IEnumerable<Imagem> ListarImagens(long code_Ocorrencia)
        {
            try
            {
                using (var txt = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
                {
                    return _context.IMAGEMs.Where(i => i.CODE_OCORRENCIA == code_Ocorrencia).Select(n => new Imagem
                    {
                        Code = n.CODE,
                        Code_Ocorrencia = n.CODE_OCORRENCIA,
                        Imagem_Ocorrencia = n.IMAGEM1.ToArray(),
                        Data_Cadastro = n.DATA_CADASTRO,
                        Descricao = n.DESCRICAO
                    });
                }
            }
            catch(Exception)
            {
                throw new Exception("Erro a listar imagens. Por favor tente novamente.");
            }
        }
    }
}
