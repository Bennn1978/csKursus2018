using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string fn = "Mikkel";
            string en = "Cronberg";
            string samletNavn = fn +' '+ en;
            Console.WriteLine(samletNavn);

            string navnStort = samletNavn.ToUpper();
            Console.WriteLine(navnStort);

            var navnLille = samletNavn.ToLower();
            Console.WriteLine(navnLille);

            string del = samletNavn.Substring(7, 4);
            Console.WriteLine(del);

            string[] a = samletNavn.Split(' ');
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine(fn + "\t" + en);
            Console.WriteLine(fn + "\r\n" + en);

            
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]+"\n");
            }

            System.Console.ReadLine();
        }
    }
}
