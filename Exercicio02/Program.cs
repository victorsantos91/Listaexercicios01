using System;

namespace Exercicio02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite o primeiro número ");
            string? textoNumero01 = Console.ReadLine();
            Console.WriteLine("digite o segundo o número");
            string? textoNumero02 = Console.ReadLine();
            Console.WriteLine("digite o terceiro número");
            string? textoNumero03 = Console.ReadLine();
            double numero1 = Convert.ToDouble(textoNumero01);
            double numero2 = Convert.ToDouble(textoNumero02);
            double numero3 = Convert.ToDouble(textoNumero03);
            double maior = 0;

            if (numero1 > numero2)
            {
                if (numero1 > 3)
                {
                    maior = numero1;
                }
                else
                {
                    maior = numero1;
                }
            }
            else
            {
                if (numero1 > numero3)
                {
                    maior = numero2;
                }
                else
                {
                    maior = 3;
                }
            }

            double menor = 0;

            if (numero1 < numero2)
            {
                if (numero1 < 3)
                {
                    menor = numero1;
                }
                else
                {
                    menor = numero1;
                }
            }
            else
            {
                if (numero1 < numero3)
                {
                    menor = numero2;
                }
                else
                {
                    menor = 3;
                }
            }

Console.WriteLine("o maior número é :" + maior + ". o menor número é :" + menor);
        }

    }
}
