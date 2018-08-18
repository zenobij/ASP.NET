using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPizza.Data.Models
{
    public partial class Pizza
    {
        public string ListeIngredients {
            get
            {
                List<string> noms = PizzaIngredients.Select(p => p.Ingredient.Nom).ToList();

                return noms.Count != 0 ? string.Join(", ", noms) : "---";
            }
        }
    }
}
