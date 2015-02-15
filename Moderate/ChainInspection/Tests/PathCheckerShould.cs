#region Usings

using System.Collections.Generic;
using Application;
using NUnit.Framework;

#endregion

namespace Tests {
    [TestFixture]
    public class PathCheckerShould {
        [Test]
        public void ReturnTrueIfChainHasThreeElements() {
            var pathChecker = new PathChecker();

            var result = pathChecker.IsPathExist(new Dictionary<string, string> {
                                                                                        {"BEGIN", "1"},
                                                                                        {"1", "END"}
                                                                                });

            Assert.That(result, Is.True);
        }

        [Test]
        public void ReturnFalseIfChainHasLoop() {
            var pathChecker = new PathChecker();

            var result = pathChecker.IsPathExist(new Dictionary<string, string> {
                                                                                        {"BEGIN", "3"},
                                                                                        {"3", "4"},
                                                                                        {"4", "3"},
                                                                                        {"2", "END"}
                                                                                });

            Assert.That(result, Is.False);
        }

        [Test]
        public void ReturnFalseIfNotAllElementsAreVisited() {
            var pathChecker = new PathChecker();

            var result = pathChecker.IsPathExist(new Dictionary<string, string> {
                                                                                        {"BEGIN", "3"},
                                                                                        {"3", "4"},
                                                                                        {"4", "END"},
                                                                                        {"2", "2"}
                                                                                });

            Assert.That(result, Is.False);
        }

        [Test]
        public void ReturnFalseIfNotAllElementsAreVisitedAndChainIsUnordered() {
            var pathChecker = new PathChecker();

            var result = pathChecker.IsPathExist(new Dictionary<string, string> {
                                                                                        {"77", "END"},
                                                                                        {"BEGIN", "8"},
                                                                                        {"8", "77"},
                                                                                        {"11", "11"}
                                                                                });

            Assert.That(result, Is.False);
        }

        [Test]
        public void ReturnTrueIfChainIsUnordered() {
            var pathChecker = new PathChecker();

            var result = pathChecker.IsPathExist(new Dictionary<string, string> {
                                                                                        {"77", "END"},
                                                                                        {"BEGIN", "8"},
                                                                                        {"8", "11"},
                                                                                        {"11", "77"}
                                                                                });

            Assert.That(result, Is.True);
        }
    }
}