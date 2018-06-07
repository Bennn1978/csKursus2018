using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare n1 = new Vare();
            n1.Navn = "Tandbørste";
            n1.Pris = 1.0;
            Console.WriteLine(n1.prisMedMoms());

            Vare n2 = new Vare("Tandpasta", 15.00);
            Console.WriteLine(n2.Navn);
            Console.WriteLine(n2.Pris);
            Console.WriteLine(n2.prisMedMoms());


            Console.ReadLine();
        }
    }

    public class Vare
    {


        private string navn;

        public string Navn
        {
            get {
                Console.WriteLine("Navn læst: "+navn);
                return navn; }
            set {
                navn = value;
                Console.WriteLine("Navn sat: "+navn);
                 }
        }

        private double pris;

        public Vare(string navn, double pris)
        {
            Navn = navn;
            Pris = pris;
        }

        public Vare()
        {
        }

        public double Pris
        {
            get {
                Console.WriteLine("Pris læst: "+pris);
                return pris; }
            set {
                pris = value;
                Console.WriteLine("Pris sat:" +pris);
                 }
        }
        
        public double prisMedMoms()
        {
            return this.Pris * 1.25;
        }

    }
}
