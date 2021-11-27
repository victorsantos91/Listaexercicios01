using System;

namespace Exercicio08
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Para saber o tipo de um determinado triângulo, informe o comprimento de seus lados, lado 1:");
            double lado1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Agora digite o comprimento do segundo lado:");
            double lado2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por fim digite por gentileza o comprimento do terceiro lado do triângulo:");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            if (lado1 + lado2 > lado3 || lado2 + lado3>lado1||lado)
Console.WriteLine("Esteé um triângulo\n");
            if (lado1 == lado2 && lado1 == lado3)
                Console.WriteLine("Este é um triângulo equilátero ");
else
            {
                Console.WriteLine("este não é um triângulo");
            }
        }
    }
}
