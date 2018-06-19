using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generisk.Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person() { Navn = "Hans" };
            Instruktør i1 = new Instruktør();
            i1.Navn = p1.Navn;
            i1.NøgleId = 1;

            Kursist k1 = new Kursist() { Navn = "Peter", KursistId = 233 };

            Personer1 personer1 = new Personer1();
            personer1.Tilføj(p1);
            personer1.Tilføj(i1);
            personer1.Tilføj(k1);

            Personer2<Person> personer2 = new Personer2<Person>();
            personer2.Tilføj(p1);
            personer2.Tilføj(i1);
            personer2.Tilføj(k1);

            Personer3<Instruktør> personer3 = new Personer3<Instruktør>();
            //personer3.Tilføj(p1);
            personer3.Tilføj(i1);
            //personer3.Tilføj(k1);
        }
    }

    class Person
    {
        public string Navn { get; set; }
    }

    class Instruktør: Person
    {
        public int NøgleId { get; set; }
    }

    class Kursist: Person
    {
        public int KursistId { get; set; }
    }

    class Personer1
    {
        List<Person> lst = new List<Person>();

        public void Tilføj(Person ps)
        {
            lst.Add(ps);
        }
    }

    class Personer2<T>
    {
        List<T> lst = new List<T>();
        public void Tilføj(T ps)
        {
            lst.Add(ps);
        }
    }class Personer3<T>where T: Person
    {
        List<Person> lst = new List<Person>();
        public void Tilføj(T ps)
        {
            lst.Add(ps);
        }
    }
}
