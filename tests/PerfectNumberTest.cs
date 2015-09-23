using NUnit.Framework;

namespace CSharp.Training.Tests
{
    [TestFixture]
    public class PerfectNumberTest
    {
        PerfectNumberExtention Number = new PerfectNumberExtention();

        [Test]
        [TestCase(6)]
        [TestCase(28)]
        [TestCase(496)]
        [TestCase(8128)]
        public void IsPerfect(int x)
        {
            Assert.AreEqual(true, Number.NumbersTest(x), "false" + x);
        }
        
        [TestCase(5)]
        [TestCase(27)]
        [TestCase(400)]
        [TestCase(4586)]
        public void IsntPerfect(int x)
        {
            Assert.AreEqual(false, Number.NumbersTest(x), "false" + x);
        }
    }
}

