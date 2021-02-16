using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBanco
{
    class Conta
    {
        public string Nome { get; set; }
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        public const int tarifa = 5;

        public Conta(int numero, string nome, double saldo)
        {
            Numero = numero;
            Nome = nome;
            Saldo = saldo;

        }

        public Conta(int numero, string nome)
        { 
            Numero = numero;
            Nome = nome;
        }

  
        public void Deposito (double deposito)
        {
            Saldo += deposito;

        }
       
        public void Saque (double saque)
        {
            Saldo -= saque + tarifa;

        }

        public override string ToString()
        {
            return "Conta " 
                + Numero 
                + " Nome do Titular: " 
                + Nome 
                + " Saldo Atual: " 
                + Saldo.ToString("F2");
        }

    }

}
