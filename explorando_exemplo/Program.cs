using System.Runtime.Serialization;
using System.Security.Cryptography;
using explorando_exemplo.Models;
using System.Globalization;

// ================== Propriedades e campos ==================

//Pessoa p1 = new Pessoa();
// Console.WriteLine("Digite o seu primeiro nome");
// p1.Nome = Console.ReadLine();
// Console.WriteLine("Digite o seu sobrenome");
// p1.Sobrenome = Console.ReadLine();
// Console.WriteLine("Digite a sua idade");
// p1.Idade = int.Parse(Console.ReadLine());
// p1.Apresentar();

// ===================== Métodos ==================

// p1.Nome = "Willie";
// p1.Sobrenome = "Lima";

// Pessoa p2 = new Pessoa(nome: "Amanda", sobrenome:"Lima"); //passando os parâmetros no construtor.

// Curso c1 = new Curso();

// c1.Nome = "Inglês";
// c1.Alunos = new List<Pessoa>(); 

// c1.AdicionarAluno(p1);
// c1.AdicionarAluno(p2);
// c1.ListarAluno();

// ================ Manipulando valores =====================

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); //alterando a cultura de todo o sistema

decimal valorMonetario = 82.40M;
Console.WriteLine($"{valorMonetario:c}");

//Console.WriteLine(valorMonetario.ToString("c", CultureInfo.CreateSpecificCulture("en-US")));
// formatando moeda alterando só a linha

//Console.WriteLine(valorMonetario.ToString("c1" ou "n1")); número de casas, C representa moeda, e N número comum

double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("p")); // porcentagem

int numero1 = 123456;
Console.WriteLine(numero1.ToString("##-##-##")); // separando por dígitos

DateTime data = DateTime.Now;
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

string dataString = "2022-04-17 18:00";
DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", 
                        CultureInfo.InvariantCulture, 
                        DateTimeStyles.None, 
                        out DateTime data2);
Console.WriteLine(data2); //Convertendo com tryparse.