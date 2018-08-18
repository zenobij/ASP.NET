using ExoPizza.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPizza.Data.Repository
{
    public class RepoPizzaIngredients : IDisposable
    {
        private ExoPizzaContext context;

        public RepoPizzaIngredients()
        {
            context = new ExoPizzaContext();
        }

        public bool InsertIngredientToPizza(int pizzaId, int ingredientId, int quantite)
        {
            context.PizzaIngredients.Add(new PizzaIngredients
            {
                PizzaId = pizzaId,
                IngredientId = ingredientId,
                Quantite = quantite
            });
            try
            {
                context.SaveChanges();
                return true;
            }
            catch { }
            return false;
        }

        public bool DeleteIngredientFromPizza(int pizzaId, int ingredientId)
        {
            PizzaIngredients temp = context.PizzaIngredients.FirstOrDefault(p => p.PizzaId == pizzaId && p.IngredientId == ingredientId);

            if (temp != null)
            {
                context.PizzaIngredients.Remove(temp);
                try
                {
                    context.SaveChanges();
                    return true;
                }
                catch { }
            }
            return false;
        }

        public bool DeleteAllIngredientsFromPizza(int pizzaId)
        {
            var temp = context.PizzaIngredients.Where(p => p.PizzaId == pizzaId).ToList();
            if (temp != null)
            {
                try
                {
                    context.PizzaIngredients.RemoveRange(temp);
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
