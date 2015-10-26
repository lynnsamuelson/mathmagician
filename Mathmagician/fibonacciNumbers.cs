using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class FibonacciNumbers : NaturalNumbers
    {
        public FibonacciNumbers()
        {
            first = 0;    
            increment = 2;
        }

        public override int GetNext(int x)
        {
            return (x - 1) + (x - 2);
        }

    }
}