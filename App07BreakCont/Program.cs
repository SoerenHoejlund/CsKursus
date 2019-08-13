using System;

namespace App07BreakCont
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 19; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                if (i >= 15) break;
            }
        }
    }
}
