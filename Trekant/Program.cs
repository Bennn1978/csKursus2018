using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trekant
{
    class Program
    {
        static void Main(string[] args)
        {
            Trekant t1 = new Trekant(1233456, 300);
            Console.WriteLine("Højde (i m.) : "+t1.Højde);
            Console.WriteLine("Grundlinje: (i m.) " + t1.Grundlinje);
            Console.WriteLine("Areal: "+t1.Areal+"m2");

            Console.ReadKey();
        }
    }

    public class Trekant
    {                

        public Trekant()
        {
            this._grundlinje = 0;
            this._højde = 0;
        }

        public Trekant(int grundlinje, int højde)
        {
            this.Grundlinje = grundlinje;
            this.Højde = højde;
        }

        private int _grundlinje;

        public int Grundlinje
        {
            get { return _grundlinje; }
            private set { _grundlinje = value; }
        }

        private int _højde;

        public int Højde
        {
            get { return _højde; }
            private set { _højde = value; }
        }

        public double Areal {
            get { return 0.5 * Grundlinje * Højde; }                
        }


    }
}
