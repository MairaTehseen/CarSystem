using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarClasses;

public partial class Delete : System.Web.UI.Page
{
    double CardNr;
    protected void Page_Load(object sender, EventArgs e)
    {
        CardNr = Convert.ToDouble(Session["CardNo"]);
    }

    protected void ButtonNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("Payment_Details.aspx");
    }

    protected void ButtonYes_Click(object sender, EventArgs e)
    {
        DeleteCard();
        Response.Redirect("Payment_Details.aspx");
    }


   void DeleteCard()
    {
        clsCardsCollection CardBook = new clsCardsCollection();
        CardBook.ThisCard.Find(CardNr);
        CardBook.Delete();
    }
}