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
            TestItem.CardNr = 945634563456345;
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
            Int32 SomeCount = AllCards.Count;
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
            TestItem.CardNr = 945634563456456;
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
            int pair = AllCards.Count;


            Assert.AreEqual(AllCards.Count, pair);
        }
        [TestMethod]
        public void AddMethodOK()
        {

            clsCardsCollection AllCards = new clsCardsCollection();

            clsCard TestItem = new clsCard();

            double PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.CardNr = 945634534563456;
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
        [TestMethod]
        public void DeleteMethodOK()
        {

            clsCardsCollection AllCards = new clsCardsCollection();

            clsCard TestItem = new clsCard();

            double PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.CardNr = 945345634563456;
            TestItem.CardHolder = "Cezary Szwalbe";
            TestItem.CardSecurityNumber = 123;
            TestItem.ExpireDateYear = DateTime.Now.Year;
            TestItem.ExpireDateMonth = DateTime.Now.Month;

            AllCards.ThisCard = TestItem;
            PrimaryKey = AllCards.Add();
            TestItem.CardNr = PrimaryKey;
            AllCards.ThisCard.Find(PrimaryKey);
            AllCards.Delete();

            Boolean Found =  AllCards.ThisCard.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void FindMethodOK()
        {

            clsCardsCollection AllCards = new clsCardsCollection();

            Boolean Found = false;
            Int32 CardNr = 1;
            Found = AllCards.Find(CardNr);

            Assert.IsTrue(Found);
        }
        


    }
}
