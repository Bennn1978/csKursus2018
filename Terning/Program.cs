using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();
            t1.Værdi = 3;
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            Console.ReadLine();
        }
    }

    public class Terning
    {
        private int _værdi;

        public int Værdi
        {
            get { return _værdi; }
            set {
                if (value < 1) _værdi = 1;
                else if (value > 6) _værdi = 1;
                else
                _værdi = value; }
        }

        private static Random rnd = new System.Random();

        public void Ryst()
        {
            Værdi= rnd.Next(1, 7);
        }

        public void Skriv()
        {
            Console.WriteLine(this.Værdi);
        }





    }
}
