using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher a = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            a.EnableRaisingEvents = true;
            a.Changed += FilOprettet;

            a.Deleted += (s, e) => {Console.WriteLine("Fil slettet: " + e.FullPath); };
            a.Renamed+= (s, e) => {Console.WriteLine("Filnavn Ændret: " + e.FullPath); };
            do
            {

            } while (true);
        }

        private static void A_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void FilOprettet(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("Fil oprettet: "+e.Name);
        }
    }
}
