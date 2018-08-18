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
    public partial class Edit : System.Web.UI.Page
    {
        public int? PersonneId {
            get
            {
                //je déclare un id qui me servira après le tryparse
                int id;
                //Je cherche dans la barre d'adresse tous les paramètes qui m'ont été envoyé et je vérifie qu'une ce ces clé- valeurs est celle que je cherche "PersonneId"
                string s = Request.QueryString.AllKeys.FirstOrDefault(i => i.ToLower() == "personneid");
                //Si je l'ai trouvé, je regarde si je peux convertir sa valeur en entier.
                if(!string.IsNullOrWhiteSpace(s)&& int.TryParse(Request.QueryString[s], out id))
                {
                    //Si oui, je retourne cet entier
                    return id;
                }
                //Sinon je renvoie null pour éviter les ambiguités
                return null;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Si il s'agit d'un premier chargement
            if (!IsPostBack)
            {
                //Si il y a un valeur dans la variable PersonneId
                if (PersonneId != null)
                {
                    //Je peux empiler plusieurs clauses using
                    //Toutes ces variables seront effectives entre les { }
                    using (var repog = new RepoGenre())
                    using (var repo = new RepoPersonne())
                    {
                        Personne p = repo.GetById(PersonneId.Value);
                        if (p != null)
                        {
                            Session["personne"] = p;
                            txtPrenom.Text = p.Prenom;
                            txtNom.Text = p.Nom;
                            txtEmail.Text = p.Email;
                            ddlGenre.DataSource = repog.GetAll().ToList();
                            ddlGenre.DataBind();
                            ddlGenre.SelectedIndex = p.GenreId - 1;
                        }
                        else
                        {
                            Desactivation();
                        }
                    }
                }
                else
                {
                    Desactivation();
                }
            }
        }

        protected void Desactivation()
        {
            btnValider.Enabled = false;
            txtNom.Enabled = false;
            txtPrenom.Enabled = false;
            txtEmail.Enabled = false;
            ddlGenre.Enabled = false;
            lblStatut.Text = "Erreur, la personne n'existe pas !";
            lblStatut.Visible = true;
        }

        protected void btnValider_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Personne o = Session["personne"] as Personne;
                if (o != null)
                {
                    o.Nom = txtNom.Text;
                    o.Prenom = txtPrenom.Text;
                    o.Email = txtEmail.Text;
                    o.GenreId = ddlGenre.SelectedIndex + 1;

                    using (var repo = new RepoPersonne())
                    {

                        bool result = repo.UpdatePersonne(o);
                        lblStatut.Text = result == true ? "Succès" : "Erreur !!!";
                        lblStatut.Visible = true;
                    }
                }
            }
        }
    }
}