using System;

namespace App09Metode
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 1;
            //int b = 4;
            //int radius = 4;
            //string tekst = "Dette er en test"; 
            //int c = LaegSammen(a, b);            
            //double areal = BeregnAreal(radius);
            //Console.WriteLine(c);
            //Console.WriteLine(areal);
            //Udskriv(tekst);
            Console.WriteLine(Beregn(1, 2));
            Console.WriteLine(Beregn(1, 2, 3));
            Console.WriteLine(Beregn(1, 2, 4, 5));

        }

        public static int LaegSammen(int a, int b)
        {
            return a + b;
        }
        public static double BeregnAreal(int radius)
        {
            return radius * radius * Math.PI;
        }
        public static void Udskriv(string tekst)
        {
            Console.WriteLine( tekst);
        }
        //public static int Beregn(int a, int b)
        //{
        //    return a + b;
        //}
        //public static int Beregn(int a, int b, int c)
        //{
        //    return a + b + c;
        //}
        //public static int Beregn(int a, int b, int c, int d)
        //{
        //    return a + b + c + d;
        //}
        //public static int Beregn(int a = 0, int b = 0, int c = 0, int d = 0)
        //{
        //    return a + b + c + d;
        //}
        public static int Beregn(int a, int b)
        {
            return a + b;
                       
        }
        public static int Beregn(int a, int b, int c = 0, int d = 0)
        {
            return Beregn(a, b) + c + d;
        }
    }
}
