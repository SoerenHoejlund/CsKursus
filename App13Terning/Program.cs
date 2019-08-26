using System;

namespace App13Terning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();
            Console.WriteLine("Terning 1");
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            Terning t2 = new Terning(true);
            Console.WriteLine("Terning 2");
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();
        }
       
    }
    
}
