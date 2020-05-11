using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            int zadanie = 1;

            void ui()
            {
                Console.WriteLine("Hi human gib weight.");
                Mol mol = new Mol();
                mol.weight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Weight of one is :" + "\n" + Convert.ToString(mol.WeightOfOne()));
            }
            
            
            //Init
            Mol carbon = new Mol();
            Mol oxygen = new Mol();
            Mol nitro = new Mol();
            Mol hydro = new Mol();
            Mol sulfur = new Mol();
            Mol cys = new Mol();
            Mol water = new Mol();

            carbon.weight = 12.0107;
            oxygen.weight = 15.9994;
            nitro.weight = 14.0067;
            hydro.weight = 1.00794;
            sulfur.weight = 32.065;

            cys.weight = carbon.weight * 3 + hydro.weight * 7 + nitro.weight + sulfur.weight + oxygen.weight * 2;
            water.weight = hydro.weight * 2 + oxygen.weight;

            

            // c3 h7 no2 s

             
    
            switch (zadanie)
            {
                case 0:
                    ui();
                    break;

                case 11:
                    double vaha = (((24.3 / cys.WeightOfOne()) - 1) * water.WeightOfOne());
                    Console.WriteLine(vaha);
                    break;

                case 10:
                    double meta = carbon.WeightOfOne() * 3 + hydro.WeightOfOne() * 7 + oxygen.WeightOfOne() * 2 + nitro.WeightOfOne() + sulfur.WeightOfOne();
                    double result = 0.000126 / meta - 1;

                    Console.WriteLine(result);
                    break;

                default:
                    Console.ReadLine();
                    break;
            }

    

        }

        
    }
}
