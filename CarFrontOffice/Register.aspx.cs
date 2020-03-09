using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (CarClasses.clsLoggedin.session == 0)
        {
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
            if (CarClasses.clsLoggedin.staff == 1)
            {
                StaffRegisterBTN.Visible = true;
            }
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

    protected void RegisterBTN_Click(object sender, EventArgs e)
    {
        string fn = TextBoxfn.Text;
        string ln = TextBoxln.Text;
        string cr = TextBoxcr.Text;
        string ct = TextBoxct.Text;
        string st = TextBoxst.Text;
        int hn = int.Parse(TextBoxhn.Text);
        string pc = TextBoxpc.Text;
        string un = TextBoxun.Text;
        string p1 = TextBoxp1.Text;
        string ea = TextBoxea.Text;

        CarClasses.clsUsersAndStaffCollection.AddUser(fn,ln,cr,ct,st,hn,pc,un,p1,ea);
       
    }

    protected void StaffRegisterBTN_Click(object sender, EventArgs e)
    {

        string fn = TextBoxfn.Text;
        string ln = TextBoxln.Text;
        string cr = TextBoxcr.Text;
        string ct = TextBoxct.Text;
        string st = TextBoxst.Text;
        int hn = int.Parse(TextBoxhn.Text);
        string pc = TextBoxpc.Text;
        string un = TextBoxun.Text;
        string p1 = TextBoxp1.Text;
        string ea = TextBoxea.Text;

        CarClasses.clsUsersAndStaffCollection.AddStaff(fn, ln, cr, ct, st, hn, pc, un, p1, ea);
    }
}