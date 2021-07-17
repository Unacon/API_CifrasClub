using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi2_Produtos.Models
{
    public interface IMusicaRepositorio
    {
        IEnumerable<Musica> GetAll();
        Musica Get(int id);
        Musica Add(Musica item);
        void Remove(int id);
        bool Update(Musica item);
    }
}