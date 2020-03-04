using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CardList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayAddresses();
        }
    }

    void DisplayAddresses()
    {
        //create an instance of the County Collection
        CarClasses.clsAddressCollection Addresses = new CarClasses.clsAddressCollection();
        //set the data source to the list of counties in the collection
        lstAddresses.DataSource = Addresses.AddressList;
        //set the name of the primary key
        lstAddresses.DataValueField = "AddressNo";
        //set the data field to display
        lstAddresses.DataTextField = "PostCode";
        //bind the data to the list
        lstAddresses.DataBind();
    }
}