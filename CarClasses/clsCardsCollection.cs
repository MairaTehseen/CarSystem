using System.Collections.Generic;

namespace CarClasses
{
    public class clsCardsCollection
    {
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