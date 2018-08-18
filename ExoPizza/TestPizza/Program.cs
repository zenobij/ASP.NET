using ExoPizza.Data.Models;
using ExoPizza.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPizza
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var repoPI = new RepoPizzaIngredients())
            //using (var repoI = new RepoIngredient())
            //using (var repoP = new RepoPizza())
            //{
            //    repoP.InsertPizza(new Pizza
            //    {
            //        Nom = "Roma",
            //        Code = "RROMA",
            //        Prix = 15
            //    });

            //    List<Ingredient> liste = new List<Ingredient>
            //    {
            //        new Ingredient{ Nom = "sel", CategorieId = 1 },
            //        new Ingredient{ Nom = "tomate", CategorieId = 4 },
            //        new Ingredient{ Nom = "parmesan", CategorieId = 2 }
            //    };

            //    foreach (var item in liste)
            //    {
            //        repoI.InsertIngredient(item);
            //    }

            //    repoPI.InsertIngredientToPizza(1, 1, 1);
            //    repoPI.InsertIngredientToPizza(1, 2, 2);
            //    repoPI.InsertIngredientToPizza(1, 3, 3);
            //}

            using (var repoP = new RepoPizza())
            {
                Pizza p = repoP.GetById(1);
                foreach (var item in p.PizzaIngredients)
                {
                    Console.WriteLine("Pizza {0} => {1} en {2} quantité", item.Pizza.Nom, item.Ingredient.Nom, item.Quantite);
                }
                Console.ReadLine();
            }
        }
    }
}
