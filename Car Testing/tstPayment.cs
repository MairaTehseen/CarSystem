using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Car_Testing
{
    [TestClass]
    public class tstPayment
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsPayment aPayment = new clsPayment();
            Assert.IsNotNull(aPayment);
        }
    }
}
