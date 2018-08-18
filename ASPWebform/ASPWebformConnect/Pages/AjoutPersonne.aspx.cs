using ASPWebformConnect.DATA.Models;
using ASPWebformConnect.DATA.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPWebformConnect.Pages
{
    public partial class AjoutPersonne : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (var repo = new RepoGenre())
                {
                    DropDownList1.DataSource = repo.GetAll().ToList();
                    DropDownList1.DataBind();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                using (var repo = new RepoPersonne())
                {
                    bool result = repo.InsertPersonne(
                        new Personne {
                            Nom = TextBox1.Text,
                            Prenom = TextBox2.Text,
                            Email = TextBox4.Text,
                            GenreId = DropDownList1.SelectedIndex + 1
                        }
                    );

                    Label4.Text = result == true ? "Personne enregistrée" : "Erreur !";
                    Label4.Visible = true;
                }
            }
        }
    }
}