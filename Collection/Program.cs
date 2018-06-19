using System;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personer = new List<Person>();
            personer.Add(new Person() { Id = 1, Navn = "Hans" });
            personer.Add(new Person() { Id = 2, Navn = "Grete" });
            personer.Add(new Person() { Id = 3, Navn = "Morten" });

            Dictionary<int,string> pDict = new Dictionary<int, string>();

            foreach (var item in personer)
            {
                Console.WriteLine(item.Navn);
                pDict.Add(item.Id, item.Navn);
            }

            Console.WriteLine();

            Console.WriteLine(pDict[3]);
            Console.ReadKey();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }

    }
}
