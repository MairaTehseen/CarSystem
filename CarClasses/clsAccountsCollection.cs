using System.Collections.Generic;
using System;

namespace CarClasses
{
    
    public class clsAccountsCollection
    {
        List<clsAccount> mAccountsList = new List<clsAccount>();
        clsAccount mThisAccount = new clsAccount();
        public clsAccountsCollection()
        {
            
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("PaymentAccountSellect");
            RecordCount = DB.Count;
            while (Index<RecordCount)
            {
                clsAccount anacconut = new clsAccount();

                anacconut.AccountNr = Convert.ToInt32(DB.DataTable.Rows[Index]["AccountNr"]);
                anacconut.AccountHolder = Convert.ToString(DB.DataTable.Rows[Index]["AccountHolder"]);
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
        

        public List<clsAccount> AccountsList
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
            DB.AddParameter("@Bank", mThisAccount.AccountBank);
            

            return DB.Execute("PaymentAccountInsert");

        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CardNr", mThisAccount.AccountNr);
            DB.Execute("PaymentAccountDelete");
        }

        public bool Find(int AccountNr)
        {
            return true;
        }
    }
}