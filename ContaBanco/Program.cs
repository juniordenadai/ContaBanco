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
            double saldo;
            double deposito;
            double saque;
            Console.Write(" Entre com o numero da conta ");
            numero = int.Parse(Console.ReadLine());
            Console.Write(" Entre com o nome do Titular ");
            nome = Console.ReadLine();
            Console.Write("Haverá deposito inicial? (S/N) ");
            dep = char.Parse(Console.ReadLine());
            if (dep == 'S' || dep =='s')
            {
                Console.Write(" Entre com o valor inicial ");
                saldo = double.Parse(Console.ReadLine());
            }
            else
            {
                saldo = 0.00;
            }
            Conta conta = new Conta(numero, nome, saldo);
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine("Conta " + conta.Numero + " Nome do Titular: " + conta.Nome + " Saldo Atual: " + conta.Saldo);

            Console.Write("Valor a Depositar: ");
            deposito = double.Parse(Console.ReadLine());
            conta.Deposito(deposito);
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine("Conta " + conta.Numero + " Nome do Titular: " + conta.Nome + " Saldo Atual: " + conta.Saldo);

            Console.Write("Valor a Sacar: ");
            saque = double.Parse(Console.ReadLine());
            conta.Saque(saque);
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine("Conta " + conta.Numero + " Nome do Titular: " + conta.Nome + " Saldo Atual: " + conta.Saldo);

        }
    }
}
