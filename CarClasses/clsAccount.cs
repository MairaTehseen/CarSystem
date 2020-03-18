using System;

namespace CarClasses
{
    public class clsAccount
    {
        public int AccountNr { get; set; }
        public string AccountBank { get; set; }
        public string AccountHolder { get; set; }
       

        public string Valid(string AccontHolder, string Bank, string AccountNr)
        {
            
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            
            //if the HouseNo is blank
            
            //if the house no is greater than 6 characters
            if (AccountNr.Length > 16)
            {
                //record the error
                Error = Error + "Correct card number contain 16 digits, delete an excess : ";
            }
            
            //is the post code blank
            if (AccontHolder.Length == 0)
            {
                //record the error
                Error = Error + "The Card Holder may not be blank : ";
            }
            //if the post code is too long
            if (AccontHolder.Length < 7)
            {
                //record the error
                Error = Error + "The Card Holder must be longer than 6 characters : ";
            }
            if (AccontHolder.Length > 36)
            {
                //record the error
                Error = Error + "The Card Holder cant be longer than 36 characters : ";
            }
            //is the street blank
            if (Bank.Length == 0)
            {
                //record the error
                Error = Error + "The Card security number may not be blank : ";
            }
            //if the street is too long
            if (Bank.Length > 20)
            {
                //record the error
                Error = Error + "Card Number must not be longer than 20 chars : ";
            }
            //is the town blank
            
            //return any error messages
            return Error;
        }

        public bool Find(double primaryKey)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@AccountNr", primaryKey);
            //execute the stored procedure
            DB.Execute("PaymentFindAccount");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                AccountNr = Convert.ToInt32(DB.DataTable.Rows[0]["AccountNr"]);
                AccountBank = Convert.ToString(DB.DataTable.Rows[0]["AccountBank"]);
                AccountHolder = Convert.ToString(DB.DataTable.Rows[0]["AccountHolder"]);
                
               
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