using ASPWebformConnect.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPWebformConnect.DATA.Repository
{
    public class RepoGenre : IDisposable
    {
        private PersonnesEntities context;

        //J'instancie le DBContext dans le constructeur de mon repository
        public RepoGenre()
        {
            context = new PersonnesEntities();
        }

        //Ensuite je vais définir les méthodes qui me seront utiles dans mon projet

        public IEnumerable<Genre> GetAll()
        {
            return context.Genre;
        }

        public Genre GetById(int id)
        {
            return context.Genre.FirstOrDefault(p => p.GenreId == id);
        }

        public void Dispose()
        {
            context = null;
        }
    }
}
