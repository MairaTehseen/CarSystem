using System;
using CarClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Car_Testing
{
    [TestClass]
    public class tstCards
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCards acard = new clsCards();

            Assert.IsNotNull(acard);
        }
    }
}
