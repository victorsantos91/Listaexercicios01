using System;

namespace Exercicio04
{
    public class Program
    {
        public static void Main(string[] args)
        {
Console.WriteLine("Digite o salário que será reajustado:");
double salario = Convert.ToDouble(Console.ReadLine());            
double percentualReajuste = 0;
double valorAumento = 0;
double novoSalario = 0;

if (salario<2800)
{
    percentualReajuste = 0.2;
}
else if (salario>= 2800 &&salario<7000)
{
    percentualReajuste= 0.15;
}
else if (salario>= 7000 && salario<15000)
{
    percentualReajuste = 0.1;
}
else  
{
    percentualReajuste= 0.05;
}
valorAumento = percentualReajuste * salario;
novoSalario = valorAumento+ salario;
Console.WriteLine($"o salário original é{salario} . O percentual de reajuste é{percentualReajuste*100}. O valor real do aumento foi de {valorAumento}. o novo salário é :{novoSalario}  ");
        }        
    }
}
