using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarClasses;

public partial class CustomerSearch : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 CustomerID;

    //this function handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }
    }
    
        void DisplayCustomers()
        {
            //create an instance of the customer collection
            CarClasses.clsCustomerCollection Customers = new CarClasses.clsCustomerCollection();
            //set the data source to the list of customers in the collection
            lstbxCustomers.DataSource = Customers.CustomerList;
            //set the name of the primary key
            lstbxCustomers.DataValueField = "CustomerID";
            //set the data field to display
            lstbxCustomers.DataTextField = "CustomerLastName";
            //bind the data to the list
            lstbxCustomers.DataBind();
        }
    
    

    protected void btnSearchCustomer_Click(object sender, EventArgs e)
    {

    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {

    }

    protected void btnAddCustomer_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerID"] = -1;
        //redirect to the data entry page
        Response.Redirect("RegisterCustomer.aspx");

    }

    protected void btnUpdateCustomer_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be updated
        Int32 CustomerID;
        //if the record has been selected from the list
        if (lstbxCustomers.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            CustomerID = Convert.ToInt32(lstbxCustomers.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the edit page
            Response.Redirect("UpdateCustomer.aspx");
        }
        else //if no record has been selected
        {
            //display an error 
            lblError.Text = "Please select a record to update from the list";
        }
    }

    protected void btnDeleteCustomer_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstbxCustomers.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            CustomerID = Convert.ToInt32(lstbxCustomers.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the delete page
            Response.Redirect("DeleteCustomer.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }

    }
}