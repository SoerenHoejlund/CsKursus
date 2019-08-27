using System;

namespace App18FuldEgenskab
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.ForNavn = "Søren";
            p.EfterNavn = "Højlund";
            Person k = new Person();
            k.ForNavn = "Kai";
            k.EfterNavn = "Bo";

            Console.WriteLine(p.FuldtNavn());
            Console.WriteLine(k.FuldtNavn());



        }
    }
}
