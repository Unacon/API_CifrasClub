using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi2_Produtos.Models
{
    public class Musica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Compositor { get; set; }
        public string Banda { get; set; }
        public int Ano { get; set; }
    }
}