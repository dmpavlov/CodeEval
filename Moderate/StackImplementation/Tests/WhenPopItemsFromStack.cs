#region Usings

using System;
using Application;
using NUnit.Framework;

#endregion

namespace Tests {
    [TestFixture]
    public class WhenPopItemsFromStack {
        [Test]
        public void PopEmptyStackFailsWithException() {
            var stack = new StackOfIntegers();

            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Test]
        public void CanPopEveryAlternateNumber() {
            var stack = new StackOfIntegers();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            var firstItem = stack.Pop();
            stack.Pop();
            var thirdItem = stack.Pop();
            stack.Pop();

            Assert.That(new[] {firstItem, thirdItem}, Is.EqualTo(new[] {4, 2}));
        }

        [Test]
        public void StackIsEmptyIfLastElementPopped() {
            var stack = new StackOfIntegers();
            stack.Push(1);

            stack.Pop();

            Assert.That(stack.IsEmpty, Is.True);
        }
    }
}