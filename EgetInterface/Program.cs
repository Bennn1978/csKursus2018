using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgetInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] a = new IDbFunktioner[2];
            a[0] = new Hund();
            a[1] = new UBåd();

            foreach (var item in a)
            {
                item.Gem();
            }

            Console.ReadKey();
        }
    }

    class Hund:IDbFunktioner
    {
        public string Navn { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer Hund");
        }
    }

    class UBåd:IDbFunktioner
    {
        public int Nummber { get; set; }
        public double Tubine { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer UBåd");
        }
    }

    public interface IDbFunktioner
    {
        void Gem();
    }
}
