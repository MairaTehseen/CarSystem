using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarClasses;

public partial class Payment_Card : System.Web.UI.Page
{
    int AccountNr;
    protected void Page_Load(object sender, EventArgs e)
    {
        AccountNr = Convert.ToInt32(Session["AccountNo"]);
        if (IsPostBack == false)
        {

            if (AccountNr != -1)
            {
                DisplayAccount();
            }
        }
    }
    void DisplayAccount()
    {
        clsAccountsCollection CarSystem = new clsAccountsCollection();
        CarSystem.ThisAccount.Find(AccountNr);
        txtAccountHolder.Text = CarSystem.ThisAccount.AccountHolder;
        txtAccountNumber.Text = CarSystem.ThisAccount.AccountNr.ToString();
        BankName.Text = CarSystem.ThisAccount.AccountBank;
        

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Payment_Details.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Edit();
        if (Edit() == "")
        {
            lblError.Text = "Update was successful";
            Response.Redirect("Payment_Details.aspx");
        }
        else if (Edit() != "")
        {
            lblError.Text = Edit();
        }


    }

    string Edit()
    {
        clsAccountsCollection AccountBook = new clsAccountsCollection();

        String Error = AccountBook.ThisAccount.Valid(txtAccountHolder.Text,BankName.Text,Convert.ToDouble(txtAccountNumber.Text));

        if (Error == "")
        {
            AccountBook.ThisAccount.Find(AccountNr);
            AccountBook.ThisAccount.AccountHolder = txtAccountHolder.Text;
            AccountBook.ThisAccount.AccountBank = BankName.Text;
            AccountBook.ThisAccount.AccountNr = Int32.Parse(txtAccountNumber.Text);
            AccountBook.Edit();
            Response.Redirect("Payment_Details.aspx");
            return Error;
        }
        else
        {
            lblError.Text = "There were problems with data entered" + Error;
            return Error;
        }
    }
}