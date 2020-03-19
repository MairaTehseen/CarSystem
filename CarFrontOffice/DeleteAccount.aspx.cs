using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarClasses;

public partial class Delete : System.Web.UI.Page
{
    int AccountNr;
    protected void Page_Load(object sender, EventArgs e)
    {
        AccountNr = Convert.ToInt32(Session["AccountNo"]);
    }

    protected void ButtonNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("Payment_Details.aspx");
    }

    protected void ButtonYes_Click(object sender, EventArgs e)
    {
        DeleteAccount();
        Response.Redirect("Payment_Details.aspx");
    }


   void DeleteAccount()
    {
        clsAccountsCollection AccountBook = new clsAccountsCollection();
        AccountBook.ThisAccount.Find(AccountNr);
        AccountBook.Delete();
    }
}