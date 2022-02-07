using System;
using System.Globalization;
namespace ExercicioDeFixação
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria b;
            Console.Write("Entre com o número da conta: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá deposito inicial? (s/n) ");
            string text = Console.ReadLine();
            if (text == "s" || text == "S")
            {
                Console.Write("Entre com o valor inicial: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                b = new ContaBancaria(nome, num, valor);
              
            }
            else
            {
                b = new ContaBancaria(nome, num);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(b);

            Console.Write("Entre com o valor do depósito: ");
            double d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.deposito(d);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(b);
            
            Console.WriteLine();
            Console.Write("Entre com o valor do Saque: ");
            double s = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.saque(s);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(b);



        }
    }
}
