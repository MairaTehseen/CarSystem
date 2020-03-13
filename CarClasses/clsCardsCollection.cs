﻿using System.Collections.Generic;
using System;

namespace CarClasses
{
    
    public class clsCardsCollection
    {
        
        public clsCardsCollection()
        {
            
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("PaymentCardsSellect");
            RecordCount = DB.Count;
            while (Index<RecordCount)
            {
                clsCard acard = new clsCard();
                acard.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]) ;
                acard.CardNr = Convert.ToDouble(DB.DataTable.Rows[Index]["CardNr"]);
                acard.CardHolder = Convert.ToString(DB.DataTable.Rows[Index]["CardHolder"]);
                acard.CardSecurityNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["CardSecurityNumber"]);
                acard.ExpireDateYear = Convert.ToInt32(DB.DataTable.Rows[Index]["ExpireDateYear"]);
                acard.ExpireDateMonth = Convert.ToInt32(DB.DataTable.Rows[Index]["ExpireDateMonth"]);
                mCardsList.Add(acard);
                Index++;
            }
            
            // clsCard TestItem = new clsCard();
            //TestItem.Active = true;
            //TestItem.CardNo = 123123;
            //TestItem.CardHolder = "asd";
            //TestItem.CardSecurityNumber = 231;
            //TestItem.ExpireDateYear = 2020 ;
            //TestItem.ExpireDateMonth = 06  ;
            //mCardsList.Add(TestItem);
            //TestItem = new clsCard();
            //TestItem.Active = true;
            //TestItem.CardNo = 1231232;
            //TestItem.CardHolder = "asd";
            //TestItem.CardSecurityNumber = 231;
            //TestItem.ExpireDateYear = 2020;
            //TestItem.ExpireDateMonth = 06;
            //mCardsList.Add(TestItem);

        }
        List<clsCard> mCardsList = new List<clsCard>();

        public List<clsCard> CardsList
        {

            get
            {
                return mCardsList;
            }
            set
            {
                mCardsList = value;
            }


        }


        public int Count
        {
            get
            {
                return mCardsList.Count;
            }
            set
            {
                //asd
            }


        }
        public object ThisCard { get; set; }
    }
}