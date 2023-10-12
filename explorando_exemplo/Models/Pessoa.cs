using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace explorando_exemplo.Models
{
    public class Pessoa
    {   
        public Pessoa()
        {

        }   
        public Pessoa(string nome, string sobrenome) //passando os parâmetros no construtor
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private string _nome;
        private string _sobrenome;
        private int _idade;
        public string Nome 
        {
            
            //get => _nome.ToUpper(); é o mesmo que return
            get
            {
                return _nome.ToUpper(); // retorna todo o valor da string em maíusculo
            }

            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio!");
                }
                _nome = value;  
            } 
        }

        public string Sobrenome 
        {   
            get => _sobrenome;
            
        
            set
            {
                _sobrenome = value;
            }
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}";

        public int Idade 
        {
            get => _idade;

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("O número não pode ser negativo!");
                }
                _idade = value;
            } 
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }

    }
}