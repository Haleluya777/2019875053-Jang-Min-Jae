using System;

namespace namespaceA
{
    class Program
    {
        public static void Main()
        {
            getSum sum = new getSum();
            sum.setNum(5, 10);
            Console.WriteLine("합 " + sum.sumNum());
        }
    }

    class getSum : Sum
    {
        public int sumNum()
        {
            return a + b;
        }
    }

    class Sum
    {
        public int a, b;
        public void setNum(int a_, int b_)
        {
            a = a_;
            b = b_;
        }
    }
}
