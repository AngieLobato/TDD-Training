namespace CSharp.Training
{
    public class Palindrome
    {
        public bool IsPalendrome(string text)
        {
            int min = 0;
            int max = text.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = text[min];
                char b = text[max];

                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}
