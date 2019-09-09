using System;
using System.Collections.Generic;

namespace App21Polymorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hund h = new Hund();
            //Kat k = new Kat();

            //h.Navn = "Balder";
            //k.Navn = "Sissi";

            //h.SigNoget();
            //k.SigNoget();

            List<Dyr> lst = new List<Dyr>();
            //Hund h1 = new Hund();
            //h1.Navn = "Arnold";
            //Hund h2 = new Hund();
            //h2.Navn = "Carlo";
            //Hund h3 = new Hund();
            //h3.Navn = "Chuck";
            //Kat k1 = new Kat();
            //k1.Navn = "Sissi";
            //Kat k2 = new Kat();
            //k2.Navn = "Ivan";

            //lst.Add(h1);
            //lst.Add(h2);
            //lst.Add(h3);
            //lst.Add(k1);
            //lst.Add(k2);

            
            for (int i = 0; i < 20; i++)
            {
                lst.Add(Dyr.TilfældigtDyr());
            }

            foreach (var item in lst)
            {
                item.SigNoget();
            }


        }
    }
}
public abstract class Dyr
{
    public string Navn { get; set; }

    public abstract void SigNoget();

    private static System.Random rnd = new Random();

    public static Dyr TilfældigtDyr()
    {

        string data = "Freja;Bella;Emma;Mille;Fie;Molly;Lady;Trine;Trunte;Luna;Amanda;";
        data += "Bonnie;Laika;Ronja;Sally;Trille;Zita;Tøsen;Bianca;Zenta;Victor;Buller;";
        data += "Buster;King;Simba;Thor;Charlie;Samson;Bamse;Mickey;Max;Rasmus;Sofus;Anton;";
        data += "Laban;Basse;Bølle;Oliver;Oscar;Balder";
        string[] navne = data.Split(';');
        int index = rnd.Next(0, navne.Length);
        if (index % 2 == 0)
        {
            return new Hund() { Navn = navne[index] };
        }
        else
        {
            return new Kat() { Navn = navne[index] };
        }
    }

}
public class Hund: Dyr
{
    public override void SigNoget()
    {
        Console.WriteLine($"Jeg er en hund og hedder {Navn}");
    }
}
public class Kat: Dyr
{
    public override void SigNoget()
    {
        Console.WriteLine($"Jeg er en kat og hedder {Navn}");
    }
}