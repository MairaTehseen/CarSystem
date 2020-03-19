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
            Add();

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

    

    void Update()
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
            Response.Redirect("StockDefault.aspx");
        }
        else
        {
            lblError.Text = "There was problems with the data entered" + Error;
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
        Response.Redirect("StockDefault.aspx");
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {


        lblError.Text = "Update was successful";
        Response.Redirect("StockDefault.aspx");
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Add();
        if (Add()== 1)
        {
            Response.Redirect("AddSuccessful.aspx");
        } else if (Add()==0)
        {
           
        }
    }
    int Add()
    {
        clsStockCollection CarSystem = new clsStockCollection();
        string Error = CarSystem.ThisStock.Valid(txtManufacturer.Text, Convert.ToInt32(txtQuantity.Text), txtColour.Text, txtModel.Text, Convert.ToInt32(txtPrice.Text), Convert.ToDateTime(txtStockYear.Text));
        if (Error == "")
        {
            CarSystem.ThisStock.Manufacturer = txtManufacturer.Text;
            CarSystem.ThisStock.Quantity = Convert.ToInt32(txtQuantity.Text);
            CarSystem.ThisStock.Colour = txtColour.Text;
            CarSystem.ThisStock.Model = txtModel.Text;
            CarSystem.ThisStock.Price = Convert.ToInt32(txtPrice.Text);
            CarSystem.ThisStock.StockYear = Convert.ToDateTime(txtStockYear.Text);
            CarSystem.Add();
            
            return 1;
        }
        else
            lblError.Text = Error;
        return 0;
    }

}
    
