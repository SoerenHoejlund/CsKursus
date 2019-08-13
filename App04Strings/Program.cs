using System;
using System.IO;

namespace App04Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Søren";
            string efternavn = "Højlund";
            string samletNavn = fornavn + " " + efternavn;
            string navnLille = samletNavn.ToLower();
            string delStreng = samletNavn.Substring(6, 3);
            Console.WriteLine(fornavn);
            Console.WriteLine(efternavn);
            Console.WriteLine(samletNavn);
            Console.WriteLine(navnLille);
            Console.WriteLine(delStreng);
            File.WriteAllText(@"c:\temp\fil.txt", "dette er en testfil");
        }
    }
}
