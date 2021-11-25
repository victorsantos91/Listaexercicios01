using System;

namespace Exercicio03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite o preço do primeiro produto:");
            string? textoPreço01 = Console.ReadLine();
            Console.WriteLine("digite o preço  segundo produto:");
            string? textoPreço02 = Console.ReadLine();
            Console.WriteLine("digite o preço do terceiro produto :");
            string? textoPreço03 = Console.ReadLine();
            double preço1 = Convert.ToDouble(textoPreço01);
            double preço2 = Convert.ToDouble(textoPreço02);
            double preço3= Convert.ToDouble(textoPreço03);
            double menor = 0;
            if(preço1<preço2 &&preço1<preço3)
            {
                menor = preço1;
                Console.WriteLine("o produto 1 é o menor");
            }
            else if (preço2<preço1 && preço2 < preço3 )
            {
                menor = preço2;
                Console.WriteLine("o produto 2 é menor");
            }
            else
            {
                {
                    menor = preço3;
                    Console.WriteLine("o produto 3 é o menor ");
                }
                
            }

        }
    }
}

