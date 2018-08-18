using ASPWebformConnect.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPWebformConnect.DATA.Repository
{
    public class RepoPersonne : IDisposable
    {
        //Le contexte est privé car jene veux pas que le programme principal le voie
        private PersonnesEntities context;

        //J'instancie le DBContext dans le constructeur de mon repository
        public RepoPersonne()
        {
            context = new PersonnesEntities();
        }

        //Ensuite je vais définir les méthodes qui me seront utiles dans mon projet

        public IEnumerable<Personne> GetAll()
        {
            return context.Personne;
        }

        public Personne GetById(int id)
        {
            return context.Personne.FirstOrDefault(p => p.PersonneId == id);
        }

        public bool InsertPersonne(Personne p)
        {
            try
            {
                context.Personne.Add(p);
                context.SaveChanges();
                return true;
            }
            catch { }
            return false;
        }

        //Pour un update on a déjà l'id de la personne
        public bool UpdatePersonne(Personne p)
        {
            Personne aModifier = context.Personne.FirstOrDefault(pe => pe.PersonneId == pe.PersonneId);

            if (aModifier != null)
            {
                aModifier.Nom = p.Nom;
                aModifier.Prenom = p.Prenom;
                aModifier.GenreId = p.GenreId;
                aModifier.Email = p.Email;
                try
                {
                    context.SaveChanges();
                    return true;
                }
                catch { }
            }
            return false;
        }

        public bool DeletePersonne(int id)
        {
            try
            {
                context.Personne.Remove(GetById(id));
                context.SaveChanges();
                return true;
            }
            catch { }
            return false;
        }

        public void Dispose()
        {
            //Je déréférence mon objet PersonneEntities
            context = null;
        }
    }
}
