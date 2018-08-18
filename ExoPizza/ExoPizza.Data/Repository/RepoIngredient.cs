using ExoPizza.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPizza.Data.Repository
{
    public class RepoIngredient : IDisposable
    {
        private ExoPizzaContext context;

        public RepoIngredient()
        {
            context = new ExoPizzaContext();
        }

        public IEnumerable<Ingredient> GetAll()
        {
            return context.Ingredient;
        }

        public Ingredient GetById(int id)
        {
            return context.Ingredient.FirstOrDefault(p => p.IngredientId == id);
        }

        public bool InsertIngredient(Ingredient p)
        {
            try
            {
                context.Ingredient.Add(p);
                context.SaveChanges();
                return true;
            }
            catch { }
            return false;
        }

        public bool UpdateIngredient(Ingredient p)
        {
            Ingredient temp = GetById(p.IngredientId);
            if (temp != null)
            {
                temp.Nom = p.Nom;
                temp.CategorieId = p.CategorieId;
                try
                {
                    context.SaveChanges();
                    return true;
                }
                catch { }
            }
            return false;
        }

        public bool DeleteIngredient(int id)
        {
            Ingredient temp = GetById(id);
            if (temp != null)
            {
                context.Ingredient.Remove(temp);
                try
                {
                    context.SaveChanges();
                    return true;
                }
                catch { }
            }
            return false;
        }

        public void Dispose()
        {
            context = null;
        }
    }
}
