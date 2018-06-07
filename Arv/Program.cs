using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Benjamin","Nielsen");

            Console.WriteLine(p1.FuldtNavn());

            Elev e1 = new Elev() {Fornavn="Isak",Efternavn="Nielsen",Klasselokale="H56" };
            
            Console.WriteLine("Elev: "+e1.FuldtNavn()+' '+e1.Klasselokale);

            Instruktør i1 = new Instruktør() {Fornavn="Hans", Efternavn="Jensen", NøgleId=1 };

            Console.WriteLine("Instruktør: "+i1.FuldtNavn()+" NøgleId: "+i1.NøgleId);


            UdvidetRandom b1 = new UdvidetRandom();
            Console.WriteLine(b1.NextBool());
            

            Console.ReadKey();
        }
    }

    class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public Person(string f,string e)
        {
            this.Fornavn = f;
            this.Efternavn = e;
        }
        public Person()
        {

        }
        public string FuldtNavn()
        {
            return this.Fornavn + ' ' + this.Efternavn;
        }

    }

    class Elev : Person
    {
        public string Klasselokale { get; set; }

        public Elev()
        {

        }
    }

    class Instruktør : Person
    {
        public int NøgleId { get; set; }
    }

    class UdvidetRandom : System.Random
    {
        public bool NextBool()
        {
            Random rdn = new Random();
            int rndTal = this.Next(1, 1001);
            if (rndTal > 500)
                return true;
            else return false;
        }
    }

}
