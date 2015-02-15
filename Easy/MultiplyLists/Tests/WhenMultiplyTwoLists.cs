#region Usings

using Application;
using NUnit.Framework;

#endregion

namespace Tests {
    [TestFixture]
    public class WhenMultiplyTwoLists {
        [Test]
        public void CanParseStringInput() {
            var listMultiplier = new ListMultiplier();

            listMultiplier.Multiply("1 2 3 | 4 5 6");

            CollectionAssert.AreEquivalent(new[] {1, 2, 3}, listMultiplier.FirstList);
            CollectionAssert.AreEquivalent(new[] {4, 5, 6}, listMultiplier.SecondList);
        }

        [Test]
        public void ReturnMultipliedListWithOneItem() {
            var listMultiplier = new ListMultiplier();

            var result = listMultiplier.Multiply("5 | 8");

            Assert.AreEqual(5 * 8, result[0]);
        }

        [Test]
        public void ReturnMultipliedListWithThreeItems() {
            var listMultiplier = new ListMultiplier();

            var result = listMultiplier.Multiply("1 2 3 | 4 5 6");

            Assert.AreEqual(1 * 4, result[0]);
            Assert.AreEqual(2 * 5, result[1]);
            Assert.AreEqual(3 * 6, result[2]);
        }
    }
}