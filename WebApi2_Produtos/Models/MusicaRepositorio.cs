using System;
using System.Collections.Generic;
namespace WebApi2_Produtos.Models
{
    public class MusicaRepositorio : IMusicaRepositorio
    {
        private List<Musica> musica = new List<Musica>();
        private int _nextId = 1;

        public MusicaRepositorio()
        {
            Add(new Musica { Nome = "Medo de Amar", Ano = 2020, Compositor = "Claus/Vanessa", Banda = "Forró do Muído"});
            Add(new Musica { Nome = "As The World Caves In", Ano = 2018, Compositor = "Matt Maltese", Banda = "Matt Maltese" });
            Add(new Musica { Nome = "Batom de Cereja", Ano = 2021, Compositor = "Lucas Papada/Kito/Elcio De Carvalho/Léo Soares", Banda = "Israel e Rodolffo" });
            Add(new Musica { Nome = "Talking To The Moon", Ano = 2010, Compositor = "Philip Lawrence/Jeff Bhasker/Bruno Mars/Ari Levine/Albert Winkler", Banda = "Bruno Mars" });
            Add(new Musica { Nome = "Meu Mel", Ano = 2020, Compositor = "Sam Choueka / Paulinho Rezende / Norival De Paula / Lipton Terry", Banda = "Zé Vaqueiro" });
            Add(new Musica { Nome = "Volta Comigo BB", Ano = 2020, Compositor = "DJ Ivis", Banda = "Zé Vaqueiro" });
            }

        public Musica Add(Musica item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            musica.Add(item);
            return item;
        }

        public Musica Get(int id)
        {
            return musica.Find(p => p.Id == id);
        }

        public IEnumerable<Musica> GetAll()
        {
            return musica;
        }

        public void Remove(int id)
        {
            musica.RemoveAll(p => p.Id == id);
        }

        public bool Update(Musica item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            int index = musica.FindIndex(p => p.Id == item.Id);

            if (index == -1)
            {
                return false;
            }
            musica.RemoveAt(index);
            musica.Add(item);
            return true;
        }
    }
}