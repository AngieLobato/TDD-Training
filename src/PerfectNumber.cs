using System.Runtime.InteropServices;

namespace CSharp.Training
{
    public class PerfectNumberExtention
    {
        public bool NumbersTest(int num)
        {
            var sum = 0;
            for (var i = 1; i < num; i++)
            {
                if (num % i == 0)
                    sum += i;
            }
            return sum == num;
        }
    }
}
