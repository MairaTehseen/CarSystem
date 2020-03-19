using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarClasses;

public partial class HomePage : System.Web.UI.Page
{
    

    protected void Page_Load(object sender, EventArgs e)
    {
        
        
    if (CarClasses.clsLoggedin.session == 0) { 
        Label1.Visible = false;
        LOGOUT.Visible = false;
        Settings.Visible = false; 
        PaymentDetails.Visible = false;
        Basket.Visible = false;
        }
    else
        {
            Label1.Visible = true;
            LOGOUT.Visible = true;
            Settings.Visible = true;
            PaymentDetails.Visible = true;
            Basket.Visible = true;
        }

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



    protected void LOGOUT_Click(object sender, EventArgs e)
    {
        CarClasses.clsLoggedin.clsLogout();
        Label1.Visible = false;
        LOGOUT.Visible = false;
        Settings.Visible = false;
        PaymentDetails.Visible = false;
        Basket.Visible = false;
    }

    protected void PaymentDetails_Click(object sender, EventArgs e)
    {
        Response.Redirect("Payment_Details.aspx");
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