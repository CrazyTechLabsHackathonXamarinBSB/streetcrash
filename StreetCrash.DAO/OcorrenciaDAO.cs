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
    public class OcorrenciaDAO
    {
        StreetCrashDataContext _context;
        public OcorrenciaDAO()
        {
            _context = new StreetCrashDataContext();
        }
        public string Inserir(Ocorrencia model)
        {
            try
            {
                OCORRENCIA ocr = new OCORRENCIA();
                ocr.CODE_CATEGORIA = model.Categoria.Code;
                ocr.CODE_STATUS = model.Status.Code;
                ocr.LATITUDE = model.Latitude;
                ocr.LONGITUDE = model.Longitude;
                ocr.ENDERECO = model.Endereco;
                ocr.DATA_CADASTRO = DateTime.Now;
                ocr.OUTRO = model.Outro;
                ocr.RESOLVIDO = false;
                _context.OCORRENCIAs.InsertOnSubmit(ocr);
                _context.SubmitChanges();
                return ("Ocorrência " + ocr.CODE + "adicionada com sucesso.");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir ocorrência. Por favor tente novamente.");
            }
        }

        public string UpdateStatus(UpdateStatus model)
        {
            try
            {
                using (var txt = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
                {
                    OCORRENCIA ocorrencia = _context.OCORRENCIAs.Where(o => o.CODE == model.Code).SingleOrDefault();
                    ocorrencia.RESOLVIDO = model.Resolvido;
                    _context.SubmitChanges();
                    return ("Prioridade da ocorrência " + ocorrencia.CODE + "foi alterada com sucesso.");
                }
            }
            catch (Exception)
            {
                throw new Exception("Não foi possível alterar prioridade da ocorrência. Por favor tente novamente.");
            }
        }

        public Ocorrencia RetornaOcorrencia(long code_Ocorrencia)
        {
            try
            {
                using (var txt = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
                {
                    return _context.OCORRENCIAs.Where(o => o.CODE == code_Ocorrencia).Select(n => new Ocorrencia
                    {
                        Code = n.CODE,
                        Categoria = _context.CATEGORIAs.Where(l => l.CODE == n.CODE_CATEGORIA).Select(p => new Categoria
                        {
                            Code = p.CODE,
                            Descricao = p.DESCRICAO
                        }).FirstOrDefault(),
                        Status = _context.STATUS.Where(l => l.CODE == n.CODE_STATUS).Select(p => new Status
                        {
                            Code = p.CODE,
                            Descricao = p.DESCRICAO
                        }).FirstOrDefault(),
                        Latitude = n.LATITUDE,
                        Longitude = n.LONGITUDE,
                        Endereco = n.ENDERECO,
                        Data_Cadastro = n.DATA_CADASTRO,
                        Outro = n.OUTRO,
                        Resolvido = n.RESOLVIDO
                    }).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw new Exception("Não foi possível retornar a ocorrência " + code_Ocorrencia + ". Por favor tente novamente.");
            }
        }

        public IEnumerable<Ocorrencia> ListarOcorrencia(Raio model)
        {
            try
            {
                using (var txt = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions { IsolationLevel = IsolationLevel.ReadUncommitted }))
                {
                    return _context.OCORRENCIAs.Where(o => o.LATITUDE == model.Latitude && o.LONGITUDE == model.Longitude).Select(n => new Ocorrencia
                    {
                        Code = n.CODE,
                        Categoria = _context.CATEGORIAs.Where(l => l.CODE == n.CODE_CATEGORIA).Select(p => new Categoria
                        {
                            Code = p.CODE,
                            Descricao = p.DESCRICAO
                        }).FirstOrDefault(),
                        Status = _context.STATUS.Where(l => l.CODE == n.CODE_STATUS).Select(p => new Status
                        {
                            Code = p.CODE,
                            Descricao = p.DESCRICAO
                        }).FirstOrDefault(),
                        Latitude = n.LATITUDE,
                        Longitude = n.LONGITUDE,
                        Endereco = n.ENDERECO,
                        Data_Cadastro = n.DATA_CADASTRO,
                        Outro = n.OUTRO,
                        Resolvido = n.RESOLVIDO
                    });
                }
            }
            catch (Exception)
            {
                throw new Exception("Não foi possível listar as ocorrências. Por favor tente novamente.");
            }
        }
    }
}
