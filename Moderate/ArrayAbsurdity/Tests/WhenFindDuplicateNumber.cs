#region Usings

using Application;
using NUnit.Framework;

#endregion

namespace Tests {
    [TestFixture]
    public class WhenFindDuplicateNumber {
        [Test]
        public void ReturnFirstNumberIfArrayLengthIsTwo() {
            var duplicatedNumber = DuplicatesFinder.Find("2;1,1");

            Assert.AreEqual(1, duplicatedNumber);
        }

        [Test]
        public void Return_0_AsDuplicate() {
            var duplicatedNumber = DuplicatesFinder.Find("5;0,1,2,3,0");

            Assert.AreEqual(0, duplicatedNumber);
        }
        
        [Test]
        public void Return_4_AsDuplicate() {
            var duplicatedNumber = DuplicatesFinder.Find("20;0,1,10,3,2,4,5,7,6,8,11,9,15,12,13,4,16,18,17,14");

            Assert.AreEqual(4, duplicatedNumber);
        }
    }
}