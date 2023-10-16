using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            _saldo = saldoInicial; 
        }
        public int NumeroConta { get; set; }
        private decimal _saldo;

        public void Saque(decimal valor)
        {
            if(valor <= _saldo)
            {
                _saldo -= valor;
                Console.WriteLine("Saque realizado.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }  
        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo disponível: {_saldo}");
        } 
    }
}