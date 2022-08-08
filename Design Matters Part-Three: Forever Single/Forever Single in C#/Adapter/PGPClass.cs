using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class PGPClass : PGPInterface
    {
        string name;
        public string getName()
        {
            return name;
        }

        public void setName(string n)
        {
            name = n;
        }
    }
}
