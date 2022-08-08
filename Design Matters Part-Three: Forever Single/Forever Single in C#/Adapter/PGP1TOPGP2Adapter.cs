using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class PGP1TOPGP2Adapter : PGP2Interface
    {

        PGPClass pgpObject;
        string fname;
        string lname;

        public PGP1TOPGP2Adapter(PGPClass a)
        {
            pgpObject = a;
            fname = pgpObject.getName().Split(' ')[0];
            lname = pgpObject.getName().Split(' ')[1];

        }
        
        public string getFirstName()
        {
            return fname;
        }

        public string getLastName()
        {
            return lname;
        }

        public void setFirstName(string f)
        {
            fname = f;
        }

        public void setLastName(string l)
        {
            lname = l;
        }
    }
}
