using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarClasses;

public partial class PayMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {

            DisplayCards();
            DisplayAccounts();
            DisplayCustomerName();
        }



    }

    void DisplayCustomerName()
    {
        clsDataConnection DB = new clsDataConnection();
        clsLoggedin.session = 2;
        DB.AddParameter("@Session", clsLoggedin.session);
 int foun = DB.Execute("PaymentFindCustomerName");
        if (foun == 1)
        { 
            username.Text = Convert.ToString(DB.DataTable.Rows[0]["CustomerFirstName"]);
        }
        else 
        {
            username.Text = "Login to show name";
        }
        
        
    }

    void DisplayCards()
    {

    //create an instance of the County Collection
            CarClasses.clsCardsCollection Card = new CarClasses.clsCardsCollection();
    //set the data source to the list of counties in the collection
    lstCards.DataSource = Card.CardsList;
            //set the name of the primary key
            lstCards.DataValueField = "CardNr";
            //set the data field to display
            lstCards.DataTextField = "CardNr";
            //bind the data to the list
            lstCards.DataBind();
    }
    void DisplayAccounts()
    {

        //create an instance of the County Collection
        CarClasses.clsAccountsCollection Account = new CarClasses.clsAccountsCollection();
        //set the data source to the list of counties in the collection
        ListAccounts.DataSource = Account.AccountsList;
        //set the name of the primary key
        ListAccounts.DataValueField = "AccountNr";
        //set the data field to display
        ListAccounts.DataTextField = "AccountNr";
        //bind the data to the list
        ListAccounts.DataBind();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["CardNo"] = -1;
        Response.Redirect("Payment_Card.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Double CardNr;

        if (lstCards.SelectedIndex != -1)
        {
            CardNr = Convert.ToDouble(lstCards.SelectedValue);
            Session["CardNo"] = CardNr;
            Response.Redirect("Delete.aspx");
            //lbl2Error.Text = CardNr.ToString();
        }
        else
        {

            lbl2Error.Text = "Please select a record to delete from the list";
        }
    }

    protected void Button4_Click1(object sender, EventArgs e)
    {
        Session["AccountNo"] = -1;
        Response.Redirect("Payment_Account.aspx");
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        int AccountNr;

        if (ListAccounts.SelectedIndex != -1)
        {
            AccountNr = Convert.ToInt32(ListAccounts.SelectedValue);
            Session["AccountNo"] = AccountNr;
            Response.Redirect("DeleteAccount.aspx");
            //lbl2Error.Text = CardNr.ToString();
        }
        else
        {

            lbl2Error.Text = "Please select a record to delete from the list";
        }
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
       if (PaymentMethod.SelectedIndex == 0 )
        {
            if (lstCards.SelectedValue != "")
            {
                Label6.Text = "Pay by Card";
            }
            else if (lstCards.SelectedValue == "")
            {
                Label6.Text = "First select your card";
            }
        }
       else if (PaymentMethod.SelectedIndex == 1)
        {
            if (ListAccounts.SelectedValue != "")
            {
                Label6.Text = "Pay by Account";
            }
            else if (ListAccounts.SelectedValue == "")
            {
                Label6.Text = "First select your account";
            }
        }
    }




    protected void Button2_Click(object sender, EventArgs e)
    {
        double CardNr;
        if (lstCards.SelectedIndex!= -1)
        {
            CardNr = Convert.ToInt64(lstCards.SelectedValue);
            Session["StockNo"] = CardNr;
            Response.Redirect("Payment_CardEdit.aspx");

        }else
        {
            lbl2Error.Text = "Select Card";
        }
    }
}