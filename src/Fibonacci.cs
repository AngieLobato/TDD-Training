namespace CSharp.Training
{
    public class Fibonacci
    {
        public int[] Sequence(int size)
        {
            int[] sequence = new int[size];

            for (int i = 0; i < size; i++)
            {
                if (i < 2)
                {
                    sequence[i] = i;
                }
                else
                {
                    sequence[i] = sequence[i - 1] + sequence[i - 2];
                }
            }
            return sequence;
        }


    }
}
