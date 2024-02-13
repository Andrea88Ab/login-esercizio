using System;
using System.Web;

namespace login_esercizio
{
    public partial class Login : System.Web.UI.Page
    {
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            HttpCookie userCookie = new HttpCookie("UserInfo");
            userCookie["Username"] = txtUsername.Text;
            userCookie.Expires = DateTime.Now.AddHours(1); // Il cookie scade dopo 1 ora
            Response.Cookies.Add(userCookie);

            Response.Redirect("LoggedIn.aspx");
        }
    }
}
