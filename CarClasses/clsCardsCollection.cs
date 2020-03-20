using System.Collections.Generic;
using System;

namespace CarClasses
{
    
    public class clsCardsCollection
    {
        List<clsCard> mCardsList = new List<clsCard>();
        clsCard mThisCard = new clsCard();
        public clsCardsCollection()
        {
            
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            
            DB.AddParameter("@Session", clsLoggedin.session);
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

        }
        

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
        

        public clsCard ThisCard
        {
            get
            {
                //return the private data
                return mThisCard;
            }
            set
            {
                //set the private data
                mThisCard = value;
            }
        }

        public double Add()
        {
            clsDataConnection DB = new clsDataConnection();
            
            DB.AddParameter("@Session", clsLoggedin.session);
            DB.AddParameter("@Active", mThisCard.Active);
            DB.AddParameter("@CardNr", mThisCard.CardNr);
            DB.AddParameter("@CardHolder", mThisCard.CardHolder);
            DB.AddParameter("@CardSecurityNumber", mThisCard.CardSecurityNumber);
            DB.AddParameter("@ExpireDateYear", mThisCard.ExpireDateYear);
            DB.AddParameter("@ExpireDateMonth", mThisCard.ExpireDateMonth);
            return DB.Execute("PaymentCardInsert");

        }

        public void Edit()
        {
            clsDataConnection DB = new clsDataConnection();
            
           
            
            DB.AddParameter("@CardNr", mThisCard.CardNr);
            DB.AddParameter("@CardHolder", mThisCard.CardHolder);
            DB.AddParameter("@CardSecurityNumber", mThisCard.CardSecurityNumber);
            DB.AddParameter("@ExpireDateYear", mThisCard.ExpireDateYear);
            DB.AddParameter("@ExpireDateMonth", mThisCard.ExpireDateMonth);
            DB.Execute("PaymentCardUpdate");

        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CardNr", mThisCard.CardNr);
            DB.Execute("PaymentCardDelete");
        }

        public bool Find(int AddressNo)
        {
            return true;
        }
    }
}