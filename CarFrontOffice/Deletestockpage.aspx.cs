using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarClasses;

public partial class Deletestockpage : System.Web.UI.Page
{
    int StockNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        StockNo = Convert.ToInt32(Session["StockNo"]);
    }

    int DeleteStock()
    {
        clsStockCollection CarSystem = new clsStockCollection();
        CarSystem.ThisStock.Find(StockNo);
        CarSystem.Delete();
        return 1;
    }

    protected void txtDelete_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnyes_Click(object sender, EventArgs e)
    {
        DeleteStock();
        {
            lblError.Text = "Deleted successfully";
        }

        {
            Response.Redirect("StockDefault.aspx");
        }

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}