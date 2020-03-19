using System;
using CarClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Car_Testing
{
    [TestClass]
    public class tstStock
    {
        string Manufacturer = "Seat";
        int Quantity = 12;
        string Colour = "Black";
        string Model = "Ibiza";
        int Price = 18000;
        DateTime Year = DateTime.Now.Date;





        [TestMethod]
        public void InstanceOK()
        {
            clsStock AStock = new clsStock();
            Assert.IsNotNull(AStock);
        }


        [TestMethod]
        public void YearPropertyOK()
        {
            clsStock AStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            AStock.Year = TestData;
            Assert.AreEqual(AStock.Year, TestData);
        }

        [TestMethod]
        public void StockNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.StockNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.StockNo, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 15;
            //assign the data to the property
            AStock.StockNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.StockNo, TestData);
        }


        [TestMethod]
        public void ManufacturerPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "BMW";
            //assign the data to the property
            AStock.Manufacturer = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Manufacturer, TestData);
        }

        [TestMethod]
        public void ModelPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "1 Series";
            //assign the data to the property
            AStock.Model = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Model, TestData);
        }

        [TestMethod]
        public void ColourPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Black";
            //assign the data to the property
            AStock.Colour = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Colour, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 15000;
            //assign the data to the property
            AStock.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Price, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Int32 StockNo = 5;
            Found = AStock.Find(StockNo);
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestStockNoFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockNo = 5;
            Found = AStock.Find(StockNo);
            if (AStock.StockNo != 5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestModelFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockNo = 5;
            Found = AStock.Find(StockNo);
            if (AStock.Model != "A4")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestManufacturerFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockNo = 5;
            Found = AStock.Find(StockNo);
            //check the property
            if (AStock.Manufacturer != "Audi")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockNo = 5;
            Found = AStock.Find(StockNo);
            if (AStock.Quantity != 10)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestColourFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockNo = 5;
            Found = AStock.Find(StockNo);
            if (AStock.Colour != "Blue")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockNo = 5;
            Found = AStock.Find(StockNo);
            if (AStock.Price != 18000)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestYearFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockNo = 5;
            Found = AStock.Find(StockNo);
            if (AStock.Year != Convert.ToDateTime("01 / 06 / 2017"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void ManufacturerMinLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Manufacturer = "";
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ManufacturerMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Manufacturer = "a";
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ManufacturerMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Manufacturer = "aa";
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ManufacturerMaxLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Manufacturer = "aaaaaaaaaaaaaa";
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ManufacturerMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Manufacturer = "aaaaaaaaaaaaaaa";
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ManufacturerMid()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Manufacturer = "aaaaaaa";
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ManufacturerMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Manufacturer = "aaaaaaaaaaaaaaaa";
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void ManufacturerExtremeMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Manufacturer = "";
            Manufacturer = Manufacturer.PadRight(500, 'a');
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void YearExtremeMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-40);
            string DateAdded = TestDate.ToString();
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void YearMinLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now;
            TestDate = TestDate.AddDays(-1);
            DateTime Year = TestDate;
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void YearMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            
            DateTime Year = TestDate;
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void YearMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            DateTime Year = TestDate.Date;
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void YearExtremeMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(40);
            DateTime Year = TestDate;
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void YearInvalidData()
        {
          
            clsStock AStock = new clsStock();
            String Error = "";

            //DateTime Year = "This is not a date";
           // Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
           // Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            int Quantity = 0;
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            int Quantity = 1;
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            int Quantity = 2;
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMaxLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            int Quantity = 19;
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            int Quantity = 20;
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMid()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            int Quantity = 10;
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            int Quantity = 21;
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreNotEqual(Error, "");


        }

       
        [TestMethod]
        public void ColourMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Colour = "ab";
            //invoke the method
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ColourMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Colour = "abc";
            //invoke the method
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Colour = "abcd";
            //invoke the method
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Colour = "abcdefg";
            
            //invoke the method
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Colour = "abcdefgh";
            
            //invoke the method
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Colour = "abcdefgh";

            //invoke the method
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourExtremeMax()
        {
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            Colour = Colour.PadRight(25, 'a');

            //invoke the method
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ColourMid()
        {
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Colour = "abcd";
            
            //invoke the method
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelMinLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Model = "";
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ModelMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Model = "b";
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ModelMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Model = "bb";
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ModelMaxLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Model = "bbbbbbbbbbbbbb";
            
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ModelMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Model = "bbbbbbbbbbbbbbb";
            
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ModelMid()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Model = "bbbbbbb";
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ModelMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Model = "bbbbbbbbbbbbbbbb";
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void ModelExtremeMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Model = "";
            Model = Model.PadRight(50, 'a');
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreNotEqual(Error, "");
        }
        public void PriceMinLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            int Price = 4999;
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            int Price = 5000;
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            int Price = 5001;
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            int Price = 29999;
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            int Price = 30000;
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMid()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            int Price = 15000;
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            int Price = 30001;
            Error = AStock.Valid(Manufacturer, Quantity, Colour, Model, Price, Year);
            Assert.AreNotEqual(Error, "");


        }
    }

}
        
        




