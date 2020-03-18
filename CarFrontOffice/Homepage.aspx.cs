using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarClasses;

public partial class Homepage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("Homepage.aspx");
    }

    protected void btnAbout_Click(object sender, EventArgs e)
    {
        Response.Redirect("About.aspx");
    }

    protected void btnContact_Click(object sender, EventArgs e)
    {
        Response.Redirect("Contact.aspx");
    }

    protected void btnStaffLogin_Click(object sender, EventArgs e)
    {

    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();

        Session["ACustomer"] = ACustomer;
        //redirect to the register page
        Response.Redirect("RegisterCustomer.aspx");
    }

    protected void btnCustomerLogin_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerLogin.aspx");
    }

    protected void btnBlank_Click(object sender, EventArgs e)
    {

    }
}