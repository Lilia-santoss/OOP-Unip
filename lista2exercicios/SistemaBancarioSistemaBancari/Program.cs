using System;

class Program
{
    static void Main(string[] args)
    {
        ContaBancaria conta1 = new ContaBancaria("001", "Alice");
        ContaBancaria conta2 = new ContaBancaria("002", "Bob");

        conta1.Depositar(1000);
        conta1.Sacar(200);

        conta2.Depositar(500);
        conta2.Sacar(50);

        Console.WriteLine($"Saldo de {conta1.Titular}: R${conta1.Saldo}");
        foreach (var t in conta1.VerExtrato())
            Console.WriteLine(t);

        Console.WriteLine();

        Console.WriteLine($"Saldo de {conta2.Titular}: R${conta2.Saldo}");
        foreach (var t in conta2.VerExtrato())
            Console.WriteLine(t);

        // Teste de encapsulamento (descomente para ver erro)
        // conta1._saldo = 999999; // ERRO: campo é privado
    }
}

