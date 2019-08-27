using System;
using System.Collections.Generic;
using System.Text;

namespace App15Konto
{
    public class Transaktion
    {
        //felter
        public DateTime dato;
        public String tekst;
        public decimal beløb;

        public Transaktion(DateTime dato, String tekst, decimal beløb)
        {
            //validering
            this.dato = dato;
            this.tekst = tekst;
            this.beløb = beløb;
        }
    }
}
