using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarClasses;

public partial class Payment_Card : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Payment_Details.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Add();
        if (Add()==1)
        {
            Response.Redirect("Payment_Details.aspx");
        }
        
       
    }

    int Add()
    {
        clsAccountsCollection AccountBook = new clsAccountsCollection();

        String Error = AccountBook.ThisAccount.Valid(txtAccountHolder.Text, txtAccountNumber.Text, BankName.Text);

        if (Error == "")
        {

            AccountBook.ThisAccount.AccountHolder = txtAccountHolder.Text;
            AccountBook.ThisAccount.AccountNr = Int32.Parse(txtAccountNumber.Text);
            AccountBook.ThisAccount.AccountBank = BankName.Text;
            
            AccountBook.Add();
            Response.Redirect("Payment_Details.aspx");
            return (1);
        }
        else
        {
            Label2.Text = "There were problems with data entered" + Error;
            return (0);
        }
    }
}