using System;
using System.Collections.Generic;
using System.Text;

namespace App13Terning
{
    class Terning
    {
        public int vaerdi;
        private bool snyd;
        Random rnd = new Random();

        public void Skriv()
        {
            Console.WriteLine($"[{vaerdi}]");
        }
        public void Ryst()
        {
            if (snyd == false )
            {
                vaerdi = rnd.Next(1, 7);
            }          
        }
        public Terning()
        {
            vaerdi = 1;
            snyd = false;
        }
        public Terning(bool snydeterning)
        {
            if(snydeterning == false)
            {
                snyd = false;
                vaerdi = 1;
            }
            else
            {
                snyd = true;
                vaerdi = 6;
            }
        }
    }
}
