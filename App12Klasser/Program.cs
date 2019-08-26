using System;


namespace App12Klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person("Peter", "Belli", 1940);
            Person b = new Person("Lars", "von Trier", 1959);
            Person c = new Person("Søren", "Højlund", 1981);
            Person d = new Person();
            Console.WriteLine($"{a.FuldtNavn()} er { a.Alder()} år gammel.");
            Console.WriteLine($"{b.FuldtNavn()} er { b.Alder()} år gammel.");
            Console.WriteLine($"{c.FuldtNavn()} er { c.Alder()} år gammel.");
            Console.WriteLine($"{d.FuldtNavn()} er { d.Alder()} år gammel.");
        }
    }
}
