using ExoPizza.Data.Models;
using ExoPizza.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExoPizza.Web.Pages
{
    public partial class AddIngredient : System.Web.UI.Page
    {
        public int? PizzaId {
            get
            {
                int pizzaId;
                string pizzaKey = Request.QueryString.AllKeys.FirstOrDefault(q => q.ToLower() == "pizzaid");
                if(!string.IsNullOrWhiteSpace(pizzaKey) && int.TryParse(Request.QueryString[pizzaKey], out pizzaId))
                {
                    return pizzaId;
                }
                return null;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (PizzaId.HasValue)
                {
                    using (var repoP = new RepoPizza())
                    using (var repoI = new RepoIngredient())
                    {
                        var I = repoI.GetAll();
                        var PI = repoP.GetById(PizzaId.Value).PizzaIngredients.Select(p => p.Ingredient);

                        lstIngredients.DataSource = I.Except(PI, new IngredientComparer());
                        lstIngredients.DataBind();
                    }
                }
            }
        }
    }
}