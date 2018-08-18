using ASPWebformConnect.DATA.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebformConnect.Pages
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (var repo = new RepoPersonne())
                {
                    ModelRepeater.DataSource = repo.GetAll().ToArray();
                    ModelRepeater.DataBind();
                }
            }
        }
    }
}