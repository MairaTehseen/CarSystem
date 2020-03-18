using CarClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegisterCustomer : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Homepage.aspx");
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        //create an instance of the class library 
        //clsCustomer ACustomer = new clsCustomer();
        //capture the customer first name
        //ACustomer.CustomerFirstName = txtbxFirstName.Text;
        //Session["ACustomer"] = ACustomer;
        //capture the customer last name
        //ACustomer.CustomerLastName = txtbxLastName.Text;
        //Session["ACustomer"] = ACustomer;
        //capture the email
        //ACustomer.Email = txtbxEmail.Text;
        //capture the telephone number
        //ACustomer.TelephoneNo = txtbxTeleNo.Text;
        //store the first name in the session object
        //Session["ACustomer"] = ACustomer;
        //redirect to register successful page
        //Response.Redirect("RegisterSuccessful.aspx");

        //add the new record
        Add();
        //add done so redirect back to the member home page
        Response.Redirect("MemberHome.aspx");
    }

    protected void txtbxEmail_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtbxFirstName_TextChanged(object sender, EventArgs e)
    {

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

 



   
}