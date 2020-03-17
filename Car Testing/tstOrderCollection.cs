using System;
using CarClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Car_Testing
{
    [TestClass]
    public class tstOrderCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            //craete an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);

        }
        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list  of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.OrderID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Price = 1.50;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);

        }
        //[TestMethod]
        //public void CountPropertyOK()
        // {
        //create an instance of the class we want to create
        //clsOrderCollection AllOrders = new clsOrderCollection();
        //create some test data to assign to the property
        //Int32 SomeCount = 2;
        //assign the data to the propetry
        //AllOrders.Count = SomeCount;
        //test to see that the two values are the same
        //Assert.AreEqual(AllOrders.Count, SomeCount);
        //}
        [TestMethod]
        public void ThisOrderPropertyOk()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            //set the properties of the test object
            TestOrder.CustomerID = 1;
            TestOrder.OrderID = 1;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.Price = 1.50;
            //assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);


        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list  of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.OrderID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Price = 1.50;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.OrderID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Price = 1.50;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.OrderID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Price = 1.50;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see that the records was not found
            Assert.IsFalse(Found);

        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.OrderID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Price = 1.50;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //modify the test data
            TestItem.CustomerID = 1;
            TestItem.OrderID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.Price = 1.50;
            //set the rcord based on the new test data
            AllOrders.ThisOrder = TestItem;
            //update the record
            AllOrders.update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see ThisOrder matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }
        [TestMethod]
        public void ReportByCustomerIDMethodOk()
        {
            //create an instance of the class containing unfiltered results
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create an instance of the filtered data
            clsOrderCollection FilterOrders = new clsOrderCollection();
            //apply a blank string (should return all rceords);
            FilterOrders.ReportByCustomerID("xxx xxx");
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, FilterOrders.Count);
        }
        [TestMethod]
        public void ReportByCustomerIDTestDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            Boolean Ok = true;
            FilteredOrders.ReportByCustomerID("yyy yyy");
            if (FilteredOrders.Count == 2)
            {
                if (FilteredOrders.OrderList[0].OrderID != 5)
                {
                    Ok = false;
                }
                if (FilteredOrders.OrderList[1].OrderID != 6)
                {
                    Ok = false;
                }
            }
            else
            {
                Ok = false;
            }
            //test to see that there are no records
            Assert.IsTrue(Ok);
        }
    }
}
      

