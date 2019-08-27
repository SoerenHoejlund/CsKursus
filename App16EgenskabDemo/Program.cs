using System;

namespace App16EgenskabDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        class Person
        {
            private int alder;

            public int Alder
            {
                get { return alder}
            }
            private string _navn;

            private int myVar;

            public int MyProperty
            {
                get { return myVar; }
                set { myVar = value; }
            }

        }

    }
}
