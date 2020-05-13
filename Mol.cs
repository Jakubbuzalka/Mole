using System;
using System.Collections.Generic;
using System.Text;

namespace Calc
{
    class Mol
    {
        private double avgConst = 6.022 * Math.Pow(10, 23);
        public double weight;
        public double density;
        

        public double WeightOfOne()
        {
            double result;
            result = weight / avgConst;

            return result;
        }
        public double Volume()
        {
            double result;
            result = weight / density;

            return result;
        }
        public double Lenght()
        {
            double result;
            result = Math.Cbrt(Volume() / avgConst);

            return result;
        }
        
    }
}
