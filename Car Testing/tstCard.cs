using System;
using CarClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;





    namespace Car_Testing
    {

        [TestClass]
        public class tstCard
        {
        public string CardNr  { get; set; }
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
                string CardHolder = "Cezary Szwalbe";
                //assign the data to the property
                ACard.CardHolder = CardHolder;
                //test to see that the values are the same
                Assert.AreEqual(ACard.CardHolder, CardHolder);
            }

            

            [TestMethod]
            public void ValidMethodOK()
            {
                //create an instance of the class we want to create
                clsCard ACard = new clsCard();
                //create a string variable to store the result of the validation
                string Error = "";
                //create some test data to test the method
                string CardNr = "123413241324132";
            string CardHolder = "Ceazry Szwalbe";
            string CardSecurityNumber = "123";
            string ExpireDateYear = "2020";
            string ExpireDateMonth = "11";
            //invoke the method
            Error = ACard.Valid(CardNr, CardHolder, CardSecurityNumber, ExpireDateYear, ExpireDateMonth);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void CardHolderMinLessOne()
            {
                //create an instance of the class we want to create
                clsCard ACard = new clsCard();
                //create a string variable to store the result of the validation
                String Error = "";
            //create some test data to test the method
            string CardNr = "0123456789012345";
            string CardHolder = "Cezary";
            string CardSecurityNumber = "123";
            string ExpireDateYear = "2020";
            string ExpireDateMonth = "11";
            //invoke the method
            Error = ACard.Valid(CardNr,CardHolder,CardSecurityNumber,ExpireDateYear,ExpireDateMonth);
                //test to see that the result is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void CardHolderMinBoundary()
            {
                //create an instance of the class we want to create
                clsCard ACard = new clsCard();
                //create a string variable to store the result of the validation
                String Error = "";
            //create some test data to test the method
            string CardNr = "123413241324132";
            string CardHolder = "CezaryS";
            string CardSecurityNumber = "123";
            string ExpireDateYear = "2020";
            string ExpireDateMonth = "11";
            //invoke the method
            Error = ACard.Valid(CardNr, CardHolder, CardSecurityNumber, ExpireDateYear, ExpireDateMonth);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void CardHolderMinPlusOne()
            {
                //create an instance of the class we want to create
                clsCard ACard = new clsCard();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                string CardHolder = "CezarySz";
            string CardSecurityNumber = "123";
            string ExpireDateYear = "2020";
            string ExpireDateMonth = "11";
            string CardNr = "123413241324132";
            //invoke the method
            Error = ACard.Valid(CardNr, CardHolder, CardSecurityNumber, ExpireDateYear, ExpireDateMonth);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void CardHolderMaxLessOne()
            {
                //create an instance of the class we want to create
                clsCard ACard = new clsCard();
                //create a string variable to store the result of the validation
                String Error = "";
            //create some test data to test the method
            string CardHolder = "Aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            string CardSecurityNumber = "123";
            string ExpireDateYear = "2020";
            string ExpireDateMonth = "11";
            string CardNr = "123413241324132";
            //invoke the method
            Error = ACard.Valid(CardNr, CardHolder, CardSecurityNumber, ExpireDateYear, ExpireDateMonth);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
            }


            [TestMethod]
            public void CardHolderMaxBoundary()
            {
                //create an instance of the class we want to create
                clsCard ACard = new clsCard();
                //create a string variable to store the result of the validation
                String Error = "";
            //create some test data to test the method
            string CardHolder = "123456789012345678901234567890123456";
            string CardSecurityNumber = "123";
            string ExpireDateYear = "2020";
            string ExpireDateMonth = "11";
            string CardNr = "123413241324132";
            //invoke the method
            Error = ACard.Valid(CardNr, CardHolder, CardSecurityNumber, ExpireDateYear, ExpireDateMonth);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void CardHolderMaxPlusOne()
            {
                //create an instance of the class we want to create
                clsCard ACard = new clsCard();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                string CardHolder = "1234567890123456789012345678901234567";
            string CardSecurityNumber = "123";
            string ExpireDateYear = "2020";
            string ExpireDateMonth = "11";
            string CardNr = "1234132413241324";
            //invoke the method
            Error = ACard.Valid(CardNr, CardHolder, CardSecurityNumber, ExpireDateYear, ExpireDateMonth); ;
                //test to see that the result is NOT OK i.e there should be an error message
                Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void CardHolderMid()
            {
                //create an instance of the class we want to create
                clsCard ACard = new clsCard();
                //create a string variable to store the result of the validation
                String Error = "";
            //create some test data to test the method
            string CardHolder = "123456789012345678";
            string CardSecurityNumber = "123";
            string ExpireDateYear = "2020";
            string ExpireDateMonth = "11";
            string CardNr = "123413241324132";
            //invoke the method
            Error = ACard.Valid(CardNr, CardHolder, CardSecurityNumber, ExpireDateYear, ExpireDateMonth);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void CardHolderEtremeMax()
            {
                //create an instance of the class we want to create
                clsCard ACard = new clsCard();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                string CardHolder = "";
            //pad the string with characters
            CardHolder = CardHolder.PadRight(500, 'a');
            
            string CardSecurityNumber = "123";
            string ExpireDateYear = "2020";
            string ExpireDateMonth = "11";
            string CardNr = "123413241324132";
            //invoke the method
            Error = ACard.Valid(CardNr, CardHolder, CardSecurityNumber, ExpireDateYear, ExpireDateMonth);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
            }

        [TestMethod]
        public void CardNumberNoMin()
        {
            //create an instance of the class we want to create
            clsCard ACard = new clsCard();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            string CardHolder = "Cezary AAAAA";
            string CardSecurityNumber = "123";
            string ExpireDateYear = "2020";
            string ExpireDateMonth = "11";
            string CardNr = "123413241324132"; //this should pass
            //invoke the method
            Error = ACard.Valid(CardNr, CardHolder, CardSecurityNumber, ExpireDateYear, ExpireDateMonth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CardNumberNoMax()
        {
            //create an instance of the class we want to create
            clsCard ACard = new clsCard();
            //string variable to store the error message
            string Error = "";
            string CardHolder = "Cezary AAAAA";
            string CardSecurityNumber = "123";
            string ExpireDateYear = "2020";
            string ExpireDateMonth = "11";
            //create some test data to pass to the method
            string CardNr = "123413241324132"; //this should pass
            //invoke the method
            Error = ACard.Valid(CardNr, CardHolder, CardSecurityNumber, ExpireDateYear, ExpireDateMonth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CardNumberNoMaxplusone()
        {
            //create an instance of the class we want to create
            clsCard ACard = new clsCard();
            //string variable to store the error message
            string Error = "";
            string CardHolder = "Cezary AAAAA";
            string CardSecurityNumber = "123";
            string ExpireDateYear = "2020";
            string ExpireDateMonth = "11";
            //create some test data to pass to the method
            string CardNr = "1234132413241324"; //this should pass
            //invoke the method
            Error = ACard.Valid(CardNr, CardHolder, CardSecurityNumber, ExpireDateYear, ExpireDateMonth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CardNumberNoMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsCard ACard = new clsCard();
            //string variable to store the error message
            string Error = "";
            string CardHolder = "Cezary AAAAA";
            string CardSecurityNumber = "123";
            string ExpireDateYear = "2020";
            string ExpireDateMonth = "11";
            //create some test data to pass to the method
            string CardNr = "12341324132413"; //this should pass
            //invoke the method
            Error = ACard.Valid(CardNr, CardHolder, CardSecurityNumber, ExpireDateYear, ExpireDateMonth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CardNumberNoExtremeMax()
        {
            //create an instance of the class we want to create
            clsCard ACard = new clsCard();
            //string variable to store the error message
            string Error = "";
            string CardHolder = "Cezary AAAAA";
            string CardSecurityNumber = "123";
            string ExpireDateYear = "2020";
            string ExpireDateMonth = "11";
            //create some test data to pass to the method
            string CardNr = "8888777799998888"; //this should pass
            CardNr = CardNr.PadRight(500, '1');

            //invoke the method
            Error = ACard.Valid(CardNr, CardHolder, CardSecurityNumber, ExpireDateYear, ExpireDateMonth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CardNumberNoExtremeMin()
        {
            //create an instance of the class we want to create
            clsCard ACard = new clsCard();
            //string variable to store the error message
            string Error = "";
            string CardHolder = "Cezary AAAAA";
            string CardSecurityNumber = "123";
            string ExpireDateYear = "2020";
            string ExpireDateMonth = "11";
            //create some test data to pass to the method
            string CardNr = "8"; //this should pass
            //invoke the method
            Error = ACard.Valid(CardNr, CardHolder, CardSecurityNumber, ExpireDateYear, ExpireDateMonth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
    }

