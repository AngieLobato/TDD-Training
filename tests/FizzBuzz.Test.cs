using NUnit.Framework;

namespace CSharp.Training.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        FizzBuzz FizzBuzz = new FizzBuzz();

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void Multiples3(int num)
        {
            Assert.AreEqual(FizzBuzz.Metodo(num), "Fizz", "Incorrect" + num);
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void Multiples5(int num)
        {
            Assert.AreEqual(FizzBuzz.Metodo(num), "Buzz", "Incorrect" + num);
        }


        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void MultiplesBoth(int num)
        {
            Assert.AreEqual(FizzBuzz.Metodo(num), "FizzBuzz", "Incorrect" + num);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        public void NoMultiples(int num)
        {
            Assert.AreEqual(FizzBuzz.Metodo(num), "NoMultiple", "Incorrect" + num);
        }
    }
}
