using System;
using System;

namespace Exercicio06
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número que corresponde a um dia da semana .(1 a 7)");
            int diaSemana = Convert.ToInt32(Console.Read());
            switch (diaSemana)
          {  
                case 1:
            Console.WriteLine("Domingo");
            break;
        case 2:
            Console.WriteLine("Segunda-feira");
            break;
        case 3:
            Console.WriteLine("Terça-feira");
            break;
        case 4:
            Console.WriteLine("Quarta-feira");
            break;
            case 5:
                Console.WriteLine("quinta - feira");
                break;
        case 6:
            Console.WriteLine("sexta-feira");
            break;
        case 7:
            Console.WriteLine("sábado");
            break;
default:
Console.WriteLine("este não é um diaválido ");
break;
        }
    }
}
}
