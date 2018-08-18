using ExoPizza.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExoPizza.Web.Pages
{
    public partial class GrillePizza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var repoP = new RepoPizza())
            {
                grvPizza.DataSource = repoP.GetAll().ToList();
                grvPizza.DataBind();
            }
        }
    }
}