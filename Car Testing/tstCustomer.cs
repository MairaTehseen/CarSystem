using System;
using CarClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Car_Testing
{
    [TestClass]
    public class tstCustomer
    {

        //good test data
        //create some test data to pass to the method
        string CustomerFirstName = "Eliana";
        string CustomerLastName = "Torres";
        string Email = "EliTorres@gmail.com";
        string TelephoneNo = "07957057622";
        string Address1 = "40 Computer Street";
        string Address2 = "Reading";
        string PostCode = "RE9 9KL";
        string CustomerPassword = "abcde";


        [TestMethod]
       public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //asign the data to the property
            ACustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void CustomerFirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Alyssa";
            //assign the data to the property
            ACustomer.CustomerFirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerFirstName, TestData);
        }

        [TestMethod]
        public void CustomerLastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Pagulayan";
            //assign the data to the property
            ACustomer.CustomerLastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerLastName, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "alyssambp@gmail.com";
            //assign the data to the property
            ACustomer.Email = TestData;
            //test to see that the 2 values are the same
            Assert.AreEqual(ACustomer.Email, TestData);
        }

        [TestMethod]
        public void TelephoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "07968746421";
            //assign the data to the property
            ACustomer.TelephoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.TelephoneNo, TestData);
        }

        [TestMethod]
        public void Address1PropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "150 University Street";
            //assign the data to the property
            ACustomer.Address1 = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Address1, TestData);
        }

        [TestMethod]
        public void Address2PropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property
            ACustomer.Address2 = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Address2, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "LE1 5OY";
            //assign the data to the property
            ACustomer.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.PostCode, TestData);
        }

        [TestMethod]
        public void CustomerPasswordOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "abcd";
            //assign the data to the proprety
            ACustomer.CustomerPassword = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerPassword, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean varliable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see that the result is correct.
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the customer ID 
            if (ACustomer.CustomerID != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
                
        }

        [TestMethod]
        public void TestCustomerFirstNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.CustomerFirstName != "Random")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerLastNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.CustomerLastName != "Cezary")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.Email != "randomcezary@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTelephoneNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.TelephoneNo != "07192547261")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddress1Found()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.Address1 != "8 nklfb")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestAddress2Found()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.Address2 != "bdfbfd")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestPostcodeFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.PostCode != "bfkjbk")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerPasswordFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 2;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //check the property
            if (ACustomer.CustomerPassword != "abc")
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
            clsCustomer ACustomer = new clsCustomer();
            //string variable store any error message
            String Error = "";
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerFirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "ab"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMin()
        {
            //create an instanc eof the class we want to create
            clsCustomer Acustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "abc"; //this should pass
            //invoke the method
            Error = Acustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMinPlusOne()
        {
            //create an instanc eof the class we want to create
            clsCustomer Acustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "abcd"; //this should pass
            //invoke the method
            Error = Acustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMid()
        {
            //create an instanc eof the class we want to create
            clsCustomer Acustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "abcdefghij"; //this should pass
            //invoke the method
            Error = Acustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMaxLessOne()
        {
            //create an instanc eof the class we want to create
            clsCustomer Acustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "abcdefghijklmnopqrs"; //this should pass
            //invoke the method
            Error = Acustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMax()
        {
            //create an instanc eof the class we want to create
            clsCustomer Acustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "abcdefghijklmnopqrst"; //this should pass
            //invoke the method
            Error = Acustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMaxPlusOne()
        {
            //create an instanc eof the class we want to create
            clsCustomer Acustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerFirstName = "abcdefghijklmnopqrstu"; //this should pass
            //invoke the method
            Error = Acustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameExtremeMax()
        {
            //create an instanc eof the class we want to create
            clsCustomer Acustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            CustomerFirstName = CustomerFirstName.PadRight(500, 'a'); //this should pass
            //invoke the method
            Error = Acustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void CustomerLastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerLastName = "ab"; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMin()
        {
            //create an instanc eof the class we want to create
            clsCustomer Acustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerLastName = "abc"; //this should pass
            //invoke the method
            Error = Acustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMinPlusOne()
        {
            //create an instanc eof the class we want to create
            clsCustomer Acustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerLastName = "abcd"; //this should pass
            //invoke the method
            Error = Acustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMid()
        {
            //create an instanc eof the class we want to create
            clsCustomer Acustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerLastName = "abcdefghij"; //this should pass
            //invoke the method
            Error = Acustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMaxLessOne()
        {
            //create an instanc eof the class we want to create
            clsCustomer Acustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerLastName = "abcdefghijklmnopqrs"; //this should pass
            //invoke the method
            Error = Acustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMax()
        {
            //create an instanc eof the class we want to create
            clsCustomer Acustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerLastName = "abcdefghijklmnopqrst"; //this should pass
            //invoke the method
            Error = Acustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMaxPlusOne()
        {
            //create an instanc eof the class we want to create
            clsCustomer Acustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerLastName = "abcdefghijklmnopqrstu"; //this should pass
            //invoke the method
            Error = Acustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameExtremeMax()
        {
            //create an instanc eof the class we want to create
            clsCustomer Acustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            CustomerFirstName = CustomerFirstName.PadRight(500, 'a'); //this should pass
            //invoke the method
            Error = Acustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Email = "ab@gmail.com"; //this should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            String Error = "";
            //create some test data to pass to the method
            String Email = "abc@gmail.com"; //this should pass
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            String Error = "";
            //create some test data to pass to the method
            String Email = "abcd@gmail.com"; //this should pass
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            String Error = "";
            //create some test data to pass to the method
            String Email = "abcdefghijklmnopqrstuvwxyzabc@gmail.com"; //this should pass
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            String Error = "";
            //create some test data to pass to the method
            String Email = "abcdefghijklmnopqrstuvwxyzabcd@gmail.com"; //this should pass
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            String Error = "";
            //create some test data to pass to the method
            String Email = "abcdefghijklmnopqrstuvwxyzabcde@gmail.com"; //this should pass
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        /////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void TelephoneNoMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            String Error = "";
            //create some test data to pass to the method
            String TelephoneNo = "07957057622"; //this should pass
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNoMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            String Error = "";
            //create some test data to pass to the method
            String TelephoneNo = "07957058711"; //this should pass
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        /////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void Address1Max()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            String Error = "";
            //create some test data to pass to the method
            Address1 = Address1.PadRight(40, 'a'); //this should pass
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Address1MaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            String Error = "";
            //create some test data to pass to the method
            Address1 = Address1.PadRight(41, 'a'); //this should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        /////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void Address2Max()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            String Error = "";
            //create some test data to pass to the method
            Address2 = Address2.PadRight(20, 'a'); //this should pass
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Address2MaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            String Error = "";
            //create some test data to pass to the method
            Address2 = Address2.PadRight(21, 'a'); //this should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void PostCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            String Error = "";
            //create some test data to pass to the method
            String PostCode = "CB9 9B"; //this should pass
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PostCodeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            String Error = "";
            //create some test data to pass to the method
            String PostCode = "CB9 9BS"; //this should pass
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PostCodeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            String Error = "";
            //create some test data to pass to the method
            String PostCode = "LE12 9BS"; //this should pass
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxPlus()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store the error message
            String Error = "";
            //create some test data to pass to the method
            String PostCode = "LE12 9BSS"; //this should pass
            //invoke the method
            Error = ACustomer.Valid(CustomerFirstName, CustomerLastName, Email, TelephoneNo, Address1, Address2, PostCode, CustomerPassword);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }












    }

}
