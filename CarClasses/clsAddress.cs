

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarClasses
{
    public class clsAddress
    {
        //private data member for the AddressNo property
        private Int32 mAddressNo;
        //private data member for HouseNo
        private string mHouseNo;
        //private data member for street
        private string mStreet;
        //private data member for town
        private string mTown;
        //private data member for post code
        private string mPostCode;
        //private data member for county no
        private Int32 mCountyNo;
        //private date added data member
        private DateTime mDateAdded;
        //private data member for active
        private Boolean mActive;

        //public property for active
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }

        //public property for date added
        public DateTime DateAdded
        {
            get
            {
                //return the private data
                return mDateAdded;
            }
            set
            {
                //set the private data
                mDateAdded = value;
            }
        }

        //public property for the address number
        public int AddressNo
        {
            get
            {
                //return the private data
                return mAddressNo;
            }
            set
            {
                //set the value of the private data member
                mAddressNo = value;
            }
        }

        //public property for county no
        public int CountyNo
        {
            get
            {
                //return the private data
                return mCountyNo;
            }
            set
            {
                //set the private data
                mCountyNo = value;
            }
        }

        //public property for house no
        public string HouseNo
        {
            get
            {
                //return private data
                return mHouseNo;
            }
            set
            {
                //set the private data
                mHouseNo = value;
            }
        }

        //public property for post code
        public string PostCode
        {
            get
            {
                //return the private data
                return mPostCode;
            }
            set
            {
                //set the private data
                mPostCode = value;
            }
        }

        //public data member for street
        public string Street
        {
            get
            {
                //return the private data
                return mStreet;
            }
            set
            {
                //set the private data
                mStreet = value;
            }
        }

        //public data member for Town
        public string Town
        {
            get
            {
                //return the private data
                return mTown;
            }
            set
            {
                //set the private data
                mTown = value;
            }
        }


        public bool Find(int AddressNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@AddressNo", AddressNo);
            //execute the stored procedure
            DB.Execute("sproc_tblAddress_FilterByAddressNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mAddressNo = Convert.ToInt32(DB.DataTable.Rows[0]["AddressNo"]);
                mHouseNo = Convert.ToString(DB.DataTable.Rows[0]["HouseNo"]);
                mStreet = Convert.ToString(DB.DataTable.Rows[0]["Street"]);
                mTown = Convert.ToString(DB.DataTable.Rows[0]["Town"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mCountyNo = Convert.ToInt32(DB.DataTable.Rows[0]["CountyNo"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
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

        public string Valid(string houseNo, string street, string town, string postCode, string dateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the HouseNo is blank
            if (houseNo.Length == 0)
            {
                //record the error
                Error = Error + "The house no may not be blank : ";
            }
            //if the house no is greater than 6 characters
            if (houseNo.Length > 6)
            {
                //record the error
                Error = Error + "The house no must be less than 6 characters : ";
            }
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //is the post code blank
            if (postCode.Length == 0)
            {
                //record the error
                Error = Error + "The post code may not be blank : ";
            }
            //if the post code is too long
            if (postCode.Length > 9)
            {
                //record the error
                Error = Error + "The post code must be less than 9 characters : ";
            }
            //is the street blank
            if (street.Length == 0)
            {
                //record the error
                Error = Error + "The street may not be blank : ";
            }
            //if the street is too long
            if (street.Length > 50)
            {
                //record the error
                Error = Error + "The street must be less than 50 characters : ";
            }
            //is the town blank
            if (town.Length == 0)
            {
                //record the error
                Error = Error + "The town may not be blank : ";
            }
            //if the town is too long
            if (town.Length > 50)
            {
                //record the error
                Error = Error + "The town must be less than 50 characters : ";
            }
            //return any error messages
            return Error;
        }
    }
}

