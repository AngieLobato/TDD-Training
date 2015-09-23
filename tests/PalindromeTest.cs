using NUnit.Framework;

namespace CSharp.Training.Tests
{
    [TestFixture]
    public class PalindromeTest
    {
        Palindrome Obj = new Palindrome();

        [TestCase("In girum imus nocte et consumimur igni")]
        [TestCase("Roma tibi subito motibus ibit amor")]
        [TestCase("civic")]
        public void TruePalenDrome(string text)
        {
            text = text.Replace(" ", "");
            Assert.AreEqual(Obj.IsPalendrome(text), true);
        }

        [TestCase("mensaje")]
        [TestCase("this is a example")]
        public void FalsePalenDrome(string text)
        {
            text = text.Replace(" ", "");
            Assert.AreEqual(Obj.IsPalendrome(text), false, "FAIL --> " + text);
        }

        
    }
}
