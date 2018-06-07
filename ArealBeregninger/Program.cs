using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArealBeregninger
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Areal af firkant: "+ArealBeregninger.BeregnArealFirkant(10,10));

            Console.WriteLine("Areal af cirkel: " + ArealBeregninger.BeregnArealCirkel(10));

            Console.ReadKey();
        }
    }

    public static class ArealBeregninger
    {
        public static double BeregnArealFirkant(double højde, double bredde)
        {
            return højde * bredde;
        }

        public static double BeregnArealCirkel(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
