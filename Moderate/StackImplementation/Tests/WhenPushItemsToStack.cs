#region Usings

using Application;
using NUnit.Framework;

#endregion

namespace Tests {
    [TestFixture]
    public class WhenPushItemsToStack {
        [Test]
        public void CanPushSingleItem() {
            var stack = new StackOfIntegers();

            stack.Push(1);

            Assert.That(stack.Pop(), Is.EqualTo(1));
        }

        [Test]
        public void TwoItemsAreOrderedBasedOnLifo() {
            var stack = new StackOfIntegers();

            stack.Push(1);
            stack.Push(2);

            Assert.That(stack.Pop(), Is.EqualTo(2));
            Assert.That(stack.Pop(), Is.EqualTo(1));
        }

        [Test]
        public void StackIsNotEmptyIfElementIsPushed()
        {
            var stack = new StackOfIntegers();
            stack.Push(1);

            Assert.That(stack.IsEmpty, Is.False);
        }
    }
}