#region Usings

using Application;
using NUnit.Framework;

#endregion

namespace Tests {
    [TestFixture]
    public class WhenInspectChain {
        [Test]
        public void Return_BAD_IfInputIsEmpty() {
            var chainInspector = new ChainInspector();

            var result = chainInspector.InspectChain("");

            Assert.AreEqual("BAD", result);
        }
        
        [Test]
        public void Return_GOOD_IfInputIsBeginEnd() {
            var chainInspector = new ChainInspector();

            var result = chainInspector.InspectChain("BEGIN-END");

            Assert.AreEqual("GOOD", result);
        }
        
        [Test]
        public void Return_BAD_IfInputDoesNotContainBegin() {
            var chainInspector = new ChainInspector();

            var result = chainInspector.InspectChain("1-END");

            Assert.AreEqual("BAD", result);
        }
        
        [Test]
        public void Return_BAD_IfInputDoesNotContainEnd() {
            var chainInspector = new ChainInspector();

            var result = chainInspector.InspectChain("BEGIN-1");

            Assert.AreEqual("BAD", result);
        }
        
        [Test]
        public void Return_GOOD_IfInputHasBeginEndPath() {
            var chainInspector = new ChainInspector();

            var result = chainInspector.InspectChain("BEGIN-3;4-3;3-4;2-END");

            Assert.AreEqual("BAD", result);
        }
    }
}