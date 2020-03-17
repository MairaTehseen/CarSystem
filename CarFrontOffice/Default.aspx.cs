using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("View Detail.aspx");
    }

    protected void btnViewDetail_Click(object sender, EventArgs e)
    {
        Response.Redirect("View Detail.aspx");
    }

    protected void btnDetail_Click(object sender, EventArgs e)
    {
        Response.Redirect("View Detail.aspx");
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("View Detail.aspx");
    }

    protected void btnAddtoCart_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicates this is a new record
        Session["OrderID"] = -1;
        //rdeirect to the data entry page
        Response.Redirect("Basket.aspx");
    }




    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Add to Cart.aspx");
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("Add to Cart.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Add to Cart.aspx");
    }






    protected void btnViewDetail0_Click(object sender, EventArgs e)
    {
        Response.Redirect("View_Detail.aspx");
    }
}
