﻿using System;

namespace App05Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Til alle der læser koden...
            // Kulør 0 = Spar
            // Kulør 1 = Hjerter
            // Kulør 2 = Ruder
            // Kulør 3 = Klør

            //int kort1Værdi = 2;
            //int kort1Kulør = 1;

            //int kort2Værdi = 2;
            //int kort2Kulør = 2;

            Kulør kort1Kulør = Kulør.Hjerter;
            Kulør kort2Kulør = Kulør.Ruder;

            Console.WriteLine($"{kort1Kulør} har integer værdien: {(int) kort1Kulør}");
            Console.WriteLine($"{kort2Kulør} har integer værdien: {(int)kort2Kulør}");
        }
        
    }
}
