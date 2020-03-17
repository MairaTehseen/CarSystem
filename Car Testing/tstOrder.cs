using System;
using CarClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Car_Testing
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        //create some test data to pass to the method
        string CustomerID = "12345";
        string OrderDate = DateTime.Now.Date.ToString();
        string Price = "38000";


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }


        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);

        }
        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }
        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }
        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            double TestData = 1.50;
            //assign the data to the property
            AnOrder.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Price, TestData);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean  variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = AnOrder.Find(CustomerId);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the new class we want to create
            clsOrder AnOrder = new clsOrder();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is ok (assume it is)
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 OrderID = 12345;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the Order Id
            if (AnOrder.OrderID != 12345)
            {
                Ok = false;
            }
            //test to see that the results is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instnace of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //boolean vraibale to store the result of the search
            Boolean Found = false;
            //boolean vraible to rceord if data is ok (assume it is)
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 OrderID = 12345;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the prperty
            if (AnOrder.CustomerID != 12345)


            {
                Ok = false;
            }
            //test to see that the results is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instnace of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //boolean vraibale to store the result of the search
            Boolean Found = false;
            //boolean vraible to rceord if data is ok (assume it is)
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 OrderID = 12345;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the prperty
            if (AnOrder.OrderDate != Convert.ToDateTime("03/11/2020"))

            {
                Ok = false;
            }
            //test to see that the results is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instnace of the class we want to create 
            clsOrder AnOrder = new clsOrder();
            //boolean vraibale to store the result of the search
            Boolean Found = false;
            //boolean vraible to rceord if data is ok (assume it is)
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 OrderID = 12345;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the prperty
            if (AnOrder.Price != 38000)

            {
                Ok = false;
            }
            //test to see that the results is correct
            Assert.IsTrue(Ok);


        }


        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string vraibale to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            //create an instnace of the class we wan to create
            clsOrder AnOrder = new clsOrder();
            //string
            String Error = "";
            //create some test data to pass to the method
            string CustomerID = "1";  //this should trigger on error
            // invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, Price);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");

        }
        public void CustomerIDMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            string Error = "";
            //create some test data to pass to the method
            string CustomerID = "11"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, Price);
            //test to see that result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            string Error = "";
            //create some test data to pass to the method
            string CustomerID = "111"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, Price);
            //test to see that result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            string Error = "";
            //create some test data to pass to the method
            string CustomerID = "11111"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, Price);
            //test to see that result is correct
            Assert.AreEqual(Error, "");

        }
        public void CustomerIDMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            string Error = "";
            //create some test data to pass to the method
            string CustomerID = "111111"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, Price);
            //test to see that result is correct
            Assert.AreEqual(Error, "");

        }
        public void CustomerIDMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            string Error = "";
            //create some test data to pass to the method
            string CustomerID = "111"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, Price);
            //test to see that result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CustomerIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error messages
            string Error = "";
            //create some test data to pass to the method
            string CustomerID = "";
            CustomerID = CustomerID.PadRight(500, '1');//this should fail
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, Price);
            //test to see that result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            //create an instance ofthe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create a vraible to store the test date date
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            //change the data to whatever the data is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert thye date variable to a string vraible 
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void OrderDateMinLessOne()
        {
            //create an instance ofthe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create a vraible to store the test date date
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            //change the data to whatever the data is less 100 years
            TestDate = TestDate.AddDays(-1);
            //convert thye date variable to a string vraible 
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void OrderDateMin()
        {
            //create an instance ofthe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create a vraible to store the test date date
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            //convert thye date variable to a string vraible 
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            //create an instance ofthe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create a vraible to store the test date date
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            //change the data to whatever the data is less 100 years
            TestDate = TestDate.AddDays(1);
            //convert thye date variable to a string vraible 
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void OrderDateExtremeMax()
        {
            //create an instance ofthe class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create a vraible to store the test date date
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            //change the data to whatever the data is less 100 years
            TestDate = TestDate.AddDays(100);
            //convert thye date variable to a string vraible 
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void OrderDateInvalidData()
        {
            //create an instance of the classw e want to craete
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            //set the OrderDate to a non date value
            string OrderDate = "This is not a date!";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, Price);
            //test to see that tyhe result is corrcet
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void PriceMinLessOne()
        {
            //cretae an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string vraibale to store any error message
            string Error = "";
            //this should fail
            string Price = "";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMin()
        {
            //cretae an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string vraibale to store any error message
            string Error = "";
            //this should pass
            string Price = "1";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinPlusOne()
        {
            //cretae an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string vraibale to store any error message
            string Error = "";
            //this should pass
            string Price = "11";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxLessOne()
        {
            //cretae an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string vraibale to store any error message
            string Error = "";
            //this should pass
            string Price = "1111111";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMax()
        {
            //cretae an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string vraibale to store any error message
            string Error = "";
            //this should pass
            string Price = "11111111";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //cretae an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string vraibale to store any error message
            string Error = "";
            //this should fail
            string Price = "111111111";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMid()
        {
            //cretae an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string vraibale to store any error message
            string Error = "";
            //this should pass
            string Price = "1111";
            //invoke the method
            Error = AnOrder.Valid(CustomerID, OrderDate, Price);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    


    }
}