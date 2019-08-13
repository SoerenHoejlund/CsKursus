using System;

namespace App02Regnemaskine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast tal 1");
            string tal1s = Console.ReadLine();
            Console.WriteLine("Indtast tal 2");
            string tal2s = Console.ReadLine();
            double tal1 = Convert.ToDouble(tal1s);
            double tal2 = Convert.ToDouble(tal2s);
            double res = tal1 + tal2;
            Console.WriteLine(res.ToString("N2"));
        }
    }
}
