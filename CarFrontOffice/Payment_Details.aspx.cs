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
            Session["Session"] = 2;//to connect with HomePage
            clsLoggedin.session =  Convert.ToInt32(Session["Session"]); 
            DisplayCards();
            DisplayAccounts();
            DisplayCustomerName();
            DisplayPayFor();
        }



    }

    void DisplayPayFor()
    {
        Session["Payline"] = "321";//to connect with others tables
        txtPayFor.Items.Add(Convert.ToString(Session["Payline"]));
        
       

    }
    void DisplayCustomerName()
    {
        clsDataConnection DB = new clsDataConnection();
        
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
        
        lstCards.DataTextField = "CardHolder";
        
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
        ListAccounts.DataTextField = "AccountHolder";
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
            Response.Redirect("DeleteCard.aspx");
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
                if (txtPayFor.SelectedValue != "")
                {
                    Label6.Text = "Pay by Card";
                    Pay();
                }
                else if (txtPayFor.SelectedValue == "")
                {
                    Label6.Text = "First select your target";
                }
                
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
                if (txtPayFor.SelectedValue != "")
                {
                    Label6.Text = "Pay by Account";
                    Pay();
                    
                }
                else if (txtPayFor.SelectedValue == "")
                {
                    Label6.Text = "First select your target";
                }
            }
            else if (ListAccounts.SelectedValue == "")
            {
                Label6.Text = "First select your account";
            }
            
        }
    }

    protected void Pay()
    {
        Payment pay = new Payment();
        pay.AddPayment(PaymentMethod.SelectedIndex,Convert.ToInt32(txtPayFor.SelectedValue));
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        double CardNr;
        if (lstCards.SelectedIndex!= -1)
        {
            CardNr = Convert.ToDouble(lstCards.SelectedValue);
            Session["CardNo"] = CardNr;
            Response.Redirect("Payment_CardEdit.aspx");

        }else
        {
            lbl2Error.Text = "Select Card";
        }
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        int AccountNr;
        if (ListAccounts.SelectedIndex != -1)
        {
            AccountNr = Convert.ToInt32(ListAccounts.SelectedValue);
            Session["AccountNo"] = AccountNr;
            Response.Redirect("Payment_AccountEdit.aspx");

        }
        else
        {
            lbl2Error.Text = "Select Account";
        }
    }
}