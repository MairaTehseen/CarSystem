using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Car_Testing
{
    [TestClass]
    public class tstPaymentCardsCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsPaymentCardsCollection Card1 = new clsPaymentCardsCollection() ;
            Assert.IsNotNull(Card1);
        }
    }
}
