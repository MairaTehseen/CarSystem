using System;

namespace CarClasses
{
    public class clsOrder
    {
        //private data member for the OrderID property
        private Int32 mOrderID;
        //private data member for the CustomerID
        private Int32 mCustomerID;
        //private data member for the OrderDate
        private DateTime mOrderDate;
        //private data member for the Price
        private double mPrice;

        public clsOrder()
        {

        }

        public Int32 OrderID
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

        public Int32 CustomerID
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

        //pubic property for the OrderDate

        public DateTime OrderDate
        {
            get
            {
                //return the private data
                return mOrderDate;
            }
            set
            {
                //set the value of the private data member
                mOrderDate = value;
            }
        }

        //pubic property for the Price

        public double Price
        {
            get
            {
                //return the private data
                return mPrice;
            }
            set
            {
                //set the value of the private data member
                mPrice = value;
            }
        }




        public bool Find(int OrderID)
        {
            //create an isnatnce of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Order ID to serach for
            DB.AddParameter("@OrderID", OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByCustomerID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Orderdate"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
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

        public string Valid(string customerID, string orderDate, string price)
        {
            //create  a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //if the CustomerID is Blank
            if (customerID.Length == 0)
            {

                //record the error
                Error = Error + "The CustomerID may not be blank: ";
            }
            try
            {
                Int32 Temp;
                Temp = Convert.ToInt32(CustomerID);
                if (Temp < 1)
                {
                    Error = Error + "CustomerID is too short :";
                }
                if (Temp > 6)
                {
                    Error = Error + "CustomerID must not be less than 6 characters:";
                }
            }
            catch
            {
                Error = Error + "please enter a valid customerID";
            }


            try
            {
                //copy the OrderDate value to the DateTemp vraible
                DateTemp = Convert.ToDateTime(orderDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "the date cannot be in the past: ";
                }
                //check to see if the date is greater than todays date
                if (DateTemp > DateTime.Now.Date)
                {
                    //rceord the error
                    Error = Error + "The date cannot be in the future: ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date :";
            }

            //if the price is blank
            if (price.Length == 0)
            {
                //record an error
                Error = Error + "The price may not be blank: ";
            }
            if (price.Length < 1 | price.Length > 8)
            {
                //record an error
                Error = Error + "The price must be between 1 and 1000 integers:";
            }
            try
            {
                Decimal Temp;
                Temp = Convert.ToDecimal(price);
                if (Temp < 1)
                {
                    Error = Error + "price too short";
                }
                if (Temp > 100000000)
                {
                    Error = Error + "price too long";
                }
            }
            catch
            {
                Error = Error + "Please enter a valid price";
            }

            //return an error messages
            return "";


        }





    }
}