// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;
using ExemploFundamentos.Common.Models;

/*Console.WriteLine("Hello, World!");
Console.WriteLine("Teste");

Pessoa p = new Pessoa();

p.Nome = "Willie";
p.Idade = 25;

p.Apresentar();

double altura = 1.80;

Console.WriteLine(altura.ToString("0.00"));

DateTime dataAtual = DateTime.Now.AddDays(7);

Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));  */

// Casting

// int a = Convert.ToInt32("5");
// int b = int.Parse("7");
// string c = a.ToString();

// Console.WriteLine(a);
// Console.WriteLine(b);
// Console.WriteLine(c);

// int.TryParse(c, out a);

// Console.WriteLine(a);

// ================== condição (if) ========================

// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 3;
        
// if (quantidadeCompra <= 0)
// {
//     Console.WriteLine("Venda inválida!");
// }
// else if (quantidadeEmEstoque >= quantidadeCompra ) 
// {
//     Console.WriteLine("Venda realizada!");
// }
// else
// {
//     Console.WriteLine("Desculpe, quantidade insuficiente!");
// }

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
//     {
//         Console.WriteLine("É uma vogal!");
//     }
//     else
//     {
//         Console.WriteLine("Não é uma vogal");
//     }

// switch(letra)
//     {
//         case "a":           
//         case "e":
//         case "i":
//         case "o":
//         case "u":
//         Console.WriteLine("É uma vogal");
//         break;
        
//         default:
//         Console.WriteLine("Não é uma vogal");
//         break;
//     }


// ===================== funções matemáticas =====================

// Calculadora calc = new Calculadora();

// calc.Somar(12, 12);

// calc.Potencia(3, 3);

// calc.Raiz(30);  

// // =============== Laços de repetição ===================

// int numero = 5;
// int cont = 0;

// Console.WriteLine("For");
    
// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }
    
// Console.WriteLine("While");
    
//  while(cont <= 10)
// {
//     Console.WriteLine($"{numero} x {cont} = {numero * cont}");
//     cont++;

//     if(cont == 9)
//     {
//         break;
//     }
    
// }

// Console.WriteLine("Do While");

// int soma = 0;
// int num = 0;

// do
// {
// Console.WriteLine("Digite um número");
// num = int.Parse(Console.ReadLine());
// soma += num;

// } while(num != 0);

// Console.WriteLine($"O total da soma dos números digitados é: {soma}");

// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     Console.WriteLine("Digite uma opção");
//     Console.WriteLine("1 - Cadastro de cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Deletar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;
//         case "2":
//             Console.WriteLine("Buscar cliente");
//             break;
//         case "3":
//             Console.WriteLine("Deletar cliente");
//             break;
//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             break;
        
//         default:
//             Console.WriteLine("Opção inválida");
//             break;

//     }
// }

//================== Array =========================

// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 20;
// arrayInteiros[1] = 21;
// arrayInteiros[2] = 22;
// //arrayInteiros[3] = 23;

// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// Console.WriteLine("Percorrendo o array com FOR");

// for(int cont = 0; cont < arrayInteiros.Length; cont++)
// {
//     Console.WriteLine($"{arrayInteiros[cont]}");
// }

// Console.WriteLine("Percorrendo o array com FOREACH");

// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"{valor}");
// }

// ===================== Listas ==========================

List<string>listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("GO");

for(int count = 0; count < listaString.Count; count++)
{
    Console.WriteLine(listaString[count]);
}

