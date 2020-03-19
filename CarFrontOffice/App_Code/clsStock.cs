using System;

namespace CarClasses
{
    public class clsStock
    {
        private Int32 mStockNo;
        private string mManufacturer;
        private Int32 mQuantity;
        private string mColour;
        private string mModel;
        private decimal mPrice;
        private DateTime mYear;
        
      

        public int StockNo
        {
            get
            {
                return mStockNo;
            }
            set
            {
                mStockNo = value;
            }
        }




        public string Manufacturer
        {
            get
            {
                return mManufacturer;
            }

            set
            {
                mManufacturer = value;
            }
        }

        public string Model
        {
            get
            {
                return mModel;
            }

            set
            {
                mModel = value;
            }
        }

        public string Colour
        {
            get
            {
                return mColour;
            }

            set
            {
                mColour = value;
            }
        }
        public decimal Price
        {
            get
            {
                return mPrice;
            }

            set
            {
                mPrice = value;
            }
        }
        public int Quantity
        {
            get
            {
                return mQuantity;
            }

            set
            {
                mQuantity = value;
            }
        }

        public DateTime StockYear
        {
            get
            {
                return mYear;
            }
            set
            {
                mYear = value;
            }
        }

        

        public void Add(clsStock testItem)
        {
            throw new NotImplementedException();
        }

        public bool Find(int StockNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("StockNo", StockNo);
            DB.Execute("sproc_tblStock_FilterByStockNo");
            if (DB.Count == 1)
            {
                mStockNo = Convert.ToInt32(DB.DataTable.Rows[0]["StockNo"]);
                mManufacturer = Convert.ToString(DB.DataTable.Rows[0]["Manufacturer"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mColour = Convert.ToString(DB.DataTable.Rows[0]["Colour"]);
                mModel = Convert.ToString(DB.DataTable.Rows[0]["Model"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mYear = Convert.ToDateTime(DB.DataTable.Rows[0]["StockYear"]);
                return true;
            }
            else
            {
                return false;
            }


        }


        public string Valid(string manufacturer, int quantity, string colour, string model, int price, DateTime year)
        {
            DateTime DateTemp;
            DateTemp = Convert.ToDateTime(StockYear);
            String Error = "";

            if (manufacturer.Length == 0)
             {
                Error = Error + "The manufacturer may not be blank : ";
             }
             if (manufacturer.Length > 15)
             {
                Error = Error + "The manufacturer must be less than 15 characters : ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(StockYear);
                
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }
            try
            {
                Int32 Temp;
                Temp = Convert.ToInt32(quantity);

                if (Quantity > 20)
                {
                    Error = Error + "The quantity must be less than 20 : ";

                }
            }

            catch
            {
                Error = Error + "The quantity is invalid";
               
            }
            if (quantity > 20)
            {
                Error = Error + "The quantity must be less than 20 : ";
            }
            if (quantity == 0)
            {
                Error = Error = "The quantity must not be blank";
            }

            if (colour.Length == 0)
            {
               Error = Error + "The colour may not be blank : ";

            }
            if (colour.Length < 3)
            {
                Error = Error + "The colour must be longer than 3 characters: ";

            }
            if (colour.Length > 8)
            {
               Error = Error + "The colour must be less than 8 characters : ";
            }

            if (model.Length == 0)
            {
               Error = Error + "The model may not be blank : ";
            }
            if (model.Length > 15)
            {
               Error = Error + "The model must be less than 15 characters : ";

            }

            if (price == 0)

            {
               Error = Error + "The price may not be blank : ";
            }
            try
            {
                Decimal Temp;
                Temp = Convert.ToDecimal(price);

                if (price > 30000)
                {
                    Error = Error + "The price must be less than 30000 : ";
                }
            }
            catch
            {
                Error = Error + "The price is invalid";
            }

           
                return Error;
        }
    }
}
