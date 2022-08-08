using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {

            PGPClass pgpObject = new PGPClass();
            pgpObject.setName("JouLook MHMV");
            PGP1TOPGP2Adapter adapter = new PGP1TOPGP2Adapter(pgpObject);
            Console.WriteLine("Customer first name: " +
            adapter.getFirstName());
            Console.WriteLine("Customer last name: " +
            adapter.getLastName());
        }
    }
}
