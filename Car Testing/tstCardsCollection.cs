using System;
using CarClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Car_Testing
{
    [TestClass]
    public class tstCardsCollection
    {
        public clsCard TestCard { get; set; }

       

        [TestMethod]
        public void InstanceOK()
        {
            clsCardsCollection acard = new clsCardsCollection();

            Assert.IsNotNull(acard);
        }
        [TestMethod]
        public void CardsListOK()
        {
            clsCardsCollection AllCards = new clsCardsCollection();
            List<clsCard> TestList = new List<clsCard>();
            clsCard TestItem = new clsCard();
            TestItem.Active = true;
            TestItem.CardNr = 9456345634563456;
            TestItem.CardHolder = "Cezary Szwalbe";
            TestItem.CardSecurityNumber = 123;
            TestItem.ExpireDateYear = DateTime.Now.Year;
            TestItem.ExpireDateMonth = DateTime.Now.Month;
            TestList.Add(TestItem);
            AllCards.CardsList = TestList;
            Assert.AreEqual(AllCards.CardsList, TestList);
        }
        [TestMethod]
        public void CountCardsOK()
        {
            clsCardsCollection AllCards = new clsCardsCollection();
            Int32 SomeCount = 2;
            AllCards.Count = SomeCount;
            Assert.AreEqual(AllCards.Count, SomeCount);
        }
        [TestMethod]
        public void ThisCardPropertyOK()
        {
            clsCardsCollection AllCards = new clsCardsCollection();
           
            clsCard TestItem = new clsCard();
            TestItem.Active = true;
            TestItem.CardNr = 9456345634563456;
            TestItem.CardHolder = "Cezary Szwalbe";
            TestItem.CardSecurityNumber = 123;
            TestItem.ExpireDateYear = DateTime.Now.Year;
            TestItem.ExpireDateMonth = DateTime.Now.Month;
            
            AllCards.ThisCard = TestCard;

            Assert.AreEqual(AllCards.ThisCard, TestCard);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsCardsCollection AllCards = new clsCardsCollection();
            List<clsCard> TestList = new List<clsCard>();
            clsCard TestItem = new clsCard();

            TestItem.Active = true;
            TestItem.CardNr = 9456345634563456;
            TestItem.CardHolder = "Cezary Szwalbe";
            TestItem.CardSecurityNumber = 123;
            TestItem.ExpireDateYear = DateTime.Now.Year;
            TestItem.ExpireDateMonth = DateTime.Now.Month;

            TestList.Add(TestItem);

            AllCards.CardsList = TestList;

            Assert.AreEqual(AllCards.Count, TestList.Count);
        }
        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsCardsCollection AllCards = new clsCardsCollection();
            
            
            Assert.AreEqual(AllCards.Count, 2);
        }
        [TestMethod]
        public void AddMethodOK()
        {

            clsCardsCollection AllCards = new clsCardsCollection();

            clsCard TestItem = new clsCard();

            double PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.CardNr = 9456345634563456;
            TestItem.CardHolder = "Cezary Szwalbe";
            TestItem.CardSecurityNumber = 123;
            TestItem.ExpireDateYear = DateTime.Now.Year;
            TestItem.ExpireDateMonth = DateTime.Now.Month;

            AllCards.ThisCard = TestItem;
            PrimaryKey = AllCards.Add();
            TestItem.CardNr = PrimaryKey;
            AllCards.ThisCard.Find(PrimaryKey);

            Assert.AreEqual(AllCards.ThisCard, TestItem);
        }
    }
}
