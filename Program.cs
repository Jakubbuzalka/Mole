using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ui = false;

            if (ui)
            {
                Console.WriteLine("Hi human gib weight.");
                Mol mol = new Mol();
                mol.weight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Weight of one is :"+"\n"+ Convert.ToString(mol.WeightOfOne()));

            }else
            {
                Mol carbon = new Mol();
                Mol oxygen = new Mol();
                Mol nitro = new Mol();
                Mol hydro = new Mol();
                Mol sulfur = new Mol();

                carbon.weight = 12.0107;
                oxygen.weight = 15.9994;
                nitro.weight = 14.0067;
                hydro.weight = 1.00794;
                sulfur.weight = 32.065;

                // c3 h7 no2 s

                double meta = carbon.WeightOfOne() * 3 + hydro.WeightOfOne() * 7 + oxygen.WeightOfOne() * 2 + nitro.WeightOfOne() + sulfur.WeightOfOne();
                double result = 0.000126 / meta - 1;

                Console.WriteLine(result);
                Console.ReadLine();
            }

            

        }

        
    }
}
