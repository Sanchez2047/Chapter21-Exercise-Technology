using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public abstract class AbstractEntity
    {
        public static List<int> Ids = new List<int>();
        public static int counter = 0;

        private int _uniqueId = 0;

        public int UniqueId
        {
            get { return _uniqueId; }
        }

        public AbstractEntity()
        {
            counter++;
            _uniqueId = counter;
        }
    }
}
