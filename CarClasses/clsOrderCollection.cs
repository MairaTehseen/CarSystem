using System;
using System.Collections.Generic;

namespace CarClasses
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        //private data member thisOrder
        clsOrder mThisOrder = new clsOrder();


        //public property for the order List
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }
        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;

            }
            set
            {
                //we shall worry about this later
            }
        }
        //public property for thisOrder
        public clsOrder ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            }
        }






        //constructor for the class
        public clsOrderCollection()
        {

            clsDataConnection DB = new clsDataConnection();
            //excute the stored procedure
            DB.Execute("sproc_tblOrderID_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);

        }


        public int Add()
        {
            //adds a new record to the database based on the values of mThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@Price", mThisOrder.Price);
            //execute the query returing the primary key value
            return DB.Execute("sproc_tblOrderID_Insert");


        }


        public void Delete()
        {
            //deletes the rrcord ponted to by thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the rceord procedure
            DB.AddParameter(@"OrderID", mThisOrder.OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrderID_Delete");


        }
        public void update()
        {
            //update an existing record based on the values of thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@OrderDate", mThisOrder.OrderDate);
            DB.AddParameter("@Price", mThisOrder.Price);
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrderID_update");


        }
        public void ReportByCustomerID(string CustomerID)
        {
            //filters the rceords based on a full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the CustomerID parameter to the database
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored proecdure
            DB.Execute("sproc_tblOrderID_FilterByCustomerID");
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
            //get the count of rceords
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrder AnOrder = new clsOrder();
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                //add the record to the private data number
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }

        }




    }
}

