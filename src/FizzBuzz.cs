
namespace CSharp.Training
{
    public class FizzBuzz
    {
        public string Metodo(int num)
        {
            var x = "Fizz";
            if (num % 3 == 0) { x = "Fizz"; }
            if (num % 5 == 0 && num % 3 != 0) { x = "Buzz"; }
            if (num % 5 == 0 && num % 3 == 0) { x += "Buzz"; }
            if (num % 5 != 0 && num % 3 != 0) { x = "NoMultiple"; }
            return x;
        }
    }
}
