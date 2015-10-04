using Microsoft.WindowsAzure.Mobile.Service;
using StreetCrash.Model;
using StreetCrash.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StreetCrash.Presentation.Controllers
{
    public class ApiServicesController : ApiController
    {
        public ApiServices Services { get; set; }
        Services _services;
        public ApiServicesController()
        { 
            _services = new Services();
        }
        
        [HttpGet]
        public string Registra_Ocorrencia(string categoria, string endereco, string latitude, string longitude, string outro, string status)
        {
            try
            {
                Ocorrencia acr = new Ocorrencia();
                acr.Categoria = new Categoria();
                acr.Status = new Status();

                acr.Categoria.Code = int.Parse(categoria);
                acr.Endereco = endereco;
                acr.Latitude = latitude;
                acr.Longitude = longitude;
                acr.Outro = outro;
                acr.Status.Code = int.Parse(status);
                return _services.Registra_Ocorrencia(acr);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        [HttpPost]
        public string RegistraImagens(long codeOcorrencia, string descricao, byte[] imagem)
        {
            try
            {
                Imagem img = new Imagem();
                img.Code_Ocorrencia = codeOcorrencia;
                img.Descricao = descricao;
                img.Imagem_Ocorrencia = imagem;
                return _services.RegistrarImagem(img);
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        [HttpGet]
        public Detalhe_Ocorrencia Retorna_Detalhe_Ocorrencial(long code_Ocorrencia)
        {
            return _services.Retorna_Detalhe_Ocorrencial(code_Ocorrencia);
        }

        [HttpGet]
        public bool InserirComentario(long code_Ocorrencia, string descricao)
        {
            try
            {
                Comentario cmt = new Comentario();
                cmt.Code_Ocorrencia = code_Ocorrencia;
                cmt.Descricao = descricao;
                _services.InserirComentario(cmt);

                //_services.InserirComentario(new Comentario
                //{
                //    Code_Ocorrencia = code_Ocorrencia,
                //    Descricao = descricao,
                //    Data_Cadastro = data_Cadastro
                //});
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpGet]
        public List<Comentario> Buscar_Mais_Comentarios(long code_Ocorrencia, int number_Page_Comentario)
        {
            return _services.Buscar_Mais_Comentarios(code_Ocorrencia, number_Page_Comentario);
        }

        [HttpGet]
        public List<Status> ListarStatus(string usu, string sen)
        {
            try
            {
                return _services.RetornarStatus();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        public List<Categoria> ListarCaregoria(string usuario, string senha)
        {
            try
            {
                return _services.ListarCategoria();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
