using ASPWebformConnect.DATA.Models;
using ASPWebformConnect.DATA.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDuRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p = new Personne
            {
                Nom = "Didier",
                Prenom = "Bernard",
                GenreId = 1,
                Email = "test@test.test"
            };

            //using(var repo = new RepoPersonne())
            //{
            //    Console.WriteLine(repo.InsertPersonne(p));
            //}

            //using (var repo = new RepoPersonne())
            //{
            //    Console.WriteLine(repo.DeletePersonne(38));
            //}

            //using (var repo = new RepoPersonne())
            //{
            //    foreach (var item in repo.GetAll())
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            using(var repo = new RepoGenre())
            {
                foreach (var item in repo.GetById(2).Personne)
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadLine();
        }
    }
}
