using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;


namespace TechnologyTests
{
    [TestClass]
    class ComputerTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Computer computer = new Computer();
            computer.EnergyConsumption = 75;
            Assert.AreEqual(219, computer.EneryPerYear(8), .001);
        }
    }
}
