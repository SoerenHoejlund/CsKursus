using System;

namespace App06ForIf
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int res = i * j;
                    string resultat = res.ToString();                    
                    if (res > 50)
                    {
                        Console.ForegroundColor= ConsoleColor.Yellow;
                        Console.Write(resultat.PadLeft(4));
                    } 
                    else
                        Console.Write(resultat.PadLeft(4));
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
