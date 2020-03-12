using System.Collections.Generic;
using System;

namespace CarClasses
{
    public class clsCardsCollection
    {
        public clsCardsCollection()
        {
            clsCard TestItem = new clsCard();
            TestItem.Active = true;
            TestItem.CardNo = 123123;
            TestItem.CardHolder = "asd";
            TestItem.CardSecurityNumber = 231;
            TestItem.ExpireDateYear = 2020 ;
            TestItem.ExpireDateMonth = 06  ;
            mCardsList.Add(TestItem);
            TestItem = new clsCard();
            TestItem.Active = true;
            TestItem.CardNo = 1231232;
            TestItem.CardHolder = "asd";
            TestItem.CardSecurityNumber = 231;
            TestItem.ExpireDateYear = 2020;
            TestItem.ExpireDateMonth = 06;
            mCardsList.Add(TestItem);

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