using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrugAfUsing
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader stream = File.OpenText(@"x:\dyrenavne.txt"))
            {
                while (stream.Peek() != -1)
                {
                    string navn = stream.ReadLine();
                    Console.WriteLine(navn);
                }
            }
            Console.ReadLine();
        }
    }
}
