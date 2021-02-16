using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBanco
{
    class Conta
    {
        private string _nome;
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

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }

        }

        public void Deposito (double deposito)
        {
            Saldo = Saldo + deposito;

        }
       
        public void Saque (double saque)
        {
            Saldo = Saldo - (saque + tarifa);

        }

    }

}
