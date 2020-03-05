
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarClasses
{
    public class clsAddressCollection
    {
        //private data member for the list
        List<clsAddress> mAddressList = new List<clsAddress>();
        //private data member thisAddress
        clsAddress mThisAddress = new clsAddress();

        //constructor for the class
        public clsAddressCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblAddress_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }


        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mAddressList = new List<clsAddress>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsAddress AnAddress = new clsAddress();
                //read in the fields from the current record
                AnAddress.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnAddress.AddressNo = Convert.ToInt32(DB.DataTable.Rows[Index]["AddressNo"]);
                AnAddress.CountyNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CountyNo"]);
                AnAddress.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnAddress.HouseNo = Convert.ToString(DB.DataTable.Rows[Index]["HouseNo"]);
                AnAddress.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                AnAddress.Street = Convert.ToString(DB.DataTable.Rows[Index]["Street"]);
                AnAddress.Town = Convert.ToString(DB.DataTable.Rows[Index]["Town"]);
                //add the record to the private data mamber
                mAddressList.Add(AnAddress);
                //point at the next record
                Index++;
            }

        }

        //public property for the address list
        public List<clsAddress> AddressList
        {
            get
            {
                //return the private data
                return mAddressList;
            }
            set
            {
                //set the private data
                mAddressList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mAddressList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        //public property for ThisAddress
        public clsAddress ThisAddress
        {
            get
            {
                //return the private data
                return mThisAddress;
            }
            set
            {
                //set the private data
                mThisAddress = value;
            }
        }



        public int Add()
        {
            //adds a new record to the database based on the values of thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@HouseNo", mThisAddress.HouseNo);
            DB.AddParameter("@Street", mThisAddress.Street);
            DB.AddParameter("@Town", mThisAddress.Town);
            DB.AddParameter("@PostCode", mThisAddress.PostCode);
            DB.AddParameter("@CountyNo", mThisAddress.CountyNo);
            DB.AddParameter("@DateAdded", mThisAddress.DateAdded);
            DB.AddParameter("@Active", mThisAddress.Active);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblAddress_Insert");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@AddressNo", mThisAddress.AddressNo);
            //execute the stored procedure
            DB.Execute("sproc_tblAddress_Delete");
        }

        public void Update()
        {
            //update an existing record based on the values of thisAddress
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@AddressNo", mThisAddress.AddressNo);
            DB.AddParameter("@HouseNo", mThisAddress.HouseNo);
            DB.AddParameter("@Street", mThisAddress.Street);
            DB.AddParameter("@Town", mThisAddress.Town);
            DB.AddParameter("@PostCode", mThisAddress.PostCode);
            DB.AddParameter("@CountyNo", mThisAddress.CountyNo);
            DB.AddParameter("@DateAdded", mThisAddress.DateAdded);
            DB.AddParameter("@Active", mThisAddress.Active);
            //execute the stored procedure
            DB.Execute("sproc_tblAddress_Update");
        }

        public void ReportByPostCode(string PostCode)
        {
            //filters the records based on a full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the PostCode parameter to the database
            DB.AddParameter("@PostCode", PostCode);
            //execute the stored procedure
            DB.Execute("sproc_tblAddress_FilterByPostCode");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}
