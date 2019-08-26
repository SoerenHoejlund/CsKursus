using System;

namespace App10Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "3;5;22;1;10;15;5;9;6;1;0;3333";
            string[] data = txt.Split(';');
            int[] data_int = new int[data.Length];
            for (int i = 0; i < data.Length; i++)
            {  
                data_int[i] = Int32.Parse(data[i]);
            }
            int resultat = 0;
            for (int i = 0; i < data.Length; i++)
            {
                resultat += data_int[i];
            }
            Console.WriteLine(resultat);
        }
    }
}
