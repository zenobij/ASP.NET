using ExoPizza.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPizza.Data.Repository
{
    public class RepoPizza : IDisposable
    {
        private ExoPizzaContext context;

        public RepoPizza()
        {
            context = new ExoPizzaContext();
        }

        public IEnumerable<Pizza> GetAll()
        {
            return context.Pizza;
        }

        public Pizza GetById(int id)
        {
            return context.Pizza.FirstOrDefault(p => p.PizzaId == id);
        }

        public bool InsertPizza(Pizza p)
        {
            try
            {
                context.Pizza.Add(p);
                context.SaveChanges();
                return true;
            }
            catch { }
            return false;
        }

        public bool UpdatePizza(Pizza p)
        {
            Pizza temp = GetById(p.PizzaId);
            if (temp != null)
            {
                temp.Nom = p.Nom;
                temp.Code = p.Code;
                temp.Prix = p.Prix;
                try
                {
                    context.SaveChanges();
                    return true;
                }
                catch { }
            }
            return false;
        }

        public bool DeletePizza(int id)
        {
            Pizza temp = GetById(id);
            if (temp != null)
            {
                context.Pizza.Remove(temp);
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
