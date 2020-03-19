using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarClasses;

public partial class UpdateCustomer : System.Web.UI.Page
{
    //variable to store the pimrary key with page level scope
    Int32 CustomerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            //populate the list of customer
            DisplayCustomer();
            //if this is not a new record
            if (CustomerID != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }
    }
        
    
    

    void Update()
    {
        //create an instnce of the customer book 
        CarClasses.clsCustomerCollection CustomerBook = new CarClasses.clsCustomerCollection();
        //validate the data on the web form
        String Error = CustomerBook.ThisCustomer.Valid(txtbxFirstName.Text, txtbxLastName.Text, txtbxEmail.Text, txtbxTeleNo.Text, txtbxAddress1.Text, txtbxAddress2.Text, txtbxPostcode.Text, txtbxPassword.Text);
        //if the data is OK then add it to the object
        if (Error =="")
        {
            //find the record to update
            CustomerBook.ThisCustomer.Find(2);
            //get the data entered by the user
            CustomerBook.ThisCustomer.CustomerFirstName = txtbxFirstName.Text;
            CustomerBook.ThisCustomer.CustomerLastName = txtbxEmail.Text;
            CustomerBook.ThisCustomer.Email = txtbxEmail.Text;
            CustomerBook.ThisCustomer.TelephoneNo = txtbxTeleNo.Text;
            CustomerBook.ThisCustomer.Address1 = txtbxAddress1.Text;
            CustomerBook.ThisCustomer.Address2 = txtbxAddress2.Text;
            CustomerBook.ThisCustomer.Address1 = txtbxAddress1.Text;
            CustomerBook.ThisCustomer.PostCode = txtbxPostcode.Text;
            CustomerBook.ThisCustomer.CustomerPassword = txtbxPassword.Text;
            //update the record
            CustomerBook.Update();
            //redirect back to the main page
            Response.Redirect("MemberHome.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered" + Error;
        }
    }

    void DisplayCustomer()
    {
        //create an instance of the customer book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to update
        CustomerBook.ThisCustomer.Find(CustomerID);
        //display the data for this record
        txtbxFirstName.Text = CustomerBook.ThisCustomer.CustomerFirstName;
        txtbxLastName.Text = CustomerBook.ThisCustomer.CustomerLastName;
        txtbxEmail.Text = CustomerBook.ThisCustomer.Email;
        txtbxTeleNo.Text = CustomerBook.ThisCustomer.TelephoneNo.ToString();
        txtbxAddress1.Text = CustomerBook.ThisCustomer.Address1;
        txtbxAddress2.Text = CustomerBook.ThisCustomer.Address2;
        txtbxPostcode.Text = CustomerBook.ThisCustomer.PostCode;
        txtbxPassword.Text = CustomerBook.ThisCustomer.CustomerPassword;
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        if (CustomerID == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
        }
    }

    //function for adding new records
    void Add()
    {
        //create an instance of the customer book
        CarClasses.clsCustomerCollection CustomerBook = new CarClasses.clsCustomerCollection();
        //validate the data on the web form
        String Error = CustomerBook.ThisCustomer.Valid(txtbxFirstName.Text, txtbxLastName.Text, txtbxEmail.Text, txtbxTeleNo.Text, txtbxAddress1.Text, txtbxAddress2.Text, txtbxPostcode.Text, txtbxPassword.Text);
        //if the data is Ok then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            CustomerBook.ThisCustomer.CustomerFirstName = txtbxFirstName.Text;
            CustomerBook.ThisCustomer.CustomerLastName = txtbxLastName.Text;
            CustomerBook.ThisCustomer.Email = txtbxEmail.Text;
            CustomerBook.ThisCustomer.TelephoneNo = txtbxTeleNo.Text;
            CustomerBook.ThisCustomer.Address1 = txtbxAddress1.Text;
            CustomerBook.ThisCustomer.Address2 = txtbxAddress2.Text;
            CustomerBook.ThisCustomer.PostCode = txtbxPostcode.Text;
            CustomerBook.ThisCustomer.CustomerPassword = txtbxPassword.Text;
            //add the record
            CustomerBook.Add();
            //all done so redirect to the main page
            Response.Redirect("MemberHome.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }



    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("MemberHome.aspx");
    }

    protected void txtbxEmail_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtbxFirstName_TextChanged(object sender, EventArgs e)
    {

    }
}