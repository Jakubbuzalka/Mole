using System;

namespace Calc
{
    class Program
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


        static void Main(string[] args)
        {
            Console.WriteLine("Hi human gib weight.");
            Mol mol = new Mol();
            mol.weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Weight of one is :"+"\n"+ Convert.ToString(mol.WeightOfOne()));
        }

        
    }
}
