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
        clsCardsCollection CardBook = new clsCardsCollection();

        String Error = CardBook.ThisCard.Valid(txtCardNumber.Text, txtCardHolder.Text, txtsecuritycode.Text,  txtYear.Text, txtMonth.Text);

        if (Error == "")
        {
            CardBook.ThisCard.Active = true;
            CardBook.ThisCard.CardHolder = txtCardHolder.Text;
            CardBook.ThisCard.CardNr = Int64.Parse(txtCardNumber.Text);
            CardBook.ThisCard.ExpireDateMonth = Int32.Parse(txtMonth.Text);
            CardBook.ThisCard.ExpireDateYear = Int32.Parse(txtYear.Text);
            CardBook.ThisCard.CardSecurityNumber = Int32.Parse(txtsecuritycode.Text);
            CardBook.Add();
            Response.Redirect("Payment_Details.aspx");
            return (1);
        }
        else
        {
            lblError.Text = "There were problems with data entered" + Error;
            return (0);
        }
    }
}