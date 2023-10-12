using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace explorando_exemplo.Models
{
    public class Curso
    {        
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }
        
        public void AdicionarAluno(Pessoa aluno) // adicionando uma variável do mesmo tipo da lista ou string
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            
            return quantidade;
        }

        public bool RemovarAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAluno()
        {   
            Console.WriteLine($"Alunos do curso de {Nome}");
            
            for(int cont = 0; cont < Alunos.Count; cont++)
            {
                string texto = "Nº" + cont+1 + " - " + Alunos[cont].NomeCompleto;
                Console.WriteLine(texto);
            }

            // foreach(Pessoa aluno in Alunos)
            // {
            //     Console.WriteLine(aluno.NomeCompleto);
            // }
        }

        
    }
}