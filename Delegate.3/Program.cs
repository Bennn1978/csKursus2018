using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Beregner(10,10,FindTilfældigFunction()));


            Console.ReadKey();
        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public static int Divider(int a, int b)
        {
            return a / b;
        }
        public static int Gange(int a, int b)
        {
            return a * b;
        }
        public static int Beregner(int a, int b, Func<int, int, int> func)
        {
            return func(a, b);
        }

        public static Func<int, int, int> FindTilfældigFunction()
        {
            int tal = DateTime.Now.Millisecond;
            if (tal % 4 == 0) return Plus;
            if (tal % 4 == 1) return Minus;
            if (tal % 4 == 2) return Gange;
            if (tal % 4 == 3) return Divider;
            else
            {
                throw new ApplicationException("Fejl");
            }
        }
    }
}
