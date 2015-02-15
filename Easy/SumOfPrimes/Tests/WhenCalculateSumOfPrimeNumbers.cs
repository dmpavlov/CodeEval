#region Usings

using Application;
using NUnit.Framework;

#endregion

namespace Tests {
    [TestFixture]
    public class WhenCalculateSumOfPrimeNumbers {
        [Test]
        public void ReturnFirstFivePrimeNumbers() {
            var primeNumbersFinder = new PrimeNumbersFinder(5);

            var primeNumbers = primeNumbersFinder.Items;

            Assert.AreEqual(new[] {2, 3, 5, 7, 11}, primeNumbers);
        }
    }
}