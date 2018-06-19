using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde= new Hund[4];
            hunde[0] = new Hund() { Alder = 10, Navn = "Bulder" };
            hunde[1] = new Hund() { Alder = 5, Navn = "Lady" };
            hunde[2] = new Hund() { Alder = 1, Navn = "Fnug" };
            hunde[3] = new Hund() { Navn = "Noobi" };
            Array.Sort(hunde);
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn);
            }

            Console.ReadKey();

        }
    }

    class Hund :IComparable
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public int CompareTo(object obj)
        {
            Hund b = obj as Hund;
            if (this.Alder < b.Alder)
            {
                return -1;
            }
            if (this.Alder > b.Alder)
            {
                return 1;
            }
            else return 0;
        }
    }
}
