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
        if (IsPostBack == false)
        {

            DisplayStock();

        }
    }
    void DisplayStock()
    {


        CarClasses.clsStockCollection Stock = new CarClasses.clsStockCollection();
        LstStock.DataSource = Stock.StockList;
        LstStock.DataValueField = "StockNo";
        LstStock.DataTextField = "Manufacturer";

        LstStock.DataBind();
    }
    

    protected void btnadd_Click(object sender, EventArgs e)
    {
        Session["StockNo"] = -1;
        Response.Redirect("AStock.aspx");
    }

    protected void btnedit_Click(object sender, EventArgs e)
    {
        Int32 StockNo;
        if (LstStock.SelectedIndex != -1)
        {
            StockNo = Convert.ToInt32(LstStock.SelectedValue);
            Session["StockNo"] = StockNo;
            Response.Redirect("UStock.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btndelete_Click(object sender, EventArgs e)
    {
        
        if (LstStock.SelectedIndex != -1)
        {
            int StockNo;
            StockNo = Convert.ToInt32(LstStock.SelectedValue);
            Session["StockNo"] = StockNo;
            Response.Redirect("Deletestockpage.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void LstStock_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }

    protected void txtsearch_TextChanged(object sender, EventArgs e)
    {

        
        LstStock.Items.FindByText("Audi");
    }

  
}
     

    
