using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.fødselsÅr = 1978;
            Console.WriteLine(p.Alder());

            Person p2 = new Person("Benjamin", "Nielsen", 1978);

            Console.WriteLine(p2.FuldtNavn());
            Console.WriteLine(p2.Alder());


            Console.ReadLine();
        }
    }

    public class Person{
        public string forNavn;
        public string efterNavn;
        public int fødselsÅr;

        public string FuldtNavn()
        {
            return forNavn + ' ' + efterNavn;
        }
        
        public int Alder()
        {
            int detteÅr =DateTime.Now.Year;

            return detteÅr-fødselsÅr;
        }

        public Person()
        {
            forNavn = "";
            efterNavn = "";
        }

        public Person(string fn,string en,int fø)
        {
            fødselsÅr = fø;
            forNavn = fn.ToUpper();
            efterNavn = en.ToUpper();
        }
}
}
