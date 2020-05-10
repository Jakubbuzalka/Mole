using System;
using System.Collections.Generic;
using System.Text;

namespace Calc
{
    class Mol
    {
        private double avgConst = 6.022 * Math.Pow(10, 23);
        public double weight;

        public double WeightOfOne()
        {
            double result;
            result = weight / avgConst;

            return result;
        }
        
    }
}
