using CarClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class AStock : System.Web.UI.Page
{
    Int32 StockNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        StockNo = Convert.ToInt32(Session["StockNo"]);
        if (IsPostBack == false)
        {
            DisplayStock();
            if (StockNo != -1)
            {
                DisplayStock();
            }
        }
    }


    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        if (StockNo == -1)
        {
            

        }
        else
        {
            Update();
        } 
        //else
        //{
           // lblError.Text = "Update was successful";
       // }
    }

    

    string Update()
    {
        CarClasses.clsStockCollection CarSystem = new CarClasses.clsStockCollection();
        String Error = CarSystem.ThisStock.Valid(txtManufacturer.Text, Convert.ToInt32(txtQuantity.Text), txtColour.Text, txtModel.Text, Convert.ToInt32(txtPrice.Text), Convert.ToDateTime(txtStockYear.Text));
        if (Error == "")
        {

            CarSystem.ThisStock.Find(StockNo);
            CarSystem.ThisStock.Manufacturer = txtManufacturer.Text;
            CarSystem.ThisStock.Quantity = Convert.ToInt32(txtQuantity.Text);
            CarSystem.ThisStock.Colour = txtColour.Text;
            CarSystem.ThisStock.Model = txtModel.Text;
            CarSystem.ThisStock.Price = Convert.ToInt32(txtPrice.Text);
            CarSystem.ThisStock.StockYear = Convert.ToDateTime(txtStockYear.Text);
            CarSystem.Update();
            Response.Redirect("Default.aspx");
            return Error;
        }
        else
        {
            lblError.Text = "There was problems with the data entered" + Error;
            return Error;
        }
    }

    void DisplayStock()
    {
        clsStockCollection CarSystem = new clsStockCollection();
        CarSystem.ThisStock.Find(StockNo);
        txtManufacturer.Text = CarSystem.ThisStock.Manufacturer;
        txtQuantity.Text =CarSystem.ThisStock.Quantity.ToString();
        txtColour.Text = CarSystem.ThisStock.Colour;
        txtModel.Text = CarSystem.ThisStock.Model;
        txtPrice.Text = CarSystem.ThisStock.Price.ToString();
        txtStockYear.Text = CarSystem.ThisStock.StockYear.ToString();
            

    }


    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        Update();
        if (Update()=="")
        { 
        lblError.Text = "Update was successful";
        Response.Redirect("Default.aspx");
        }else if (Update() != "")
        {
            lblError.Text = Update(); 
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       
        Response.Redirect("AddSuccessful.aspx");
    }
}
    
