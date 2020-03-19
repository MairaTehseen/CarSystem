using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MemberHome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnUpdateDetails_Click(object sender, EventArgs e)
    {
        Response.Redirect("UpdateCustomer.aspx");
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Response.Redirect("Homepage.aspx");
    }

    protected void btnDeleteDetails_Click(object sender, EventArgs e)
    {
        Response.Redirect("DeleteCustomer.aspx");
    }

    
}