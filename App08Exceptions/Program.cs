using System;

namespace App08Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {

            int tal1 = 0;
            int tal2 = 0;
            Console.WriteLine("Indtast 1. tal");
            try
            {
                tal1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {

                int antal = 1;
                while (antal < 4)
                {
                    try
                    {
                        Console.WriteLine("Fejl i input: Indtast 1. tal");
                        tal1 = Convert.ToInt32(Console.ReadLine());
                        antal = 1000;
                    }
                    catch (Exception)
                    {
                        antal++;
                        Console.WriteLine("Fejl i input: Indtast 1. tal");
                    }
                }
            }
            Console.WriteLine("Indtast 2. tal");
            try
            {
                tal2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                int antal = 1;
                while (antal < 4)
                {
                    try
                    {
                        Console.WriteLine("Fejl i input: Indtast 2. tal");
                        tal2 = Convert.ToInt32(Console.ReadLine());
                        antal = 1000;
                    }
                    catch (Exception)
                    {
                        antal++;
                        Console.WriteLine("Fejl i input: Indtast 2. tal");
                    }
                }
            }
            int res = tal1 + tal2;
            Console.WriteLine("resultatet er " + res);
        }
    }
}
