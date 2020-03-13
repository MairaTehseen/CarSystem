using System;

namespace CarClasses
{
    public class clsCard
    {
        public bool Active { get; set; }
        public double CardNr { get; set; }
        public string CardHolder { get; set; }
        public int CardSecurityNumber { get; set; }
        public int ExpireDateYear { get; set; }
        public int ExpireDateMonth { get; set; }

        public string Valid(string text1, string text2, string text3, string text4, string text5)
        {

            return "";
        }

        public bool Find(double primaryKey)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@CardNr", primaryKey);
            //execute the stored procedure
            DB.Execute("PaymentFindCard");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                Active = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                CardNr = Convert.ToDouble(DB.DataTable.Rows[0]["CardNr"]);
                CardHolder = Convert.ToString(DB.DataTable.Rows[0]["CardHolder"]);
                CardSecurityNumber = Convert.ToInt32(DB.DataTable.Rows[0]["CardSecurityNumber"]);
                ExpireDateYear = Convert.ToInt32(DB.DataTable.Rows[0]["ExpireDateYear"]);
                ExpireDateMonth = Convert.ToInt32(DB.DataTable.Rows[0]["ExpireDateMonth"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
            
        }
    }
}