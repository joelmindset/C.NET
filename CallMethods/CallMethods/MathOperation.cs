using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallMethods
{
    public class MathOperation
    {
        // times perimeters 
        public int getMulti(int X, int A)
        {
            return X * A;
        }
        // divide perimeters
        public int getDiv(int X, int A)
        {
            return X / A;
        }
        // add perimeters
        public int getAdd(int X, int A)
        {
            return X + A;
        }
        // minus perimeters
        public int getMinus(int X, int A)
        {
            return X - A;
        }
    }
}
