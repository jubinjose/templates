using NUnit.Framework;
using Model = SnackMachine.Logic.NHIbernate.Model;
using System;

namespace SnackMachine.Tests
{
    

    [TestFixture]
    public class NunitTest1
    {
        [Test]
        public void Cannot_Be_Initialized_With_Negative_Quantity()
        {
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() =>
            {
                var money = new Model.Money(0, 1, -1, 1);
            });

            Assert.That(ex.Message, Is.EqualTo("Money can't be initialized with negative counts"));
        }

        [TestCase(1, 3, 4, 10, "$54.35" )]
        [TestCase(0, 2, 0, 0, "¢20")]
        public void Money_Displays_Correctly(int fiveCentCount, int tenCentCount, int oneDollarCount, int fiveDollarCount, string result)
        {
            Model.Money money = new Model.Money(fiveCentCount, tenCentCount, oneDollarCount, fiveDollarCount);
            Assert.That(money.ToString(), Is.EqualTo(result));
        }
    }
}