using System;
using CarClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;





    namespace Car_Testing
    {

        [TestClass]
        public class tstAccount
        {
        public double AccountNr { get; set; }
        public string AccountBank { get; set; }
        public string AccountHolder { get; set; }








        [TestMethod]
            public void InstanceOK()
            {
                //create an instance of the class we want to create
                clsAccount AnAccount = new clsAccount();
                //test to see that it exists
                Assert.IsNotNull(AnAccount);
            }

            [TestMethod]
            public void CountPropertyOK()
            {
                //create an instance of the class we want to create
                clsAccount AnAccount = new clsAccount();
                //create some test data to assign to the property
                string AccountHolder = "Cezary Szwalbe";
                //assign the data to the property
                AnAccount.AccountHolder = AccountHolder;
                //test to see that the values are the same
                Assert.AreEqual(AnAccount.AccountHolder, AccountHolder);
            }

            

            [TestMethod]
            public void ValidMethodOK()
            {
                //create an instance of the class we want to create
                clsAccount AnAccount = new clsAccount();
                //create a string variable to store the result of the validation
                string Error = "";
                //create some test data to test the method
                double AccountNr = 8768945;
            string AccountHolder = "Ceazry Szwalbe";
            string AccountBank = "Lloyds";
            //invoke the method
            Error = AnAccount.Valid(AccountHolder,AccountBank,AccountNr);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void AccountHolderMinLessOne()
            {
                //create an instance of the class we want to create
                clsAccount AnAccount = new clsAccount();
                //create a string variable to store the result of the validation
                String Error = "";
            //create some test data to test the method
            double AccountNr = 888877776666555;
            string AccountHolder = "popopo";
            string AccountBank = "Lloyds";
            //invoke the method
            Error = AnAccount.Valid(AccountHolder, AccountBank, AccountNr);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void AccountHolderMinBoundary()
            {
                //create an instance of the class we want to create
                clsAccount AnAccount = new clsAccount();
                //create a string variable to store the result of the validation
                String Error = "";
            //create some test data to test the method
            double AccountNr = 8768945;
            string AccountHolder = "1234567";
            string AccountBank = "Lloyds";
            //invoke the method
            Error = AnAccount.Valid(AccountHolder, AccountBank, AccountNr);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void AccountHolderMinPlusOne()
            {
                //create an instance of the class we want to create
                clsAccount AnAccount = new clsAccount();
                //create a string variable to store the result of the validation
                String Error = "";
            //create some test data to test the method
            double AccountNr = 8768945;
            string AccountHolder = "12345678";
            string AccountBank = "Lloyds";
            //invoke the method
            Error = AnAccount.Valid(AccountHolder, AccountBank, AccountNr);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void AccountHolderMaxLessOne()
            {
                //create an instance of the class we want to create
                clsAccount AnAccount = new clsAccount();
                //create a string variable to store the result of the validation
                String Error = "";
            //create some test data to test the method
            double AccountNr = 8768945;
            string AccountHolder = "12345678901234567890123456789012345";
            string AccountBank = "Lloyds";
            //invoke the method
            Error = AnAccount.Valid(AccountHolder, AccountBank, AccountNr);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
            }


            [TestMethod]
            public void AccountHolderMaxBoundary()
            {
                //create an instance of the class we want to create
                clsAccount AnAccount = new clsAccount();
                //create a string variable to store the result of the validation
                String Error = "";
            //create some test data to test the method
            double AccountNr = 8768945;
            string AccountHolder = "123456789012345678901234567890123456";
            string AccountBank = "Lloyds";
            //invoke the method
            Error = AnAccount.Valid(AccountHolder, AccountBank, AccountNr);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void AccountHolderMaxPlusOne()
            {
                //create an instance of the class we want to create
                clsAccount AnAccount = new clsAccount();
                //create a string variable to store the result of the validation
                String Error = "";
            //create some test data to test the method
            double AccountNr = 8768945;
            string AccountHolder = "1234567890123456789012345678901234567";
            string AccountBank = "Lloyds";
            //invoke the method
            Error = AnAccount.Valid(AccountHolder, AccountBank, AccountNr);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
            }

            [TestMethod]
            public void AccountHolderMid()
            {
                //create an instance of the class we want to create
                clsAccount AnAccount = new clsAccount();
                //create a string variable to store the result of the validation
                String Error = "";
            //create some test data to test the method
            double AccountNr = 8768945;
            string AccountHolder = "Ceazry Szwalbe";
            string AccountBank = "Lloyds";
            //invoke the method
            Error = AnAccount.Valid(AccountHolder, AccountBank, AccountNr);
            //test to see that the result is OK i.e there was no error message returned
            Assert.AreEqual(Error, "");
            }

            [TestMethod]
            public void AccountHolderEtremeMax()
            {
                //create an instance of the class we want to create
                clsAccount AnAccount = new clsAccount();
                //create a string variable to store the result of the validation
                String Error = "";
                //create some test data to test the method
                string AccountHolder = "";
            //pad the string with characters
            AccountHolder = AccountHolder.PadRight(500, 'a');

            double AccountNr = 8768945;
            
            string AccountBank = "Lloyds";
            //invoke the method
            Error = AnAccount.Valid(AccountHolder, AccountBank, AccountNr);
            //test to see that the result is NOT OK i.e there should be an error message
            Assert.AreNotEqual(Error, "");
            }

        [TestMethod]
        public void AccountNumberNoMin()
        {
            //create an instance of the class we want to create
            clsAccount AnAccount = new clsAccount();
            //string variable to store the error message
            string Error = "";
            //create some test data to pass to the method
            double AccountNr = 1000000;
            string AccountHolder = "Ceazry Szwalbe";
            string AccountBank = "Lloyds";
            //invoke the method
            Error = AnAccount.Valid(AccountHolder, AccountBank, AccountNr);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountNumberNoMax()
        {
            //create an instance of the class we want to create
            clsAccount AnAccount = new clsAccount();
            //string variable to store the error message
            string Error = "";
            double AccountNr = 9999999;
            string AccountHolder = "Ceazry Szwalbe";
            string AccountBank = "Lloyds";
            //create some test data to pass to the method
            
            //invoke the method
            Error = AnAccount.Valid(AccountHolder, AccountBank, AccountNr);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AccountNumberNoMaxplusone()
        {
            //create an instance of the class we want to create
            clsAccount AnAccount = new clsAccount();
            //string variable to store the error message
            string Error = "";
            double AccountNr = 10000000;
            string AccountHolder = "Ceazry Szwalbe";
            string AccountBank = "Lloyds";
            //invoke the method
            Error = AnAccount.Valid(AccountHolder, AccountBank, AccountNr);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AccountNumberNoMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsAccount AnAccount = new clsAccount();
            //string variable to store the error message
            string Error = "";
            double AccountNr = 9999998;
            string AccountHolder = "Ceazry Szwalbe";
            string AccountBank = "Lloyds";
            //create some test data to pass to the method
            
            Error = AnAccount.Valid(AccountHolder, AccountBank, AccountNr);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AccountNumberNoExtremeMax()
        {
            //create an instance of the class we want to create
            clsAccount AnAccount = new clsAccount();
            //string variable to store the error message
            string Error = "";
            double AccountNr = 9999999999999999999;
            string AccountHolder = "Ceazry Szwalbe";
            string AccountBank = "Lloyds";
            //create some test data to pass to the method
            
            

            //invoke the method
            Error = AnAccount.Valid(AccountHolder, AccountBank, AccountNr);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AccountNumberNoExtremeMin()
        {
            //create an instance of the class we want to create
            clsAccount AnAccount = new clsAccount();
            //string variable to store the error message
            string Error = "";
            double AccountNr = -99999999999;
            string AccountHolder = "Ceazry Szwalbe";
            string AccountBank = "Lloyds";
            //invoke the method
            Error = AnAccount.Valid(AccountHolder, AccountBank, AccountNr);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
    }

