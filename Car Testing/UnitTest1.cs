using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Car_Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCars AnCars = new clsCars();
            Assert.IsNotNull(AnCars);
        }
    }
}
