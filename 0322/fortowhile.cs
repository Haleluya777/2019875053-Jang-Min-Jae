using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i < 10)
            {
                if (i % 2 == 1)
                    Console.Write(i + " ");
                i++;
            }
        }
    }
}
