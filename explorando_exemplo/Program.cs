using System.Runtime.Serialization;
using System.Security.Cryptography;
using explorando_exemplo.Models;
using System.Globalization;
using Newtonsoft.Json;

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

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2); // acrescentar
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}"); // remove o primeiro elemento

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// ===================== Pilha ======================

// Console.WriteLine("Pilhas");

// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int i in pilha)
// {
//     Console.WriteLine(i);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
// pilha.Push(20);

// foreach(int i in pilha)
// {
//     Console.WriteLine(i);
// }

//==================== Dictionary =======================

// Console.WriteLine("Dicionário");

// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São paulo");
// estados.Add("GO", "Goiás");
// estados.Add("BA", "Bahia");

// foreach(KeyValuePair<string, string> itens in estados)
// {
//     Console.WriteLine($"Chave: {itens.Key}, e o valor: {itens.Value}");
// }

// Console.WriteLine("Removar elemento do Dictionary");

// estados.Remove("SP");

// foreach(KeyValuePair<string, string> itens in estados)
// {
//     Console.WriteLine($"Chave: {itens.Key}, e o valor: {itens.Value}");
// }

// Console.WriteLine("Alterando os dados de um elemento de um Dictionary");

// estados["GO"] = "Goiás - valor alterado";

// foreach(KeyValuePair<string, string> itens in estados)
// {
//     Console.WriteLine($"Chave: {itens.Key}, e o valor: {itens.Value}");
// }

// // Validando Dictionary

// string chave = "GO";
// Console.WriteLine($"Verificando o elemento {chave}");

// if(estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave} "); 
// }

// ======================== Tuplas =========================

// (int, string, string, decimal) tupla = (25, "Willie", "Barbosa Lima", 1.71M);
// ValueTuple<int, string, string, decimal> outroExemplo = (1, "Willie", "Lima", 1.71M); //outras sintaxes da tupla
// var outroExemploTupla = Tuple.Create(1, "Willie", "Lima", 1.71M); //outras sintaxes da tupla

// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");

// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt"); //para descartar um elemento da tupla substitua o elemento por um _

// if(sucesso)
// {
//     Console.WriteLine($"Quantidade de linhas: {quantidadeLinhas}");
//     foreach(string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo!");
// }

// ===================== Desconstrutor =====================

// Pessoa p1 = new Pessoa("Willie", "Lima");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"Nome: {nome}, Sobrenome: {sobrenome}");

// =================== If Ternário ==========================

// int numero = 20;
// bool ehPar = true;

// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é ímpar");
// }

// =============== Refatoração com If Ternário =======================

// ehPar = numero % 2 == 0;

// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));



// ========================= Nuget, serialização ====================

// ========================= Serializando ========================

// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de software", 150.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string json = JsonConvert.SerializeObject(listaVendas, Formatting.Indented); //Serializar um objeto para o tipo de arquivo .json

// File.WriteAllText("Arquivos/vendas.json", json); //criar um novo arquivo do tipo Json

// Console.WriteLine(json);

// ========================== Deserializando ==========================

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach(Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}


