using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10tabel
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    int tal = (i * j);
                    
                    if (tal>50)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(tal.ToString().PadLeft(4));
                }
                Console.WriteLine();
            }

            System.Console.ReadLine();
        }
    }
}
