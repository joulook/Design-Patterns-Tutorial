using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Adabas
    {

        private static Adabas SingleObject { get; set; }
        private string name;
        private int record;

        private Adabas(string n)
        {
            name = n;
            record = 0;
        }

        public string Name { get { return name; } set { name = value; } }
        public static Adabas getInstance(string n)
        {
            if (SingleObject == null)
            {
                SingleObject = new Adabas(n);
            }
            return SingleObject;
        }
    }
}
