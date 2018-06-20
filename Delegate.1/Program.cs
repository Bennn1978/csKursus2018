using System;

namespace Delegate
{

    class Program
    {
        //public delegate int BeregnDelegate(int a, int b);
        static void Main(string[] args)
        {
            //BeregnDelegate s = new BeregnDelegate(Plus);
            //BeregnDelegate m = new BeregnDelegate(Minus);
            //int res = Beregner(1, 1, s);
            int res = Beregner(1, 1, Plus);
            Console.WriteLine(res);

            
            //Console.WriteLine(Beregner(1, 1, m));
            Console.WriteLine(Beregner(1, 1, Minus));

            Console.WriteLine(Beregner(3,4,Gange));
            Console.WriteLine(Beregner(25,5,Divider));

            Console.ReadKey();

        }

        //public static int Beregner(int a, int b, BeregnDelegate funktion)
        public static int Beregner(int a, int b, Func<int, int, int> funktion)
        {
            return funktion(a, b);
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


    }



}
