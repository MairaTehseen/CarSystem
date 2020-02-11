using System;
using CarClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Car_Testing
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance oif the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerFirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string SomeCustomerFirst = "Alyssa";
            //assign the data to the property
            ACustomer.Customer = SomeCustomerFirst;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Customer, SomeCustomerFirst);
        }

        [TestMethod]
        public void CustomerLastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string SomeCustomerLast = "Pagulayan";
            //assign the data to the property
            ACustomer.Customer = SomeCustomerLast;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Customer, SomeCustomerLast);
        }

        //[TestMethod]
        //public void CustomerEmailPropertyOK()
        //{
        //create an instance of the class we want to create
        //  clsCustomer ACustomer = new clsCustomer();
        //create some test data to assign to the property

        //}

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 CustomerID = 1;
            //assign the data to the property
            ACustomer.CustomerID = CustomerID;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, CustomerID);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to store the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCustomerFirst = "Oliver";
            string SomeCustomerLast = "Martin";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerFirst, SomeCustomerLast);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to stre the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCustomerFirst = "ab";
            string SomeCustomerLast = "abc";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerFirst, SomeCustomerLast);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMinBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to stre the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCustomerFirst = "abc";
            string SomeCustomerLast = "abc";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerFirst, SomeCustomerLast);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMaxBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to stre the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCustomerFirst = "abcdefghijklmnopqrst";
            string SomeCustomerLast = "abc";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerFirst, SomeCustomerLast);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerFirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to stre the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCustomerFirst = "abcdefghijklmnopqrstu";
            string SomeCustomerLast = "abc";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerFirst, SomeCustomerLast);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to stre the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCustomerFirst = "abc";
            string SomeCustomerLast = "ab";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerFirst, SomeCustomerLast);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMinBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to stre the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCustomerFirst = "abc";
            string SomeCustomerLast = "abc";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerFirst, SomeCustomerLast);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMaxBoundary()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to stre the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCustomerFirst = "abc";
            string SomeCustomerLast = "abcdefghijklmnopqrst";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerFirst, SomeCustomerLast);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerLastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create a string variable to stre the result of the validation
            String Error = "";
            //create some test data to test the method
            string SomeCustomerFirst = "abc";
            string SomeCustomerLast = "abcdefghijklmnopqrstu";
            //invoke the method
            Error = ACustomer.Valid(SomeCustomerFirst, SomeCustomerLast);
            //test to see that the result is OK i.e. there was no error message returned
            Assert.AreNotEqual(Error, "");
        }
    }
}
