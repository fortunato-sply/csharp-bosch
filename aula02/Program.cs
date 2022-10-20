Console.WriteLine("Hello, World!");

Pessoa p1 = new Pessoa("Lucas", "Xispita", 34556);
Console.WriteLine(p1.Saldo);

Pessoa p2 = p1;
p2.Saldo = 80;
Console.WriteLine(p1.Saldo);