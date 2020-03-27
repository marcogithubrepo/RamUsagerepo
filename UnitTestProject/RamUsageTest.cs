using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject
{
    [TestClass]
    public class RamUsageTest
    {
        [TestMethod]
        public void UpdateChartCPu()
        {

            //arrange
            var form1 = new RamUsage.Form1();

            //Act
            for(int i = 0; i<1000; i++)
            {
                var result = form1.UpdateChartCpu((float)i, "0.00");
                Assert.IsTrue(result);
            }


            //Assert
           // Assert.IsTrue(result);
        }
    }
}
