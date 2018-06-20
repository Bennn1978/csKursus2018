using System;

namespace Delegates._2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Maskine m = new Maskine();
            m.Log = Console.WriteLine;
            m.Log += AppendLog;

            m.Start();
            m.Stop();

            Console.ReadKey();
        }
        static void AppendLog(string t)
        {
            System.IO.File.AppendAllText(@"c:\temp\log.txt",t+"\r\n");
        }
        
    }
    public delegate void LogDelegate(string txt);
    public class Maskine
    {
        public LogDelegate Log { get; set; }
        

        public void Start()
        {
            Log("Starter: "+DateTime.Now.ToLongTimeString());
        }public void Stop()
        {
            Log("Stopper: "+DateTime.Now.ToLongTimeString());
        }
    }
}
