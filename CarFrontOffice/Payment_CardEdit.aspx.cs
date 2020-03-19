using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarClasses;

public partial class Payment_Card : System.Web.UI.Page
{
    Int32 CardNr;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Payment_Details.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Edit();
        if (Edit()=="")
        {
            lblError.Text = "Update was successful";
        Response.Redirect("Payment_Details.aspx");
        }else if (Edit() != "")
        {
            lblError.Text =Edit();
        }
    }

    string Edit()
    {
        clsCardsCollection CardBook = new clsCardsCollection();

        String Error = CardBook.ThisCard.Valid(txtCardNumber.Text, txtCardHolder.Text, txtsecuritycode.Text,  txtYear.Text, txtMonth.Text);

        if (Error == "")
        {
            CardBook.ThisCard.Find(CardNr);
            CardBook.ThisCard.CardHolder = txtCardHolder.Text;
            CardBook.ThisCard.CardNr = Int64.Parse(txtCardNumber.Text);
            CardBook.ThisCard.ExpireDateMonth = Int32.Parse(txtMonth.Text);
            CardBook.ThisCard.ExpireDateYear = Int32.Parse(txtYear.Text);
            CardBook.ThisCard.CardSecurityNumber = Int32.Parse(txtsecuritycode.Text);
            CardBook.Edit();
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