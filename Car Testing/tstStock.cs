using System;
using CarClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Car_Testing
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock AStock = new clsStock();
            Assert.IsNotNull(AStock);
        }



        [TestMethod]
        public void ActivePropertyOK()
        {
            clsStock AStock = new clsStock();
            Boolean TestData = true;
            AStock.Active = TestData;
            Assert.AreEqual(AStock.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsStock AStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            AStock.DateAdded = TestData;
            Assert.AreEqual(AStock.DateAdded, TestData);
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
        public void CarNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.CarNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.CarNo, TestData);
        }

        [TestMethod]
        public void ManufacturerNoPropertyOK()
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
        public void MakePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "1 Series";
            //assign the data to the property
            AStock.Make = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Make, TestData);
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
        public void TownPropertyOK()
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
    }
}

