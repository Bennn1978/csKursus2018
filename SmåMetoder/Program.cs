using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmåMetoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = lægSammen(1, 2);
            Console.WriteLine(res);

            double areal=beregnAreal(2);
            Console.WriteLine(areal);

            string tekst = "her er en tekst";
            Udskriv(tekst);
            Udskriv();

            double brutto=10;
            double netto=beregnMoms(brutto);
            Udskriv(netto);

            int[] i = { 100, 200 };
            Udskriv(beregnGns(i));

            System.Console.ReadLine();
        }

        static int lægSammen(int a, int b)
        {
            return a + b;

        }

        static double beregnAreal(int radius)
        {
            return Math.PI * radius * radius;
        }

        static void Udskriv(double s = 0)
        {
            Console.WriteLine(s.ToString());
        }

        static void Udskriv(int s = 0)
        {
            Console.WriteLine(s.ToString());
        }

        static void Udskriv(string s = "")
        {
            Console.WriteLine(s);
        }
        static void Udskriv()
        {
            Console.WriteLine();
        }
        static double beregnMoms(double brutto,double momsPct = 0.25)
        {
            double netto = brutto + brutto * momsPct;
            return netto;
        }

        static double beregnGns(int[] input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {                
                sum += input[i];
            }
            return sum / input.Length;

        }
    }
}
