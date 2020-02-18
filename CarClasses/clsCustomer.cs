using System;

namespace CarClasses
{
    public class clsCustomer
    {
        public string Customer { get; set; }
        public int CustomerID { get; set; }

        public string Valid(string someCustomerFirst, string someCustomerLast)
        {

            //string variable to store the error message
            string Error = "";
            if (someCustomerFirst.Length <3 || someCustomerFirst.Length >20)
            {
             //return an error message
             Error = "The customer first name must be between 3 and 20 characters long";
            }
            if (someCustomerFirst.Length == 0)
            {
                //return an error message
                Error = "The customer first name must not be blank";
            }
            if (someCustomerLast.Length < 3 || someCustomerLast.Length > 20)
            {
                //return an error message
                Error = "The customer first name must be between 3 and 20 characters long";
            }
            if (someCustomerLast.Length == 0)
            {
                //return an error message
                Error = "The customer first name must not be blank";
            }

            return Error;
            
        }
             
        
    }
}