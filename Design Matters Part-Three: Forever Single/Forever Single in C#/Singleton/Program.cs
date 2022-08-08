using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Adabas database;
            database = Adabas.getInstance("consumers");
            Console.WriteLine("This is the " + database.Name + " database.");
        }
    }
}
