﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class EvenNumbers: NaturalNumbers
    {
        public EvenNumbers()
        {
            first = 2;
            increment = 2;
        }
        ////public override int GetNext(int x)
       // {
            //return x + 2;
           // return base.GetNext(x) + 1;//since GetNext in NaturalNumbers is x+1 then another + 1 = x+2
        //}
    }
}
