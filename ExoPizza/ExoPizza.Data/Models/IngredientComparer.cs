using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPizza.Data.Models
{
    public class IngredientComparer : IEqualityComparer<Ingredient>
    {
        public bool Equals(Ingredient x, Ingredient y)
        {
            if (int.Equals(x.IngredientId, y.IngredientId))
            {
                return true;
            }
            return false;
        }

        public int GetHashCode(Ingredient obj)
        {
            return obj.IngredientId.GetHashCode();
        }
    }
}
