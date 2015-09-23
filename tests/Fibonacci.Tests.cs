using NUnit.Framework;

namespace CSharp.Training.Tests
{
    [TestFixture]
    public class FibonacciTests
    {
        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(4, 3)]
        [TestCase(5, 5)]
        [TestCase(6, 8)]
        [TestCase(7, 13)]
        [TestCase(8, 21)]
        [TestCase(9, 34)]
        [TestCase(11, 89)]
        [TestCase(12, 144)]
        [TestCase(13, 233)]
        [TestCase(14, 377)]
        [TestCase(15, 610)]
        public void FibanocciSequencetest(int index, int value)
        {
            Assert.AreEqual(value, ValueFibanocci(index));
        }

        private int ValueFibanocci(int index)
        {
            return new Fibonacci().Sequence(index + 1)[index];
        }
    }

   
}
