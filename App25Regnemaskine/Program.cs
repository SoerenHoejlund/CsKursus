using System;

namespace App25Regnemaskine
{
    class Program
    {
        public delegate int Beregn(int a, int b);
        static void Main(string[] args)
        {
            int res = Beregner(22, 7, Gange); 
            Console.WriteLine(res);
            
        }
        public static int Beregner(int a, int b, Beregn metode)
        {
            return metode(a, b);
        }
        
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Divider(int a, int b)
        {
            return a / b;
        }

        public static int Gange(int a, int b)
        {
            return a * b;
        }
    }
}
