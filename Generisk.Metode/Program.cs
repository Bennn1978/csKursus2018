using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generisk.Metode
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine();
            Swap<int>(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine();

            string x = "HEJ";
            string y = "DU!";
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine();
            Swap<string>(ref x, ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine();

            Swap(ref x, ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
