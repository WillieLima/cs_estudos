using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo.Models
{
    public sealed class Professor : Pessoa // sealed é a palavra chave para impedir que uma classe 
    //seja herdada
    {
        public decimal Salario { get; set; }

        public sealed override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}, tenho {Idade} anos e recebo {Salario}");
        }
    }
}