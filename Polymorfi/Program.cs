using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Benjamin", "Nielsen");
            p1.Skriv();

            Person e1 = new Elev() { Fornavn = "Claus", Klasselokale = "B2", Efternavn = "Thomsen" };
            e1.Skriv();

            Person i1 = new Instruktør() { Fornavn = "Mikkel", Efternavn = "Hansen", NøgleId = 454 };
            i1.Skriv();

            Person[] lst = new Person[3];
            lst[0] = p1;
            lst[1] = e1;
            lst[2] = i1;

            foreach (Person item in lst)
            {
                item.Skriv();
            }

            Console.ReadKey();
        }
    }

    class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public Person(string f, string e)
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

        public virtual void Skriv()
        {
            Console.WriteLine(this.FuldtNavn());
        }

    }

    class Elev : Person
    {
        public string Klasselokale { get; set; }

        public Elev()
        {

        }

        public override void Skriv()
        {
            Console.WriteLine(this.FuldtNavn()+" "+this.Klasselokale);
        }
    }

    class Instruktør : Person
    {
        public int NøgleId { get; set; }

        public override void Skriv()
        {
            Console.WriteLine(this.FuldtNavn() + " " + this.NøgleId);
        }
    }

}
