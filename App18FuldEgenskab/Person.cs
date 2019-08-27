using System;
using System.Collections.Generic;
using System.Text;

namespace App18FuldEgenskab
{
    class Person
    {
        public String ForNavn { get; set; }

        private string _efternavn;
        public string EfterNavn
        {
            get { return _efternavn; }
            set           
            {
                _efternavn = value;
                if (value.Length <= 2)
                {
                    _efternavn = "";
                }
            }
        }

        
        public String FuldtNavn()
        {
            return ForNavn + " " + EfterNavn;
        }


    }
}
