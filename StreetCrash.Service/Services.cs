using StreetCrash.DAO;
using StreetCrash.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetCrash.Service
{
    public class Services
    {
        OcorrenciaDAO _repOcorrencia;
        ComentarioDAO _repComentario;
        ImagemDAO _repImagem;
        StatusDAO _repStatus;
        CategoriaDAO _repCategoria;

        public Services()
        {
            _repOcorrencia = new OcorrenciaDAO();
            _repComentario = new ComentarioDAO();
            _repImagem = new ImagemDAO();
            _repStatus = new StatusDAO();
            _repCategoria = new CategoriaDAO();
        }

        public Detalhe_Ocorrencia Retorna_Detalhe_Ocorrencial(long code_Ocorrencia)
        {
            try
            {
                Ocorrencia _ocorrencia = _repOcorrencia.RetornaOcorrencia(code_Ocorrencia);
                List<Comentario> _comentario = _repComentario.ConsultaComentario(code_Ocorrencia, 1).ToList();
                List<Imagem> _imagem = _repImagem.ListarImagens(code_Ocorrencia).ToList();

                Detalhe_Ocorrencia det = new Detalhe_Ocorrencia();

                det.Code = _ocorrencia.Code;
                det.Categoria = _ocorrencia.Categoria;
                det.Status = _ocorrencia.Status;
                det.Comentarios = _comentario;
                det.Data_Cadastro = _ocorrencia.Data_Cadastro;
                det.Endereco = _ocorrencia.Endereco;
                det.Imagens = _imagem;
                det.Latitude = _ocorrencia.Latitude;
                det.Longitude = _ocorrencia.Longitude;
                det.Outro = _ocorrencia.Outro;
                det.Resolvido = _ocorrencia.Resolvido;

                return det;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string Registra_Ocorrencia(Ocorrencia ocorrencia)
        {
            try
            {
                var retorno = _repOcorrencia.Inserir(ocorrencia);                
                return retorno;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string RegistrarImagem(Imagem imagem)
        {
            try
            {
                return _repImagem.Inserir(imagem);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string InserirComentario(Comentario comentario)
        {
            try
            {
                return _repComentario.Inserir(comentario);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Comentario> Buscar_Mais_Comentarios(long code_Ocorrencia, int number_Page_Comentario)
        {
            try
            {
                return _repComentario.ConsultaComentario(code_Ocorrencia, number_Page_Comentario).ToList();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Categoria> ListarCategoria()
        {
            try
            {
                return _repCategoria.Retorna_Categoria();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Status> RetornarStatus()
        {
            try
            {
                return _repStatus.Retorna_Status();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
