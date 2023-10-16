using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo.Models
{
    public class Pessoa
    {
        // public Pessoa(string Nome)
        // {
        //     Nome = Nome;
        // }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar() //a palavra chave "virtual" permite que o método serja sobreescrito
        {
            if(Nome != null && Idade != 0)
            {
                Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos!");
            }
            else
            {
                Console.WriteLine("Erro!");
            }
        }
    }
}