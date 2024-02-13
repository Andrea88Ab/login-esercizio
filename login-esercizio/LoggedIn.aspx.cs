using System;
using System.Web;

namespace login_esercizio
{
    public partial class LoggedIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie userCookie = Request.Cookies["UserInfo"];
                if (userCookie != null)
                {
                    lblUsername.Text = userCookie["Username"];
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            HttpCookie userCookie = new HttpCookie("UserInfo")
            {
                Expires = DateTime.Now.AddDays(-1) // Imposta la data di scadenza nel passato per cancellarlo
            };
            Response.Cookies.Add(userCookie);

            Response.Redirect("Login.aspx");
        }
    }
}
