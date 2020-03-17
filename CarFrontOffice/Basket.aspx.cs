using CarClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Add_to_Cart : System.Web.UI.Page
{

    //var to store the primary key values of the record to be deleted
    Int32 OrderID;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Order to be deleted from the session object
        OrderID = Convert.ToInt32(Session["OrderID"]);

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        if (OrderID == -1)
        {
            //add the new record
            Add();
        }
        else
        {
           
        }
        //create a ner instance of clsOrder 
        clsOrderCollection AnOrder = new clsOrderCollection();
        //capture the title
        Response.Redirect("Payment_Details.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    //function for adding new records
    void Add()
    {
        //create an instance of the Order book
        CarClasses.clsOrderlineCollection OrderBook = new CarClasses.clsOrderlineCollection();
        //validate the data on the web form
        string Error = OrderBook.ThisOrderLine.Valid(txtOrderID.Text, txtProductID.Text, txtQuantity.Text);
        //if the data is Ok then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            OrderBook.ThisOrderLine.OrderID = Convert.ToInt32(txtOrderID.Text);
            //Add the record
            OrderBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("Default.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered" + Error;
        }
    }


    void DeleteOrder()
    {
        //function to delete the selected record

        //create a new instance of the Order Book
        clsOrderCollection OrderBook = new clsOrderCollection();
        //find the record to delete
        OrderBook.ThisOrder.Find(OrderID);
        //delete the record
        OrderBook.Delete();
    }



    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("Delete.aspx");
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        Response.Redirect("Payment_Details.aspx");
    }
}


    
