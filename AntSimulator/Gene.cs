using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntSimulator
{
    public class Gene
    {
        public int type;
        public Gene left;
        public Gene right;

        public Gene(int type)
        {
            this.type = type;
            left = null;
            right = null;
        }
    }
}
