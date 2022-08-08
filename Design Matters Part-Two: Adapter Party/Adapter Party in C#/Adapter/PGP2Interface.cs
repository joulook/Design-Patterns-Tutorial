using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    interface PGP2Interface
    {
        void setFirstName(String f);
        void setLastName(String l);
        String getFirstName();
        String getLastName();
    }
}
