using System;

namespace EstruturasRepeticao
{
    public class Program
    {
        public static void Main(string[] args)
        {
Console.WriteLine("digite sua Primeira nota, pois queremos te informar sobre o conceito em que você entrou com base em sua média:");
double primeiraNota = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor da segunda nota, para que possamos calcular sua média ");
double segundaNota = Convert.ToDouble(Console.ReadLine());
double media = (primeiraNota + segundaNota) /2;
if (media>=9&&media<=10)
{
    Console.WriteLine("Suas notas foram as seguintes, a primeira " + primeiraNota + "e sua segunda nota foi :" + segundaNota + "sua média foi : " + media + " seu conceito foi: A, \n vocÊ foi aprovado ! " );
}
else if (media< 9 && media >=7.5)
Console.WriteLine("Suas notas foram as seguintes, a primeira " + primeiraNota + "e sua segunda nota foi :" + segundaNota + "sua média foi : " + media + " seu conceito foi: B, \n vocÊ foi aprovado ! ");
else if (media <7.5 &&media >=6)
Console.WriteLine("Suas notas foram as sseguintes, sendo a primeira" + primeiraNota + "e sua segunda nota foi :" + segundaNota + "sua média foi : " + media + " seu conceito foi: C, \n vocÊ foi aprovado ! ");
else if (media>=4&& media<6)
Console.WriteLine("Suas notas foram" + primeiraNota + "e sua segunda nota foi :" + segundaNota + "sua média foi : " + media + " seu conceito foi: D, \n vocÊ foi Reprovado, infelizmente ");
else 
Console.WriteLine("Suas notas foram as seguintes, sendo a primeira " + primeiraNota + "e sua segunda nota foi :" + segundaNota + "sua média foi : " + media + " seu conceito foi: E, \n vocÊ foi Reprovado, infelizmente ");
        }
    }
}
