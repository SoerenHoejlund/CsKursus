using System;
using System.Collections.Generic;
using System.Text;

namespace App17FuldEgenskab
{
    public class Vare
    {

        private void navn_log(string n)
        {
            Console.WriteLine($"Navn er sat til {n}");
        }
        private void pris_log(double p)
        {
            Console.WriteLine($"Pris er sat til {p}");
        }
        
        private string _navn;

        public string Navn
        {
            get { return _navn; Console.WriteLine($"{_navn} hentes"); }
            set { _navn = value; navn_log(_navn); }
        }

        private double _pris;

        public double Pris
        {
            get { return _pris; Console.WriteLine($"Pris på {_navn} hentes"); }
            set { _pris = value; pris_log(_pris); }
        }

        public double PrisMedMoms ()
        {
            return _pris * 1.25;
        }
        
        //constructor
        public Vare()
        { }
        public Vare(string n, double p)
        {
            _navn = n;
            _pris = p;
            navn_log(_navn);
            pris_log(_pris);
        }
    }
}
