namespace Exercicio02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu valor  de hora:");
            double valorHora = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade travalhadas ");
            int quantidadeHoras = Convert.ToInt32(Console.Read());
            double salarioBruto = valorHora * quantidadeHoras;
            double descontoSindicato = salarioBruto * 0.03;
            double descontoInss = salarioBruto * 0.11;
            double fgts = salarioBruto * 0.08;
            double descontoIr = 0;
            double percentualDescontoIr = 0;
            if (salarioBruto > 2000 && salarioBruto <= 5000)
                percentualDescontoIr = 0.05;
            else if (salarioBruto >= 7500)
                percentualDescontoIr = 0.1;
            else if (salarioBruto > 75000)
                percentualDescontoIr = 0.2;

            if (percentualDescontoIr != 0)
                descontoIr = salarioBruto * percentualDescontoIr;
            double salarioLiquido = salarioBruto - descontoSindicato - descontoIr - descontoInss;
            Console.WriteLine($"salário bruto: ({valorHora} * {quantidadeHoras}) : R${string.Format("{0:0.00}", salarioBruto)} \n" +
            $"(-) SINDICATO(3%) : {string.Format("{0:0.00}", descontoSindicato)} \n" +
            $"(-) INSS(11%) :{string.Format("{0:0.00}", descontoInss)}\n" +
            $"(-) IR ({percentualDescontoIr * 100}%) {string.Format("{0:0.00}", percentualDescontoIr)}\n" +
            $"fgts (8%) : {string.Format("{0:0.00}", fgts)}\n " +
             $"salario liquido : {string.Format("{0:0.00}", salarioLiquido)}");
        }


    }
}
