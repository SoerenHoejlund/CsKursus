using System;
using System.Collections.Generic;

namespace App11Lister
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Tal = new List<int>();
            Tal.Add(987);
            Tal.Add(7654);
            Tal.Add(4032038);
            foreach (int item in Tal)
            {
                //Console.WriteLine(item);
            }

            Dictionary<int, string> Strenge = new Dictionary<int, string>();
            Strenge.Add(0, "Jeg hedder");
            Strenge.Add(1, "Søren");
            Strenge.Add(2, "Højlund");
            Strenge.Add(3, " "); 
            String Saetning = Strenge[0] + Strenge[3] + Strenge[1] + Strenge[3] + Strenge[2];
            Console.WriteLine(Saetning);
        }
    }
}
