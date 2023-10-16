using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo.Models
{
    public abstract class Conta
    {
        protected decimal _saldo; //protected protege de alterações externas, 
        //porém permite alteração por parte das classes filhas

        public abstract void Creditar(decimal valor); //a palavra abstract obriga que a classe que a
        //herdar, implemente o método.

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo: {_saldo}");
        }
    }
}