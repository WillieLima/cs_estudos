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

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); //alterando a cultura de todo o sistema

// decimal valorMonetario = 82.40M;
// Console.WriteLine($"{valorMonetario:c}");

//Console.WriteLine(valorMonetario.ToString("c", CultureInfo.CreateSpecificCulture("en-US")));
// formatando moeda alterando só a linha

//Console.WriteLine(valorMonetario.ToString("c1" ou "n1")); número de casas, C representa moeda, e N número comum

// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("p")); // porcentagem

// int numero1 = 123456;
// Console.WriteLine(numero1.ToString("##-##-##")); // separando por dígitos

// DateTime data = DateTime.Now;
// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

// string dataString = "2022-04-17 18:00";
// DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", 
//                         CultureInfo.InvariantCulture, 
//                         DateTimeStyles.None, 
//                         out DateTime data2);
// Console.WriteLine(data2); //Convertendo com tryparse.

//======================== Exceções ==========================

//======================= Try catch ==========================

// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/d/arquivo_Leitura.txt");

//     foreach(string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }

// }catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Diretório não encontrado. {ex.Message}");
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica: {ex.Message}");
// }
// finally
// {
// Console.WriteLine("Programa continua rodando");
// }

// ======================== Fila ============================

Queue<int> fila = new Queue<int>();

fila.Enqueue(2); // acrescentar
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach(int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}"); // remove o primeiro elemento

foreach(int item in fila)
{
    Console.WriteLine(item);
}

// ===================== Pilha ======================

Console.WriteLine("Pilhas");

Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach(int i in pilha)
{
    Console.WriteLine(i);
}

Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
pilha.Push(20);

foreach(int i in pilha)
{
    Console.WriteLine(i);
}

//==================== Dictionary =======================

Console.WriteLine("Dicionário");

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São paulo");
estados.Add("GO", "Goiás");
estados.Add("BA", "Bahia");

foreach(KeyValuePair<string, string> itens in estados)
{
    Console.WriteLine($"Chave: {itens.Key}, e o valor: {itens.Value}");
}

Console.WriteLine("Removar elemento do Dictionary");

estados.Remove("SP");

foreach(KeyValuePair<string, string> itens in estados)
{
    Console.WriteLine($"Chave: {itens.Key}, e o valor: {itens.Value}");
}

Console.WriteLine("Alterando os dados de um elemento de um Dictionary");

estados["GO"] = "Goiás - valor alterado";

foreach(KeyValuePair<string, string> itens in estados)
{
    Console.WriteLine($"Chave: {itens.Key}, e o valor: {itens.Value}");
}

// Validando Dictionary

string chave = "GO";
Console.WriteLine($"Verificando o elemento {chave}");

if(estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave} "); 
}
