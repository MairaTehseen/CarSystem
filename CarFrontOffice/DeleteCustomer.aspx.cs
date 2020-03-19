using System;
using CarClasses;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteCustomer : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 CustomerID;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customers to be deleted from the session object
        CustomerID = Convert.ToInt32(Session["CustomerID"]);

    }

    //function for deleting existing records
    void DeleteCustomers()
    {
        //function to delete the selected record

        //create a new instance of the customer book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to delete
        CustomerBook.ThisCustomer.Find(CustomerID);
        //delete the record
        CustomerBook.Delete();
    }

    protected void btnYesDeleteCustomer_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteCustomers();
        //redirect back to the member home
        Response.Redirect("MemberHome.aspx");
    }

    protected void btnNoDeleteCustomer_Click(object sender, EventArgs e)
    {
        Response.Redirect("MemberHome.aspx");
    }
}