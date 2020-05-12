using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            int zadanie = 0;

            Console.WriteLine("Hi human tell me do you want task [10] or [11] or [12] ?");
            try
            {
                zadanie = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Input must be positive integer !");
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
            cys.density = 1000;
           
            water.weight = hydro.weight * 2 + oxygen.weight;

            // c3 h7 no2 s
             
            switch (zadanie)
            {
                

                case 11:
                    double vaha = ((24.3 / cys.WeightOfOne()) - 1) * water.WeightOfOne();
                    
                    Console.WriteLine(vaha);
                    break;

                case 10:
                    double meta = carbon.WeightOfOne() * 3 + hydro.WeightOfOne() * 7 + oxygen.WeightOfOne() * 2 + nitro.WeightOfOne() + sulfur.WeightOfOne();
                    double result = 0.000126 / meta - 1;

                    Console.WriteLine(result);
                    break;

                case 12:
                    double numberOfMolecules = 24.3 / cys.WeightOfOne();
                    double hairLenght = cys.Lenght() * numberOfMolecules/ Math.Pow(10, 10);

                    Console.WriteLine(hairLenght);
                    break;

                default:
                    Console.ReadLine();
                    break;
            }

    

        }

        
    }
}
