using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egen.Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StockItem s = new StockItem(-1);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
    public class StockItem
    {
        public int ID { get; set; }
        public StockItem(int ID)
        {
            if (ID > 0)
                ID = this.ID;
            else throw new StockItemException("Wrong ID");
        }
    }

    public class StockItemException : System.Exception
    {
        public StockItemException(string message) : base(message)
        {

        }
    }
}
