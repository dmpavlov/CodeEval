#region Usings

using System;
using System.Collections.Generic;
using Application;
using NUnit.Framework;

#endregion

namespace Tests {
    [TestFixture]
    public class HexToDecimalConverterShould {
        [Test]
        public void Return_0_IfInputIs_0() {
            var converter = new HexToDecimalConverter();

            var result = converter.Convert("0");

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Return_1_IfInputIs_1() {
            var converter = new HexToDecimalConverter();

            var result = converter.Convert("1");

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Return_2_IfInputIs_2() {
            var converter = new HexToDecimalConverter();

            var result = converter.Convert("1");

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Return_3_IfInputIs_3() {
            var converter = new HexToDecimalConverter();

            var result = converter.Convert("3");

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Return_10_IfInputIs_a() {
            var converter = new HexToDecimalConverter();

            var result = converter.Convert("a");

            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void Return_11_IfInputIs_b() {
            var converter = new HexToDecimalConverter();

            var result = converter.Convert("b");

            Assert.That(result, Is.EqualTo(11));
        }

        [Test]
        public void Return_15_IfInputIs_f() {
            var converter = new HexToDecimalConverter();

            var result = converter.Convert("f");

            Assert.That(result, Is.EqualTo(15));
        }

        [Test]
        public void Return_255_IfInputIs_ff() {
            var converter = new HexToDecimalConverter();

            var result = converter.Convert("ff");

            Assert.That(result, Is.EqualTo(255));
        }
        
        [Test]
        public void Return_159_IfInputIs_9f() {
            var converter = new HexToDecimalConverter();

            var result = converter.Convert("9f");

            Assert.That(result, Is.EqualTo(159));
        }
        
        [Test]
        public void Return_17_IfInputIs_11() {
            var converter = new HexToDecimalConverter();

            var result = converter.Convert("9f");

            Assert.That(result, Is.EqualTo(159));
        }
    }
}