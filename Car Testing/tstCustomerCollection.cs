using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CarClasses;

namespace Car_Testing
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerFirstName = "some first name";
            TestItem.CustomerLastName = "some last name";
            TestItem.Email = "random@gmail.com";
            //TestItem.TelephoneNo = 0788992167361;
            TestItem.Address1 = "some address1";
            TestItem.Address2 = "some address2";
            TestItem.PostCode = "LE1 1WE";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

   

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.CustomerFirstName = "some first name";
            TestCustomer.CustomerLastName = "some last name";
            TestCustomer.Email = "random@gmail.com";
            TestCustomer.Address1 = "some address1";
            TestCustomer.Address2 = "some address2";
            TestCustomer.PostCode = "LE1 1WE";
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to seee that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListandCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerFirstName = "some first name";
            TestItem.CustomerLastName = "some last name";
            TestItem.Email = "random@gmail.com";
            TestItem.TelephoneNo = "07957057622";
            TestItem.Address1 = "some address1";
            TestItem.Address2 = "some address2";
            TestItem.PostCode = "LE1 1WE";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

           

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primark key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerID = 17;
            TestItem.CustomerFirstName = "Oliver";
            TestItem.CustomerLastName = "Pagulayan";
            TestItem.Email = "oliverp@gmail.com";
            TestItem.TelephoneNo = "07123456789";
            TestItem.Address1 = "11 Bishops Court";
            TestItem.Address2 = "Haverhill";
            TestItem.PostCode = "CB9 7BS";
            TestItem.CustomerPassword = "xyxy";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an insance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create this item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerID = 25;
            TestItem.CustomerFirstName = "Carl";
            TestItem.CustomerLastName = "Pagulayan";
            TestItem.Email = "carlp@gmail.com";
            TestItem.TelephoneNo = "07123456789";
            TestItem.Address1 = "10 Bishops Court";
            TestItem.Address2 = "Haverhill";
            TestItem.PostCode = "CB9 9BS";
            TestItem.CustomerPassword = "abc";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add teh record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we waqnt to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerID = 21;
            TestItem.CustomerFirstName = "Sophie";
            TestItem.CustomerLastName = "Vergara";
            TestItem.Email = "sv@gmail.com";
            TestItem.TelephoneNo = "07965847361";
            TestItem.Address1 = "123 ABC Lane";
            TestItem.Address2 = "San Jose";
            TestItem.PostCode = "SJ1 98KL";
            TestItem.CustomerPassword = "abc";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //modify the test data
            TestItem.CustomerID = 21;
            TestItem.CustomerFirstName = "Sophie";
            TestItem.CustomerLastName = "Vergara";
            TestItem.Email = "sv@gmail.com";
            TestItem.TelephoneNo = "07965847361";
            TestItem.Address1 = "1 Apple Street";
            TestItem.Address2 = "San Jose";
            TestItem.PostCode = "SJ1 9OP";
            TestItem.CustomerPassword = "yyyy";
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        
     

        [TestMethod]
        public void ReportByCustomerLastNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records)
            FilteredCustomers.ReportByCustomerLastName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByCustomerLastNameNoneFound()
        {
            //create an instance of the filtrered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a customer last name that doesn't exist
            FilteredCustomers.ReportByCustomerLastName("xxx xxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByCustomerLastNameTestDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store the outcome
            Boolean OK = true;
            //apply a customer last name that doesn't exist
            FilteredCustomers.ReportByCustomerLastName("Random");
            //check that the correct number of records are found
            if (FilteredCustomers.Count == 2)
            {
                //check the firest record is ID 1
                if (FilteredCustomers.CustomerList[0].CustomerID != 2)
                {
                    OK = false;
                }

                //check that the first record is ID 20
                if (FilteredCustomers.CustomerList[1].CustomerID != 42)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }





    }

}

