﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PayMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        { 
            
            DisplayCards(); 

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

    protected void Button4_Click(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Payment_Card.aspx");
    }
}