using System;

namespace App24Delegates
{
    class Program
    {
        public delegate void MinDelegate1(string txt);
        static void Main(string[] args)
        {
            MinDelegate1 f1 = new MinDelegate1(MinSkrivTilConsole);
            f1.Invoke("test1");

            MinDelegate1 f2 = MinSkrivTilConsole;
            f2("test2");

            MinDelegate1 f3 = MinSkrivTilConsole;
            f3 += Console.WriteLine;
            f3 -= Console.WriteLine;
            f3("test3");

            f1 -= MinSkrivTilConsole;
            f2 -= MinSkrivTilConsole;
            f3 -= MinSkrivTilConsole;
        }
    

   
        static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine("**** " + txt + " ****");
        }
    }
   
}
