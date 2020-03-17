using System;

namespace CarClasses
{
    public class clsOrderline
    {
        //private data member for the OrderID property
        private Int32 mOrderLineID;
        //private data member for the CustomerID
        private int mOrderID;
        //private data member for the OrderDate
        private int mProductID;
        //private data member for the Price
        private int mQuantity;

        public clsOrderline()
        {
        }

        //public property for OrderlineID
        public int OrderlineID
        {
            get
            {
                //return the private data
                return mOrderLineID;
            }
            set
            {
                //set the value of the private data member
                mOrderLineID = value;
            }
        }
        public int OrderID
        {
            get
            {
                //return the private data
                return mOrderID;
            }
            set
            {
                //set the value of the private data member
                mOrderID = value;
            }
        }
        public int ProductID
        {
            get
            {
                //return the private data
                return mProductID;
            }
            set
            {
                //set the value of the private data member
                mProductID = value;
            }
        }
        public int Quantity
        {
            get
            {
                //return the private data
                return mQuantity;
            }
            set
            {
                //set the value of the private data member
                mQuantity = value;
            }
        }

        public bool Find(int OrderlineID)
        {
            //create an isnatnce of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Order ID to serach for
            DB.AddParameter("@OrderlineID", OrderlineID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrderline_FilterByOrderlineID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderLineID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderlineID"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                //return that everthing worked Ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string OrderID, string productID, string quantity)
        {
            //craete a string variable to store the Error
            string Error = "";
            //if the OrderID is blank
            if (OrderID.Length == 0)
            {
                //record the Error
                Error = Error + "The OrderID may not be blank:";

            }
            try
            {
                Int32 Temp;
                Temp = Convert.ToInt32(OrderID);
                if (Temp < 1)
                {
                    Error = Error + "CustomerID is too short :";
                }
                if (Temp > 8)
                {
                    Error = Error + "CustomerID must not be less than 8 digits:";
                }
            }
            catch
            {
                Error = Error + "please enter a valid orderID";
            }

            //if the ProductID is Blank
            if (productID.Length == 0)
            {

                //record the error
                Error = Error + "The ProductID may not be blank: ";
            }
            try
            {
                Int32 Temp;
                Temp = Convert.ToInt32(ProductID);
                if (Temp < 1)
                {
                    Error = Error + "ProductID is too short :";
                }
                if (Temp > 8)
                {
                    Error = Error + "ProductID must not be less than 8 digits:";
                }
            }
            catch
            {
                Error = Error + "please enter a valid ProductID";
            }
            //if the Quantity is Blank
            if (quantity.Length == 0)
            {

                //record the error
                Error = Error + "The quantity may not be blank: ";
            }
            try
            {
                Int32 Temp;
                Temp = Convert.ToInt32(Quantity);
                if (Temp < 1)
                {
                    Error = Error + "Quantity is too short :";
                }
                if (Temp > 1)
                {
                    Error = Error + "Quantity must not be less than 1 characters:";
                }
            }
            catch
            {
                Error = Error + "please enter a valid Quantity";
            }
            //return any error messages
            return "";
        }
    }
}