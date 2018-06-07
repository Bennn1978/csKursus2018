using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            person p1 = new person();
            p1.Fornavn = "Benjamin";
            p1.Efternavn = "Nielsen";
            Console.WriteLine(p1.Fuldnavn() );
            Console.ReadLine();
        }
    }

    class person
    {
        public string Fornavn { get; set; }
        private string _efternavn;

        public string Efternavn
        {
            get { return _efternavn; }
            set {
                if (value.Length < 4) _efternavn = "";
                else _efternavn = value; }
        }

        public string Fuldnavn()
        {
            return Fornavn + " " + Efternavn;
        }

    }
}
