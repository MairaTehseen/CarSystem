using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Car_Testing
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsStaff AnStaff = new clsStaff();
            //test to see that it exists 
            Assert.IsNotNull(AnStaff);
        }
    }
}
