using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CarClasses
{
    public class clsCustomer
    {
        //private data member for the CustomerID property
        private Int32 mCustomerID;
        private string mCustomerFirstName;
        private string mCustomerLastName;
        private string mEmail;
        private string mTelephoneNo;
        private string mAddress1;
        private string mAddress2;
        private string mPostCode;
        private string mCustomerPassword;

        //public string Customer
        //{
        //get
        //{
        //return the private data
        //return mCustomer;
        //}
        //set
        //{
        //set the value of the private data member
        //mCustomer = value;
        //}
        //}


        //public property for the customer ID
        public int CustomerID
        {
            get
            {
                //return the private data
                return mCustomerID;
            }
            set
            {
                //set the value of the private data member
                mCustomerID = value;
            }

        }



        public string Address1
        {
            get
            {
                //return the private data
                return mAddress1;
            }
            set
            {
                //set the value of the private data member
                mAddress1 = value;
            }
        }


        public string Address2
        {
            get
            {
                //return the private data
                return mAddress2;
            }
            set
            {
                //set the value of the private data member
                mAddress2 = value;
            }

        }


        public string PostCode
        {
            get
            {
                //return the private data
                return mPostCode;
            }
            set
            {
                //set the value of the private data member
                mPostCode = value;
            }
        }

        public string TelephoneNo
        {
            get
            {
                //return the private data
                return mTelephoneNo;
            }
            set
            {
                //set the value of the private data member
                mTelephoneNo = value;
            }
        }



        public string Email
        {
            get
            {
                //return the private data 
                return mEmail;
            }
            set
            {
                //set the value of teh private data member
                mEmail = value;
            }
        }


        public string CustomerLastName
        {
            get
            {
                //return the private data
                return mCustomerLastName;
            }
            set
            {
                //set the value of the private data member
                mCustomerLastName = value;
            }
        }

        public string CustomerFirstName
        {
            get
            {
                //return the private data
                return mCustomerFirstName;
            }
            set
            {
                //set the value of the private data member
                mCustomerFirstName = value;
            }
        }

        public string CustomerPassword
        {
            get
            {
                //return the private data
                return mCustomerPassword;
            }
            set
            {
                //set the value of the private data member
                mCustomerPassword = value;
            }
        }



        public bool Find(int CustomerID)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer id to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //excute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found(there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from teh database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCustomerFirstName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFirstName"]);
                mCustomerLastName = Convert.ToString(DB.DataTable.Rows[0]["CustomerLastName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mTelephoneNo = Convert.ToString(DB.DataTable.Rows[0]["TelephoneNo"]);
                mAddress1 = Convert.ToString(DB.DataTable.Rows[0]["Address1"]);
                mAddress2 = Convert.ToString(DB.DataTable.Rows[0]["Address2"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mCustomerPassword = Convert.ToString(DB.DataTable.Rows[0]["CustomerPassword"]);
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

        public string Valid(string customerFirstName, string customerLastName, string email, string telephoneNo, string address1, string address2, string postCode, string customerPassword)
        {
            //create a string variable to store the error
            String Error = "";
            //if the customer first name is blank
            if (customerFirstName.Length == 0)
            {
                //record the error
                Error = Error + "The customer first name may not be blank : ";
            }

            //if the customer first name is less than 3 characters long or more than 20 characters long
            if (customerFirstName.Length < 3 | customerFirstName.Length > 20)
            {
                //record the error
                Error = Error + "The customer first name must be between 3 to 20 characters long : ";
            }

            //if the customer last name is blank
            if (customerLastName.Length == 0)
            {
                //record the error
                Error = Error + "The customer first name may not be blank : ";
            }

            //if the customer first name is less than 3 characters long or more than 20 characters long
            if (customerLastName.Length < 3 | customerLastName.Length > 20)
            {
                //record the error
                Error = Error + "The customer first name must be between 3 to 20 characters long : ";
            }

            //if the email is blank
            if (email.Length == 0)
            {
                //record the error
                Error = Error + "The email may not be blank : ";
            }

            //if the email is less than 13 or more than 40 characters long
            if (email.Length < 13 | email.Length > 40)
            {
                //record the error 
                Error = Error + "The email must be between 13 to 40 characters long";
            }

            //if the telephone number is blank
            if (telephoneNo.Length == 0)
            {
                //record the error
                Error = Error + "The telephone no may not be blank : ";
                try
                {
                    Int32 Temp;
                    Temp = Convert.ToInt32(telephoneNo);
                    if (Temp < 16 | Temp > 16)
                    {
                        //record the error
                        Error = Error + "The telephone number is invalid : ";
                    }
                }
                catch
                {
                    //record the error
                    Error = Error + "Please enter a vald Uk telephone number";
                }
            }

            //if Address1 is blank
            if (address1.Length == 0)
            {
                //record the error
                Error = Error + "Address1 may not be blank";
            }

            //if Address1 is more than 40 characters long
            if (address1.Length > 40)
            {
                //record the error 
                Error = Error + "Address2 is too long";
            }

            //if Address2 is blank
            if (address2.Length == 0)
            {
                //record the error
                Error = Error + "Address1 may not be blank";
            }

            //if Address 2 is more than 40 characters long
            if (address2.Length > 20)
            {
                //record the error 
                Error = Error + "Address2 is too long";
            }

            //if the postcode is blank
            if (postCode.Length == 0)
            {
                //record the error
                Error = Error + "The postcode may not be blank";
            }

            //if the postcode is less than 7 characters long or more than 9 characters long
            if (postCode.Length < 7 | postCode.Length > 8)
            {
                //record the error
                Error = Error + "Please enter a valid postcode";
            }

            //if the customer password is blank
            if (customerPassword.Length == 0)
            {
                //record the error
                Error = Error + "Password name may not be blank : ";
            }

            //if the customer first name is less than 3 characters long or more than 20 characters long
            if (customerPassword.Length < 3 | customerPassword.Length > 20)
            {
                //record the error
                Error = Error + "Password must be between 3 to 20 characters long : ";
            }





            //return any error messages
            return Error;
        }
    }
}
