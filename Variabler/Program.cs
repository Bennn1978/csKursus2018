using System;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {   //heltal
            Int32 a = 10;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);
            a--;
            Console.WriteLine(a);
            a +=20;
            Console.WriteLine(a);
            
            //kommatal
            double b;
            b = 12.5;
            Console.WriteLine(b);
            b++;
            Console.WriteLine(b);
            b--;
            Console.WriteLine(b);
            b *= 2;
            Console.WriteLine(b);

            //Enum
            FilTyper ft=0;
            Console.WriteLine(ft);
            Console.WriteLine((int)ft);

            DateTime today = DateTime.Now;
            Console.WriteLine(today);
            Console.WriteLine(today.ToString("ddMMyy"));
            Console.WriteLine(today.ToUniversalTime());

            Person p = new Person();
            p.Id = 1;
            p.Navn = "Mikkel";
            Console.WriteLine(p.Id);
            Console.WriteLine(p.Navn);

            System.Console.ReadLine();
        }
    }

    enum FilTyper
    {
        csv,pdf,txt
    }

    public struct Person
    {
        public int Id;
        public string Navn;

    }
}
