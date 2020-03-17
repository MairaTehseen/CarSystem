using System;
using CarClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Car_Testing
{
    [TestClass]
    public class tstOrderline
    {
      
        //good test data
        //create some test data to pass to the method
        string OrderID = "12345";
        string ProductID = "1345";
        string Quantity = "1";


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrder = new clsOrderline();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void OrderIDOK()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderLine = new clsOrderline();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderLine.OrderID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.OrderID, TestData);

        }
        [TestMethod]
        public void OrderLineIDOK()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderLine = new clsOrderline();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderLine.OrderlineID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.OrderlineID, TestData);
        }
        [TestMethod]
        public void ProductIDOK()
        {

            //create an instance of the class we want to create
            clsOrderline AnOrderLine = new clsOrderline();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderLine.ProductID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.ProductID, TestData);
        }
        [TestMethod]
        public void QuantityOK()
        {

            //create an instance of the class we want to create
            clsOrderline AnOrderLine = new clsOrderline();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrderLine.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.Quantity, TestData);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //Boolean  variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderlineID = 12345;
            //invoke the method
            Found = AnOrderline.Find(OrderlineID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderlineIDFound()
        {
            //create an instance of the new class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is ok (assume it is)
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 OrderlineID = 12345;
            //invoke the method
            Found = AnOrderline.Find(OrderlineID);
            //check the Orderline Id
            if (AnOrderline.OrderlineID != 12345)
            {
                Ok = false;
            }
            //test to see that the results is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instnace of the class we want to create 
            clsOrderline AnOrderline = new clsOrderline();
            //boolean vraibale to store the result of the search
            Boolean Found = false;
            //boolean vraible to rceord if data is ok (assume it is)
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 OrderlineID = 12345;
            //invoke the method
            Found = AnOrderline.Find(OrderlineID);
            //check the prperty
            if (AnOrderline.OrderID != 12345)

            {
                Ok = false;
            }
            //test to see that the results is correct
            Assert.IsTrue(Ok);

        }
        [TestMethod]
        public void TestProductIDFound()
        {
            //create an instnace of the class we want to create 
            clsOrderline AnOrderline = new clsOrderline();
            //boolean vraibale to store the result of the search
            Boolean Found = false;
            //boolean vraible to rceord if data is ok (assume it is)
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 OrderlineID = 12345;
            //invoke the method
            Found = AnOrderline.Find(OrderlineID);
            //check the prperty
            if (AnOrderline.ProductID != 12345)

            {
                Ok = false;
            }
            //test to see that the results is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instnace of the class we want to create 
            clsOrderline AnOrderline = new clsOrderline();
            //boolean vraibale to store the result of the search
            Boolean Found = false;
            //boolean vraible to rceord if data is ok (assume it is)
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 OrderlineID = 12345;
            //invoke the method
            Found = AnOrderline.Find(OrderlineID);
            //check the prperty
            if (AnOrderline.Quantity != 12345)

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
            clsOrderline AnOrderline = new clsOrderline();
            //string vraibale to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrderline.Valid(OrderID, ProductID, Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void OrderIDMinLessOne()
        {
            //cretae an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string vraibale to store any error message
            string Error = "";
            //create some test data to pass to the method
            string OrderID = "";
            //invoke the method
            Error = AnOrderline.Valid(OrderID, ProductID, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDMin()
        {
            //cretae an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string vraibale to store any error message
            string Error = "";
            //this should pass
            string OrderID = "1";
            //invoke the method
            Error = AnOrderline.Valid(OrderID, ProductID, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDMinPlusOne()
        {
            //cretae an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string vraibale to store any error message
            string Error = "";
            //this should pass
            string OrderID = "11";
            //invoke the method
            Error = AnOrderline.Valid(OrderID, ProductID, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDMaxLessOne()
        {
            //cretae an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string vraibale to store any error message
            string Error = "";
            //this should pass
            string OrderID = "11111111";
            //invoke the method
            Error = AnOrderline.Valid(OrderID, ProductID, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDMax()
        {
           //cretae an instance of the class we want to create
             clsOrderline AnOrderline = new clsOrderline();
          //string vraibale to store any error message
            string Error = "";
          //this should pass
           string OrderID = "111111111";
          //invoke the method
          Error = AnOrderline.Valid(OrderID, ProductID, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDMaxPlusOne()
        {
            //cretae an instance of the class we want to create
              clsOrderline AnOrderline = new clsOrderline();
          //string vraibale to store any error message
             string Error = "";
          //this should fail
          string OrderID = "1111111111";
           //invoke the method
           Error = AnOrderline.Valid(OrderID, ProductID, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDMid()
        {
            //cretae an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string vraibale to store any error message
            string Error = "";
            //this should pass
            string OrderID = "1111";
            //invoke the method
            Error = AnOrderline.Valid(OrderID, ProductID, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderIDExtremeMax()
        {
            //cretae an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string vraibale to store any error message
            string Error = "";
            //this should pass
            string OrderID = "";
            OrderID = OrderID.PadRight(500, '1');//this should fail
            //invoke the method
            Error = AnOrderline.Valid(OrderID, ProductID, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductIDMinLessOne()
        {
            //cretae an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string vraibale to store any error message
            string Error = "";
            //create some test data to pass to the method
            string ProductID = "";
            //invoke the method
            Error = AnOrderline.Valid(OrderID, ProductID, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductIDMin()
        {
            //cretae an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string vraibale to store any error message
            string Error = "";
            //this should pass
            string ProductID = "1";
            //invoke the method
            Error = AnOrderline.Valid(OrderID, ProductID, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductIDMinPlusOne()
        {
            //cretae an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string vraibale to store any error message
            string Error = "";
            //this should pass
            string ProductID = "11";
            //invoke the method
            Error = AnOrderline.Valid(OrderID, ProductID, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductIDMaxLessOne()
        {
            //cretae an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string vraibale to store any error message
            string Error = "";
            //this should pass
            string ProductID = "11111111";
            //invoke the method
            Error = AnOrderline.Valid(OrderID, ProductID, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductIDMax()
        {
            //cretae an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string vraibale to store any error message
            string Error = "";
            //this should pass
            string ProductID = "111111111";
            //invoke the method
            Error = AnOrderline.Valid(OrderID, ProductID, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductIDMaxPlusOne()
        {
            //cretae an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string vraibale to store any error message
            string Error = "";
            //this should fail
            string ProductID = "1111111111";
            //invoke the method
            Error = AnOrderline.Valid(OrderID, ProductID, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductIDMid()
        {
            //cretae an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string vraibale to store any error message
            string Error = "";
            //this should pass
            string ProductID = "1111";
            //invoke the method
            Error = AnOrderline.Valid(OrderID, ProductID, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductIDExtremeMax()
        {
            //cretae an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string vraibale to store any error message
            string Error = "";
            //this should pass
            string ProductID = "";
            OrderID = OrderID.PadRight(500, '1');//this should fail
            //invoke the method
            Error = AnOrderline.Valid(OrderID, ProductID, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMinLessOne()
        {
            //cretae an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string vraibale to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Quantity = "";
            //invoke the method
            Error = AnOrderline.Valid(OrderID, ProductID, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMin()
        {
            //cretae an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string vraibale to store any error message
            string Error = "";
            //this should pass
            string Quantity = "1";
            //invoke the method
            Error = AnOrderline.Valid(OrderID, ProductID, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //cretae an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string vraibale to store any error message
            string Error = "";
            //this should pass
            string Quantity = "11";
            //invoke the method
            Error = AnOrderline.Valid(OrderID, ProductID, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //cretae an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string vraibale to store any error message
            string Error = "";
            //this should pass
            string Quantity = "111";
            //invoke the method
            Error = AnOrderline.Valid(OrderID, ProductID, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMax()
        {
            //cretae an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string vraibale to store any error message
            string Error = "";
            //this should pass
            string Quantity = "1111";
            //invoke the method
            Error = AnOrderline.Valid(OrderID, ProductID, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //cretae an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string vraibale to store any error message
            string Error = "";
            //this should fail
            string Quantity = "11111";
            //invoke the method
            Error = AnOrderline.Valid(OrderID, ProductID, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMid()
        {
            //cretae an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string vraibale to store any error message
            string Error = "";
            //this should pass
            string Quantity= "11";
            //invoke the method
            Error = AnOrderline.Valid(OrderID, ProductID, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityExtremeMax()
        {
            //cretae an instance of the class we want to create
            clsOrderline AnOrderline = new clsOrderline();
            //string vraibale to store any error message
            string Error = "";
            //this should pass
            string Quantity = "";
            Quantity = Quantity.PadRight(500, '1');//this should fail
            //invoke the method
            Error = AnOrderline.Valid(OrderID, ProductID, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}   




 
