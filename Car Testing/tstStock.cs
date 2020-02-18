using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Car_Testing
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock AStock = new clsStock();
            Assert.IsNotNull(AStock);
        }
    }
}
