using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo.Models
{
    public class Aluno : Pessoa // Herança
    {
        // public Aluno(string nome) : base(nome) // Herdando um construtor
        // {

        // }
        public double Nota { get; set; }

        public override void Apresentar() // a palavra chave "override" é utilizada para sobreescrever um método
        {            
            
            Console.WriteLine($"Meu nome é {Nome}, tenho {Idade} anos, e tirei nota {Nota}");
            
        }
    }
}