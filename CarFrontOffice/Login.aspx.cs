using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void HOME_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }

    protected void ABOUT_Click(object sender, EventArgs e)
    {
        Response.Redirect("About.aspx");
    }

    protected void CONTACT_Click(object sender, EventArgs e)
    {
        Response.Redirect("Contact.aspx");
    }

    protected void REGISTER_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }

    protected void SETTINGS_Click(object sender, EventArgs e)
    {
        Response.Redirect("Settings.aspx");
    }

    protected void LOGIN_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}