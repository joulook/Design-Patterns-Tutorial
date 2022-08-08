using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class PGP2Class
    {
        String firstName;
        String lastName;
        public void setFirstName(String f)
        {
            firstName = f;
        }
        public void setLastName(String l)
        {
            lastName = l;
        }
        public String getFirstName()
        {
            return firstName;
        }
        public String getLastName()
        {
            return lastName;
        }
    }
}
