#region Usings

using Application;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion

namespace Tests {
    [TestClass]
    public class WhenDetermineNumberOf_1_Bits {
        [TestMethod]
        public void Return_0_IfNumberIs_0() {
            var numberOsBits = NumberParser.GetNumberOfOnesIn(0);

            Assert.AreEqual(0, numberOsBits);
        }
        
        [TestMethod]
        public void Return_2_IfNumberIs_10() {
            var numberOsBits = NumberParser.GetNumberOfOnesIn(10);

            Assert.AreEqual(2, numberOsBits);
        }
        
        [TestMethod]
        public void Return_3_IfNumberIs_22() {
            var numberOsBits = NumberParser.GetNumberOfOnesIn(22);

            Assert.AreEqual(3, numberOsBits);
        }
        
        [TestMethod]
        public void Return_3_IfNumberIs_56() {
            var numberOsBits = NumberParser.GetNumberOfOnesIn(56);

            Assert.AreEqual(3, numberOsBits);
        }
    }
}