using System;

namespace DatoOgTid
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            d1 = d1.AddMinutes(20);
            Console.WriteLine(d1);
            d1 = d1.AddMonths(-1);
            Console.WriteLine(d1);
            DateTime d2 = DateTime.Now;
            DateTime d3 = DateTime.UtcNow;
            TimeSpan TimeSpan = d2.Subtract(d3);
            Console.WriteLine(TimeSpan);

            TimeSpan t2 = new TimeSpan(16,00,00);            
            Console.WriteLine(t2);
            TimeSpan t3 = new TimeSpan(00,30,00);            
            Console.WriteLine(t3);
            TimeSpan t4 = t2.Subtract(t3);
            Console.WriteLine(t4);
            TimeSpan t5 = t2.Add(t3);
            Console.WriteLine(t5);

            System.Console.ReadLine();
        }
    }
}
