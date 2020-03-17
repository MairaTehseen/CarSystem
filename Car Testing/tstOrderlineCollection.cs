using System;
using System.Collections.Generic;
using CarClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Car_Testing
{
    [TestClass]
    public class tstOrderlineCollection
    {


        [TestMethod]
        public void InstanceOK()
        {
            //craete an instance of the class we want to create
            clsOrderlineCollection AllOrders = new clsOrderlineCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);

        }
        [TestMethod]
        public void OrderlineListOK()
        {
            //create an instance of the class we want to create
            clsOrderlineCollection AllOrdersLine = new clsOrderlineCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list  of objects
            List<clsOrderline> TestList = new List<clsOrderline>();
            //add an item to the list
            //create the item of test data
            clsOrderline TestItem = new clsOrderline();
            //set its properties
            TestItem.Quantity = 1;
            TestItem.ProductID = 1;
            TestItem.OrderID = 1;
            TestItem.OrderlineID = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrdersLine.OrderlineList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrdersLine.OrderlineList, TestList);

        }
      
        [TestMethod]
        public void ThisOrderLinePropertyOk()
        {
            //create an instance of the class we want to create
            clsOrderlineCollection AllOrderLines = new clsOrderlineCollection();
            //create some test data to assign to the property
            clsOrderline TestOrderLine = new clsOrderline();
            //set the properties of the test object
            TestOrderLine.Quantity = 1;
            TestOrderLine.OrderID = 1;
            TestOrderLine.OrderlineID = 1;
            TestOrderLine.ProductID = 1;
            //assign the data to the property
            AllOrderLines.ThisOrderLine = TestOrderLine;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderLines.ThisOrderLine, TestOrderLine);


        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsOrderlineCollection AllOrderLines = new clsOrderlineCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list  of objects
            List<clsOrderline> TestList = new List<clsOrderline>();
            //add an item to the list
            //create the item of test data
            clsOrderline TestItem = new clsOrderline();
            //set its properties
            TestItem.Quantity = 1;
            TestItem.OrderID = 1;
            TestItem.OrderlineID = 1;
            TestItem.ProductID = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrderLines.OrderlineList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderLines.Count, TestList.Count);
        }
       

        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderlineCollection AllOrderlines = new clsOrderlineCollection();
            //create the item of test data
            clsOrderline TestItem = new clsOrderline();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderlineID = 1;
            TestItem.OrderID = 1;
            TestItem.ProductID = 1;
            TestItem.Quantity = 1;
            //set ThisOrder to the test data
            AllOrderlines.ThisOrderLine = TestItem;
            //add the record
            PrimaryKey = AllOrderlines.Add();
            //set the primary key of the test data
            TestItem.OrderlineID = PrimaryKey;
            //find the record
            AllOrderlines.ThisOrderLine.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrderlines.ThisOrderLine, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderlineCollection AllOrderlines = new clsOrderlineCollection();
            //create the item of test data
            clsOrderline TestItem = new clsOrderline();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.OrderlineID = 1;
            TestItem.OrderID = 1;
            TestItem.ProductID = 1;
            TestItem.Quantity = 1;
            //set ThisOrder to the test data
            AllOrderlines.ThisOrderLine = TestItem;
            //add the record
            PrimaryKey = AllOrderlines.Add();
            //set the primary key of the test data
            TestItem.OrderlineID = PrimaryKey;
            //find the record
            AllOrderlines.ThisOrderLine.Find(PrimaryKey);
            //delete the record
            AllOrderlines.Delete();
            //now find the record
            Boolean Found = AllOrderlines.ThisOrderLine.Find(PrimaryKey);
            //test to see that the records was not found
            Assert.IsFalse(Found);

        }
       
    }
}

