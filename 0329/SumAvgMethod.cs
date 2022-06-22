using System;

namespace namespaceA
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5] { 1, 2, 3, 4, 5 };
            SumAvg(a);
        }

        static void SumAvg(int[] abc)
        {
            int sum = 0;
            int avg = 0;
            for(int i = 0; i < abc.Length; i++)
            {
                sum += i;
            }
            avg = sum / abc.Length;
            Console.WriteLine(sum);
            Console.WriteLine(avg);
        }
    }
}
