using System;
using CarClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;





    namespace Car_Testing
    {

        [TestClass]
        public class tstCard
        {
        public string CardNr { get; set; }
        public string CardHolder { get; set; }
        public string CardSecurityNumber { get; set; }
        public string ExpireDateYear { get; set; }
        public string ExpireDateMonth { get; set; }

        [TestMethod]
            public void InstanceOK()
            {
                //create an instance of the class we want to create
                clsCard ACard = new clsCard();
                //test to see that it exists
                Assert.IsNotNull(ACard);
            }

            [TestMethod]
            public void CountPropertyOK()
            {
                //create an instance of the class we want to create
                clsCard ACard = new clsCard();
                //create some test data to assign to the property
                string SomeCounty = "Cezary Szwalbe";
                //assign the data to the property
                ACard.CardHolder = SomeCounty;
                //test to see that the values are the same
                Assert.AreEqual(ACard.CardHolder, SomeCounty);
            }

            

            [TestMethod]
            public void ValidMethodOK()
            {
                //create an instance of the class we want to create
                clsCard ACard = new clsCard();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                string CardHolder = "Leicestershire";
            //invoke the method
            Error = ACard.Valid(CardNr, CardHolder, CardSecurityNumber, ExpireDateYear, ExpireDateMonth);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void CountyMinLessOne()
            {
                //create an instance of the class we want to create
                clsCard ACard = new clsCard();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                string SomeCounty = "";
                //invoke the method
                Error = ACard.Valid(CardNr,CardHolder,CardSecurityNumber,ExpireDateYear,ExpireDateMonth);
                //test to see that the result is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void CountyMinBoundary()
            {
                //create an instance of the class we want to create
                clsCard ACard = new clsCard();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                string SomeCounty = "a";
            //invoke the method
            Error = ACard.Valid(CardNr, CardHolder, CardSecurityNumber, ExpireDateYear, ExpireDateMonth);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void CountyMinPlusOne()
            {
                //create an instance of the class we want to create
                clsCard ACard = new clsCard();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                string SomeCounty = "aa";
            //invoke the method
            Error = ACard.Valid(CardNr, CardHolder, CardSecurityNumber, ExpireDateYear, ExpireDateMonth);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void CountyMaxLessOne()
            {
                //create an instance of the class we want to create
                clsCard ACard = new clsCard();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                string SomeCounty = "0123456789012345678901234567890123456789012345678";
            //invoke the method
            Error = ACard.Valid(CardNr, CardHolder, CardSecurityNumber, ExpireDateYear, ExpireDateMonth);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
            }


            [TestMethod]
            public void CountyMaxBoundary()
            {
                //create an instance of the class we want to create
                clsCard ACard = new clsCard();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                string SomeCounty = "01234567890123456789012345678901234567890123456789";
            //invoke the method
            Error = ACard.Valid(CardNr, CardHolder, CardSecurityNumber, ExpireDateYear, ExpireDateMonth);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void CountyMaxPlusOne()
            {
                //create an instance of the class we want to create
                clsCard ACard = new clsCard();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                string SomeCounty = "012345678901234567890123456789012345678901234567890";
            //invoke the method
            Error = ACard.Valid(CardNr, CardHolder, CardSecurityNumber, ExpireDateYear, ExpireDateMonth); ;
                //test to see that the result is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void CountyMid()
            {
                //create an instance of the class we want to create
                clsCard ACard = new clsCard();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                string SomeCounty = "0123456789012345678901234";
            //invoke the method
            Error = ACard.Valid(CardNr, CardHolder, CardSecurityNumber, ExpireDateYear, ExpireDateMonth);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void CountyEtremeMax()
            {
                //create an instance of the class we want to create
                clsCard ACard = new clsCard();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                string SomeCounty = "";
                //pad the string with characters
                SomeCounty = SomeCounty.PadRight(500, 'a');
            //invoke the method
            Error = ACard.Valid(CardNr, CardHolder, CardSecurityNumber, ExpireDateYear, ExpireDateMonth);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
            }

        }
    }

