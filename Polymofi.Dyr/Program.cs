using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymofi.Dyr
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dyr h1 = new Hund() { Navn = "Fido" };
            //h1.SigNoget();
            //Dyr k1 = new Kat() { Navn = "Misser" };
            //k1.SigNoget();

            Dyr[] dyr = new Dyr[20];
            
            for (int i = 0; i < 20; i++)
            {
                dyr[i] = Dyr.TilfældigtDyr();
            }
            foreach (var item in dyr)
            {
                item.SigNoget();
            }

            Console.ReadKey();
        }
    }

    public abstract class Dyr
    {
        static Random rnd = new Random();
        public String Navn { get; set; }

        public virtual void SigNoget()
        {
            Console.WriteLine("Jeg er et Dyr og hedder "+Navn);
        }

        public static Dyr TilfældigtDyr()
        {
            string[] navne = System.IO.File.ReadAllLines(@"x:/dyrenavne.txt");
            
            
            int tal = rnd.Next(1, navne.Length);
            Dyr d;
            if (tal % 2 == 0)
                d = new Hund();
            else d = new Kat();
            d.Navn = navne[tal];

            return d;
        }

    }

    public class Hund : Dyr
    {
        public Hund()
        {
        }

        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en Hund og hedder "+Navn);
        }
    }

    public class Kat : Dyr
    {
        public Kat()
        {
        }

        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en Kat og hedder " + Navn);
        }
    }
}
