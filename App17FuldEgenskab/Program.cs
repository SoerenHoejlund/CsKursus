using System;

namespace App17FuldEgenskab
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v1 = new Vare();
            Vare v2 = new Vare();
            Vare v3 = new Vare("Blåbær", 1);
            Vare v4 = new Vare("Hindbær", 1);

            v1.Navn = "Æble";
            v1.Pris = 4.50;

            v2.Navn = "Banan";
            v2.Pris = 2.50;            

            Console.WriteLine(v1.PrisMedMoms());
            Console.WriteLine(v2.PrisMedMoms());
            Console.WriteLine(v3.PrisMedMoms());
            Console.WriteLine(v4.PrisMedMoms());

        }
    }
}
