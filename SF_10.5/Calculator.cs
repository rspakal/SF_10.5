using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_10._5
{
    
    internal class Calculator : ISummable
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
