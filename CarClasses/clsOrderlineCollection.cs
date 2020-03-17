using System;
using System.Collections.Generic;
using CarClasses;

namespace CarClasses
{
    public class clsOrderlineCollection
    {
        //private data member for the list
        List<clsOrderline> mOrderlineList = new List<clsOrderline>();
        clsOrderline mThisOrderLine = new clsOrderline();

        //public property for the order List
        public List<clsOrderline> OrderlineList
        {
            get
            {
                //return the private data
                return mOrderlineList;
            }
            set
            {
                //set the private data
                mOrderlineList = value;
            }
        }
        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderlineList.Count;

            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsOrderline ThisOrderLine
        {
            get
            {
                return mThisOrderLine;
            }
            set
            {
                mThisOrderLine = value;
            }
        }

      


        //constructor for the class
        public clsOrderlineCollection()
        {
       


            clsDataConnection DB = new clsDataConnection();
            //excute the stored procedure
            DB.Execute("sproc_tblOrderlineID_SelectAll");
           
            }

            public int Add()
            {
                //adds a new record to the database based on the values of mThisOrder
                //connect to the database
                clsDataConnection DB = new clsDataConnection();
                //set the parameters for the stored procedure
                DB.AddParameter("@OrderlineID", mThisOrderLine.OrderlineID);
                DB.AddParameter("@OrderID", mThisOrderLine.OrderID);
                DB.AddParameter("@ProductID", mThisOrderLine.ProductID);
                DB.AddParameter("@Quantity", mThisOrderLine.Quantity);
                //execute the query returing the primary key value
                return DB.Execute("sproc_tblOrderlineID_Insert");




            }


            public void Delete()
            {
                //deletes the rrcord ponted to by thisOrder
                //connect to the database
                clsDataConnection DB = new clsDataConnection();
                //set the parameters for the rceord procedure
                DB.AddParameter(@"OrderlineID", mThisOrderLine.OrderlineID);
                //execute the stored procedure
                DB.Execute("sproc_tblOrderlineID_Delete");


            }
            public void update()
            {
                //update an existing record based on the values of thisOrder
                //connect to the database
                clsDataConnection DB = new clsDataConnection();
                //set the parameters for the stored procedure
                DB.AddParameter("@OrderlineID", mThisOrderLine.OrderlineID);
                DB.AddParameter("@OrderID", mThisOrderLine.OrderID);
                DB.AddParameter("@ProductID", mThisOrderLine.ProductID);
                DB.AddParameter("@Quantity", mThisOrderLine.Quantity);
                DB.AddParameter("@OrderlineID", mThisOrderLine.OrderlineID);
                //execute the stored procedure
                DB.Execute("sproc_tblOrderlineID_update");


            }
    
            

            
           
           

           
         




























        
    }
}
    
