using System;
using CarClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;




namespace Car_Testing
{
    [TestClass]
    public class tstAddress
    {

        //good test data
        //create some test data to pass to the method
        string Payment_Customer_Id = "1"; //Payment Customer Id
        string PaymentId = "34"; //PaymentId
        string PaymentOrderId = "3"; //PaymentOrderId
        string PaymentMethod = "2";//PaymentMethod
        string PaymentDate = DateTime.Now.Date.ToString(); //Payment Date


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //test to see that it exists
            Assert.IsNotNull(aPayment);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            aPayment.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aPayment.Active, TestData);
        }

        [TestMethod]
        public void PaymentDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            aPayment.PaymentDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aPayment.PaymentDate, TestData);
        }


        [TestMethod]
        public void AddressNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            aPayment.AddressNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aPayment.AddressNo, TestData);
        }

        [TestMethod]
        public void CountyNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            aPayment.CountyNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aPayment.CountyNo, TestData);
        }

        [TestMethod]
        public void Payment_Customer_IdPropertyOK()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            aPayment.Payment_Customer_Id = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aPayment.Payment_Customer_Id, TestData);
        }

        [TestMethod]
        public void PaymentMethodPropertyOK()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            aPayment.PaymentMethod = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aPayment.PaymentMethod, TestData);
        }

        [TestMethod]
        public void PaymentIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //create some test data to assign to the property
            string TestData = "Some PaymentId";
            //assign the data to the property
            aPayment.PaymentId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aPayment.PaymentId, TestData);
        }

        [TestMethod]
        public void PaymentOrderIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property
            aPayment.PaymentOrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aPayment.PaymentOrderId, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 AddressNo = 1;
            //invoke the method
            Found = aPayment.Find(AddressNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestAddressNoFound()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 34;
            //invoke the method
            Found = aPayment.Find(AddressNo);
            //check the address no
            if (aPayment.AddressNo != 34)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymentIdFound()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 34;
            //invoke the method
            Found = aPayment.Find(AddressNo);
            //check the property
            if (aPayment.PaymentId != "some PaymentId")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymentOrderIdFound()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 34;
            //invoke the method
            Found = aPayment.Find(AddressNo);
            //check the property
            if (aPayment.PaymentOrderId != "some PaymentOrderId")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymentMethodFound()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 34;
            //invoke the method
            Found = aPayment.Find(AddressNo);
            //check the property
            if (aPayment.PaymentMethod != "LE1 1WE")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCountyNoFound()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 34;
            //invoke the method
            Found = aPayment.Find(AddressNo);
            //check the property
            if (aPayment.CountyNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymentDateFound()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 34;
            //invoke the method
            Found = aPayment.Find(AddressNo);
            //check the property
            if (aPayment.PaymentDate != Convert.ToDateTime("20/05/2016"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 34;
            //invoke the method
            Found = aPayment.Find(AddressNo);
            //check the property
            if (aPayment.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Payment_Customer_IdMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Payment_Customer_Id = ""; //this should trigger an error
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Payment_Customer_IdMin()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Payment_Customer_Id = "a"; //this should be ok
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Payment_Customer_IdMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Payment_Customer_Id = "aa"; //this should be ok
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Payment_Customer_IdMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Payment_Customer_Id = "aaaaa"; //this should be ok
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Payment_Customer_IdMax()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Payment_Customer_Id = "1"; //this should be ok
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Payment_Customer_IdMid()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Payment_Customer_Id = "aaa"; //this should be ok
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Payment_Customer_IdMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Payment_Customer_Id = "aaaaaaa"; //this should fail
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Payment_Customer_IdExtremeMax()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Payment_Customer_Id = "";
            Payment_Customer_Id = Payment_Customer_Id.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PaymentDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string PaymentDate = TestDate.ToString();
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PaymentDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string PaymentDate = TestDate.ToString();
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentDateMin()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string PaymentDate = TestDate.ToString();
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string PaymentDate = TestDate.ToString();
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string PaymentDate = TestDate.ToString();
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentDateInvalidData()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //set the PaymentDate to a non date value
            string PaymentDate = "this is not a date!";
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentMethodMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PaymentMethod = "";
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentMethodMin()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PaymentMethod = "a";
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentMethodMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PaymentMethod = "aa";
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentMethodMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PaymentMethod = "aaaaaaaa";
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentMethodMax()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PaymentMethod = "aaaaaaaaa";
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentMethodMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PaymentMethod = "aaaaaaaaaa";
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentMethodMid()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PaymentMethod = "aaaa";
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PaymentIdMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PaymentId = "";
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentIdMin()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PaymentId = "a";
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentIdMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PaymentId = "aa";
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentIdMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PaymentId = "";
            PaymentId = PaymentId.PadRight(49, 'a');
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PaymentIdMax()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PaymentId = "";
            PaymentId = PaymentId.PadRight(50, 'a');
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentIdMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PaymentId = "";
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentIdMid()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PaymentId = "";
            PaymentId = PaymentId.PadRight(25, 'a');
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PaymentOrderIdMinLessOne()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PaymentOrderId = "";
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PaymentOrderIdMin()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PaymentOrderId = "a";
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentOrderIdMinPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PaymentOrderId = "aa";
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PaymentOrderIdMaxLessOne()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PaymentOrderId = "";
            PaymentOrderId = PaymentOrderId.PadRight(49, 'a');
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentOrderIdMax()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PaymentOrderId = "";
            PaymentOrderId = PaymentOrderId.PadRight(50, 'a');
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PaymentOrderIdMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string PaymentOrderId = "";
            PaymentOrderId = PaymentOrderId.PadRight(51, 'a');
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PaymentOrderIdMid()
        {
            //create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PaymentOrderId = "";
            PaymentOrderId = PaymentOrderId.PadRight(25, 'a');
            //invoke the method
            Error = aPayment.Valid(Payment_Customer_Id, PaymentId, PaymentOrderId, PaymentMethod, PaymentDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
