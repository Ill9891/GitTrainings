using System;

namespace GitTrainings
{
    class Program
    {
        private int y = 0;

        public void Test2()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Sum(y, 9);
        }

        public void Test1()
        {
            Sum(10000, 112);
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }
    }
}