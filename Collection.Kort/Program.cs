using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.Kort
{
    class Program
    {
        static void Main(string[] args)
        {
            Bunke b = new Bunke();
            b.TilFøjKort(new Kort() { Kulør = "Spar", Værdi = 2 });
            b.TilFøjKort(new Kort() { Kulør = "Hjerter", Værdi = 14 });
            b.TilFøjKort(new Kort() { Kulør = "Ruder", Værdi = 3 });
            b.Vis();

            var k = b.FjernKort();
            Console.WriteLine();
            Console.WriteLine(k);
            Console.WriteLine();
            b.Vis();

            Console.WriteLine(b.GetHashCode());

            Console.ReadKey();
        }
    }

    public class Kort
    {
        public string Kulør { get; set; }
        public int Værdi { get; set; }

        public override string ToString()
        {
            return Kulør + " " + Værdi;
        }

    }

    public class Bunke
    {
        private Stack<Kort> bnk = new Stack<Kort>();

        public void TilFøjKort(Kort kort)
        {
            bnk.Push(kort);
        }

        public Kort FjernKort()
        {
            return bnk.Pop();
        }

        public void Vis()
        {
            foreach (var item in bnk)
            {
                Console.WriteLine(item.ToString());
            }
        }

    }
}
