using CarClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegisterSuccessful : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //get the data from the session object
        ACustomer = (clsCustomer)Session["ACustomer"];
        //display the customer first name for this entry
        Response.Write(ACustomer.CustomerFirstName);
    }



    protected void btnHomePage_Click(object sender, EventArgs e)
    {
        Response.Redirect("MemberHome.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Homepage.aspx");
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {

    }
}