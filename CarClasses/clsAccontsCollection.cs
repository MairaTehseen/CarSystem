using System.Collections.Generic;
using System;

namespace CarClasses
{
    
    public class clsAccontsCollection
    {
        List<clsAccount> mAccountsList = new List<clsAccount>();
        clsAccount mThisAccount = new clsAccount();
        public clsAccontsCollection()
        {
            
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("PaymentAccontsSellect");
            RecordCount = DB.Count;
            while (Index<RecordCount)
            {
                clsAccount anacconut = new clsAccount();

                anacconut.AccountNr = Convert.ToInt32(DB.DataTable.Rows[Index]["AccontNr"]);
                anacconut.AccountHolder = Convert.ToString(DB.DataTable.Rows[Index]["AccontHolder"]);
                anacconut.AccountBank = Convert.ToString(DB.DataTable.Rows[Index]["AccountBank"]);
                mAccountsList.Add(anacconut);
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
        

        public List<clsAccount> AccontsList
        {

            get
            {
                return mAccountsList;
            }
            set
            {
                mAccountsList = value;
            }


        }


        public int Count
        {
            get
            {
                return mAccountsList.Count;
            }
            set
            {
                //asd
            }


        }
        

        public clsAccount ThisAccount
        {
            get
            {
                //return the private data
                return mThisAccount;
            }
            set
            {
                //set the private data
                mThisAccount = value;
            }
        }

        public double Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@AccontNr", mThisAccount.AccountNr);
            DB.AddParameter("@AccontHolder", mThisAccount.AccountHolder);
            DB.AddParameter("@AccountBank", mThisAccount.AccountBank);
            

            return DB.Execute("PaymentAccontInsert");

        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CardNr", mThisAccount.AccountNr);
            DB.Execute("PaymentAcconutDelete");
        }

        public bool Find(int AccountNr)
        {
            return true;
        }
    }
}