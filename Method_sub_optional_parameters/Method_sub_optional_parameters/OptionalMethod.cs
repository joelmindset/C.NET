using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_sub_optional_parameters
{
    class OptionalMethod
    {
        public int MathInt(int math1, int math2 = 2)
        {
            // times numbers
            return math1 * math2;
        }
    }
}
