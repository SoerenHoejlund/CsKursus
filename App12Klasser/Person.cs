namespace App12Klasser
{
    public class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Foedselsaar;
        private int KalenderAar = 2019;

        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }
        public int Alder()
        {
            return KalenderAar - Foedselsaar;
        }
        public Person(string f_navn, string e_navn, int f_aar)
        {
            this.Fornavn  = f_navn;
            this.Efternavn = e_navn;
            this.Foedselsaar = f_aar;
        }
        public Person() : this(" "," ",1800)
        {
        }
    }
}
