using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] månedsløn = { 10000, 2000, 50000, 6000 };
            int sum=0;
            for (int i = 0; i < månedsløn.Length; i++)
            {
                Console.WriteLine(månedsløn[i]);

                sum += månedsløn[i];
            }
            int gns = sum / månedsløn.Length;
            Console.WriteLine("Gennemsnit: "+gns);

            System.Array.Sort(månedsløn);

            foreach (int løn in månedsløn)
            {
                Console.WriteLine(løn);
            }

            System.Console.ReadLine();


          
        }
    }
}
