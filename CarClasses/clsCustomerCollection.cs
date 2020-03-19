using System;
using System.Collections.Generic;

namespace CarClasses
{
    //constructor for the class
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member
        clsCustomer mThisCustomer = new clsCustomer();

        //public property for the customer list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;

            }
            set
            {
                //we shall worry about this later
            }
        }


        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisCustomer 
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the store procedure
            DB.AddParameter("@CustomerFirstName", mThisCustomer.CustomerFirstName);
            DB.AddParameter("@CustomerLastName", mThisCustomer.CustomerLastName);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@TelephoneNo", mThisCustomer.TelephoneNo);
            DB.AddParameter("@Address1", mThisCustomer.Address1);
            DB.AddParameter("@Address2", mThisCustomer.Address2);
            DB.AddParameter("@PostCode", mThisCustomer.PostCode);
            DB.AddParameter("@CustomerPassword", mThisCustomer.CustomerPassword);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");

        }

        //function for deleting exisiting records
        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("CustomerID", mThisCustomer.CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        //function for updating existing records
        public void Update()
        {
            //update an existing record based on the values of thisCustomer
            //connext to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("CustomerFirstName", mThisCustomer.CustomerFirstName);
            DB.AddParameter("CustomerLastName", mThisCustomer.CustomerLastName);
            DB.AddParameter("Email", mThisCustomer.Email);
            DB.AddParameter("TelephoneNo", mThisCustomer.TelephoneNo);
            DB.AddParameter("Address1", mThisCustomer.Address1);
            DB.AddParameter("Address2", mThisCustomer.Address2);
            DB.AddParameter("PostCode", mThisCustomer.PostCode);
            DB.AddParameter("CustomerPassword", mThisCustomer.CustomerPassword);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void ReportByCustomerLastName(string CustomerLastName)
        {
            //filters the records based on a full or partial customer last name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the customer last name parameter to the database
            DB.AddParameter("@CustomerLastName", CustomerLastName);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByLastName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var tos tore the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer record
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current record
                ACustomer.CustomerFirstName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFirstName"]);
                ACustomer.CustomerLastName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerLastName"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomer.TelephoneNo = Convert.ToString(DB.DataTable.Rows[Index]["TelephoneNo"]);
                ACustomer.Address1 = Convert.ToString(DB.DataTable.Rows[Index]["Address1"]);
                ACustomer.Address2 = Convert.ToString(DB.DataTable.Rows[Index]["Address2"]);
                ACustomer.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                ACustomer.CustomerPassword = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPassword"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }
        }

        //constructor for the class
        public clsCustomerCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }



    }
}   


