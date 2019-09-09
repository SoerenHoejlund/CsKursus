using System;
using System.Collections.Generic;

namespace App22Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDbFunktioner> lst = new List<IDbFunktioner>();
            Hund h = new Hund() { Navn = "Balder" };
            //h.Navn = "Balder";
            Ubåd u = new Ubåd() { Nummer = 96, Tubine = Math.Log(23) };
            //u.Nummer = 104921;
            lst.Add(h);
            lst.Add(u);

            foreach (IDbFunktioner item in lst)
            {
                item.Gem();
            }


        }
    }
    interface IDbFunktioner
    {
        void Gem();
    }
    class Hund : IDbFunktioner
    {

        public string Navn { get; set; }
        public void Gem()
        {
            Console.WriteLine("Gemmer hund...");
        }

    }

    class Ubåd : IDbFunktioner  
    {

        public int Nummer { get; set; }
        public double Tubine { get; set; }
        public void Gem()
        {
            Console.WriteLine("Gemmer ubåd...");
        }

    }
}
