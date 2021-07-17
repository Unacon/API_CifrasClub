using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi2_Produtos.Models;
namespace WebApi2_Produtos.Controllers
{
    public class MusicasController : ApiController
    {
        static readonly IMusicaRepositorio repositorio = new MusicaRepositorio();
        public IEnumerable<Musica> GetAllMusica()
        {
            return repositorio.GetAll();
        }
        public Musica GetProduto(int id)
        {
            Musica item = repositorio.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return item;
        }
        public IEnumerable<Musica> GetMusicaPorNome(string nome)
        {
            return repositorio.GetAll().Where(
                p => string.Equals(p.Nome, nome, StringComparison.OrdinalIgnoreCase));
        }
        public IEnumerable<Musica> GetMusicaPorAno(int ano)
        {
            return repositorio.GetAll().Where(
                p => string.Equals(p.Ano, ano));
        }

        public IEnumerable<Musica> GetMusicaPorBanda(string banda)
        {
            return repositorio.GetAll().Where(
                p => string.Equals(p.Banda, banda, StringComparison.OrdinalIgnoreCase));
        }
        public IEnumerable<Musica> GetMusicaPorCompositor(string compositor)
        {
            return repositorio.GetAll().Where(
                p => string.Equals(p.Compositor, compositor, StringComparison.OrdinalIgnoreCase));
        }
        public HttpResponseMessage PostMusica(Musica item)
        {
            item = repositorio.Add(item);
            var response = Request.CreateResponse<Musica>(HttpStatusCode.Created, item);
            string uri = Url.Link("DefaultApi", new { id = item.Id });
            response.Headers.Location = new Uri(uri);
            return response;
        }
        public void PutMusica(int id, Musica produto)
        {
            produto.Id = id;
            if (!repositorio.Update(produto))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }
        public void DeleteMusica(int id)
        {
            Musica item = repositorio.Get(id);
            if (item == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            repositorio.Remove(id);
        }
    }
}