using System;
using CarClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Car_Testing
{
    [TestClass]
    public class tstStockCollection
    {

        Int32 StockNo = 1;

        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.IsNotNull(AllStock);
        }



        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.StockNo = 1;
            TestItem.Manufacturer = "BMW";
            TestItem.Quantity = 15;
            TestItem.Colour = "White";
            TestItem.Model = "1 Series";
            TestItem.Price = 15000;
            TestItem.StockYear = DateTime.Now;
            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.StockList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Int32 SomeCount = 14;
            AllStock.Count = SomeCount;
            Assert.AreEqual(AllStock.Count, SomeCount);
        }

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestStock = new clsStock();

            TestStock.StockNo = 1;
            TestStock.Manufacturer = "BMW";
            TestStock.Quantity = 15;
            TestStock.Colour = "White";
            TestStock.Model = "1 Series";
            TestStock.Price = 15000;
            TestStock.StockYear = DateTime.Now;

            AllStock.ThisStock = TestStock;
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
        clsStockCollection AllStock = new clsStockCollection();
        List<clsStock> TestList = new List<clsStock>();
        clsStock TestItem = new clsStock();
        TestItem.StockNo = 1;
        TestItem.Manufacturer = "BMW";
        TestItem.Quantity = 15;
        TestItem.Colour = "White";
        TestItem.Model = "1 Series";
        TestItem.Price = 15000;
            TestItem.StockYear = DateTime.Now;
        TestList.Add(TestItem);
            AllStock.StockList = TestList;
       Assert.AreEqual(AllStock.Count, TestList.Count);

        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
        clsStockCollection AllStock = new clsStockCollection();
        Assert.AreEqual(AllStock.Count, 12);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.StockNo = 1;
            TestItem.Manufacturer = "BMW";
            TestItem.Quantity = 10;
            TestItem.Colour = "Black";
            TestItem.Model = "1 Series";
            TestItem.Price = 15000;
            TestItem.StockYear = DateTime.Now;
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.StockNo = PrimaryKey;
            AllStock.ThisStock.Find(StockNo);
            Assert.AreEqual(AllStock.ThisStock, TestItem);

        }

        [TestMethod]
        public void DeleteMethod()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.StockNo = 1;
            TestItem.Manufacturer = "BMW";
            TestItem.Quantity = 10;
            TestItem.Colour = "Black";
            TestItem.Model = "1 Series";
            TestItem.Price = 15000;
            TestItem.StockYear = DateTime.Now;
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.StockNo = PrimaryKey;
            AllStock.ThisStock.Find(StockNo);
            AllStock.Delete();
            Boolean Found = AllStock.ThisStock.Find(StockNo);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethod()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.StockNo = 1;
            TestItem.Manufacturer = "BMW";
            TestItem.Quantity = 10;
            TestItem.Colour = "Black";
            TestItem.Model = "1 Series";
            TestItem.Price = 15000;
            TestItem.StockYear = DateTime.Now;
            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            TestItem.StockNo = PrimaryKey;
            TestItem.StockNo = 2;
            TestItem.Manufacturer = "Seat";
            TestItem.Quantity = 12;
            TestItem.Colour = "Black";
            TestItem.Model = "Ibiza";
            TestItem.Price = 11000;
            TestItem.StockYear = DateTime.Now;
            AllStock.ThisStock = TestItem;
            AllStock.Update();
            AllStock.ThisStock.Find(StockNo);
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void ReportByManufacturerMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStockCollection FilteredStock = new clsStockCollection();
            FilteredStock.ReportByManufacturer("");
            Assert.AreEqual(AllStock.Count, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByManufacturerNoneFound()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStockCollection FilteredStock = new clsStockCollection();
            FilteredStock.ReportByManufacturer("xxx");
            Assert.AreEqual(14, FilteredStock.Count);

        }

        [TestMethod]
        public void ReportByManufacturerTestDataFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection();
            Boolean OK = true;
            FilteredStock.ReportByManufacturer("xxx");
            if (FilteredStock.Count == 2)
            {
                if (FilteredStock.StockList[0].StockNo != 26)
                {
                    OK = false;
                }
                if (FilteredStock.StockList[1].StockNo != 27)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

    }
        
}

    


