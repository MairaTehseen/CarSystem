using System;
using System.Collections.Generic;

namespace CarClasses
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();
        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {

            }
        }

        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            
            DB.AddParameter("Manufacturer", mThisStock.Manufacturer);
            DB.AddParameter("Quantity", mThisStock.Quantity);
            DB.AddParameter("Colour", mThisStock.Colour);
            DB.AddParameter("Model", mThisStock.Model);
            DB.AddParameter("Price", mThisStock.Price);
            DB.AddParameter("StockYear", mThisStock.StockYear);
            return DB.Execute("sproc_tblStock_Insert");

        }

        

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockNo", mThisStock.StockNo);
            DB.Execute("sproc_tblStock_Delete");
        }

 
        public clsStockCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            PopulateArray(DB);
            
        }
        
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("StockNo", mThisStock.StockNo);
            DB.AddParameter("Manufacturer", mThisStock.Manufacturer);
            DB.AddParameter("Quantity", mThisStock.Quantity);
            DB.AddParameter("Colour", mThisStock.Colour);
            DB.AddParameter("Model", mThisStock.Model);
            DB.AddParameter("Price", mThisStock.Price);
            DB.AddParameter("StockYear", mThisStock.StockYear);
            DB.Execute("sproc_tblStock_Update");
        }

        public void FilterByManufacturer(string Manufacturer)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Manufacturer", Manufacturer);
            DB.Execute("sproc_tblStock_FilterByManufacturer");
            PopulateArray(DB);
        }
        public void FilterByStockNo(Int32 StockNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockNo", StockNo);
            DB.Execute("sproc_tblStock_FilterByStockNo");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStockList = new List<clsStock>();
            while (Index < RecordCount)
            {
                clsStock AStock = new clsStock();
                AStock.StockNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StockNo"]);
                AStock.Manufacturer = Convert.ToString(DB.DataTable.Rows[Index]["Manufacturer"]);
                AStock.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AStock.Colour = Convert.ToString(DB.DataTable.Rows[Index]["Colour"]);
                AStock.Model = Convert.ToString(DB.DataTable.Rows[Index]["Model"]);
                AStock.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                AStock.StockYear = Convert.ToDateTime(DB.DataTable.Rows[Index]["StockYear"]);
                mStockList.Add(AStock);
                Index++;
            }
        }

        public void ReportByManufacturer(string Manufacturer)
        {
            
                clsDataConnection DB = new clsDataConnection();
                DB.AddParameter("@Manufacturer", Manufacturer);
                DB.Execute("sproc_tblStock_FilterByManufacturer");
                PopulateArray(DB);
            
        }
    }
}