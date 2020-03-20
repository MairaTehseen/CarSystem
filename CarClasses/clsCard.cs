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

        public string Valid(string CardNr, string CardHolder, string CardSecurityNumber, string ExpireDateYear, string ExpireDateMonth)
        {
            
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the HouseNo is blank
            if (CardNr.Length < 15)
            {
                //record the error
                Error = Error + "Correct card number contain 15 digits, write full card number : ";
            }
            //if the house no is greater than 6 characters
            if (CardNr.Length > 15)
            {
                //record the error
                Error = Error + "Correct card number contain 15 digits, delete an excess : ";
            }
            int n;
            
            if (Int32.TryParse(ExpireDateMonth, out n) )
                { 
                 if (Convert.ToInt32(ExpireDateMonth) < 12 )
                 {
                //record the error
                     
                }
                else
                {
                    Error = Error + "Wrong Month";
                }
                if (Convert.ToInt32(ExpireDateMonth) > 1)
                {
                    //record the error

                }
                else
                {
                    Error = Error + "Wrong Month Parse";
                }
                
            }
            if (Int32.TryParse(ExpireDateYear, out n))
            {
                if (Convert.ToInt32(ExpireDateYear) > 2100)
                {
                    //record the error
                    Error = Error + "Wrong Year";
                }
                try
                {
                    //copy the dateAdded value to the DateTemp variable
                    DateTemp = Convert.ToDateTime("01/" + ExpireDateMonth + "/" + ExpireDateYear);
                    if (DateTemp < DateTime.Now.Date)
                    {
                        //record the error
                        Error = Error + "The date cannot be in the past : ";
                    }
                    //check to see if the date is greater than today's date

                }
                catch
                {
                    //record the error
                    Error = Error + "The date was not a valid date : ";
                }
            }else
            {
                Error = Error + "Wrong Year Parse";
            }
            //is the post code blank
            if (CardHolder.Length == 0)
            {
                //record the error
                Error = Error + "The Card Holder may not be blank : ";
            }
            //if the post code is too long
            if (CardHolder.Length < 7)
            {
                //record the error
                Error = Error + "The Card Holder must be longer than 6 characters : ";
            }
            if (CardHolder.Length > 36)
            {
                //record the error
                Error = Error + "The Card Holder cant be longer than 36 characters : ";
            }
            //is the street blank
            if (CardSecurityNumber.Length == 0)
            {
                //record the error
                Error = Error + "The Card security number may not be blank : ";
            }
            //if the street is too long
            if (CardSecurityNumber.Length > 3)
            {
                //record the error
                Error = Error + "The Card Security Number must be less than 4 characters : ";
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
            DB.AddParameter("@CardNr", primaryKey);
            //execute the stored procedure
            DB.Execute("PaymentFindCard");
            //if one record is found (there should be either one or zero!)
            if (DB.Count > 0)
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