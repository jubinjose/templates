using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model = SnackMachine.Logic.NHIbernate.Model;

namespace SnackMachine.Tests
{
    [TestClass]
    public class MSTest1
    {
        [TestMethod]
        public void Cannot_Be_Initialized_With_Negative_Quantity()
        {
            InvalidOperationException ex = Assert.ThrowsException<InvalidOperationException>(() =>
            {
                var money = new Model.Money(0, 1, -1, 1);
            });

            Assert.AreEqual(ex.Message, "Money can't be initialized with negative counts");
        }

        [DataTestMethod]
        [DataRow(1, 3, 4, 10, "$54.35")]
        [DataRow(0, 2, 0, 0, "¢20")]
        public void Money_Displays_Correctly(int fiveCentCount, int tenCentCount, int oneDollarCount, int fiveDollarCount, string result)
        {
            Model.Money money = new Model.Money(fiveCentCount, tenCentCount, oneDollarCount, fiveDollarCount);
            Assert.AreEqual(money.ToString(),result);
        }
    }
}
