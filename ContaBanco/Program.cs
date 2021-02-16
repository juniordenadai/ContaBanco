using System;

namespace ContaBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string nome;
            char dep;
            double depositoInicial;
            double quantia;
            Conta conta;

            Console.Write(" Entre com o numero da conta ");
            numero = int.Parse(Console.ReadLine());
            Console.Write(" Entre com o nome do Titular ");
            nome = Console.ReadLine();
            Console.Write("Haverá deposito inicial? (S/N) ");
            dep = char.Parse(Console.ReadLine());
            if (dep == 'S' || dep =='s')
            {
                Console.Write(" Entre com o valor inicial ");
                depositoInicial = double.Parse(Console.ReadLine());
                conta = new Conta(numero, nome, depositoInicial);

            }
            else
            {
                conta = new Conta(numero, nome);
            }
            
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(conta);

            Console.Write("Valor a Depositar: ");
            quantia = double.Parse(Console.ReadLine());
            conta.Deposito(quantia);
            Console.WriteLine("Dados da Conta Atualizado: ");
            Console.WriteLine(conta);

            Console.Write("Valor a Sacar: ");
            quantia = double.Parse(Console.ReadLine());
            conta.Saque(quantia);
            Console.WriteLine("Dados da Conta Atualizado: ");
            Console.WriteLine(conta);

        }
    }
}
