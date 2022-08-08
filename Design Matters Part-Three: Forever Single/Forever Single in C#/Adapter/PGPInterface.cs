using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface PGPInterface
    {
        void setName(String n);
        String getName();
    }
}
