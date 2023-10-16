using poo.Models;

// ===================== Encapsulamento, Herança e Polimorfismo =======================

// ContaCorrente c1 = new ContaCorrente(123, 1100.00M);

// c1.Saque(200);

// c1.ExibirSaldo();

// Aluno a1 = new Aluno();

// a1.Nome = "Willie";
// a1.Idade = 25;
// a1.Nota = 10;
// a1.Apresentar();

// Professor p1 = new Professor();

// p1.Nome = "Eduardo";
// p1.Idade = 30;
// p1.Salario = 3000;
// p1.Apresentar();

// ======================= Classe Abstrata ==================

Corrente contaCorrente = new Corrente();

contaCorrente.Creditar(1200);
contaCorrente.ExibirSaldo();

contaCorrente.ToString();