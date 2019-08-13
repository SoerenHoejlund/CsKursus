using System;

namespace App03DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            d1 = d1.AddDays(10);
            Console.WriteLine(d1);
            d1 = d1.AddMinutes(20);
            Console.WriteLine(d1);
            d1 = d1.AddMonths(-1);
            Console.WriteLine(d1);


            TimeSpan t2 = new TimeSpan(16, 0, 0);
            TimeSpan t3 = new TimeSpan(00, 30, 0);
            TimeSpan t4 = t2.Subtract(t3);
            Console.WriteLine(t4);
            TimeSpan t5 = t2.Add(t3);
            Console.WriteLine(t5);


        }
    }
}
