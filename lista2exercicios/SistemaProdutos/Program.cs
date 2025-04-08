using System;

class Program
{
    static void Main()
    {
        try
        {
            // Criando produtos com diferentes construtores
            Produto p1 = new Produto(1, "Notebook", 3500.00m, 5);
            Produto p2 = new Produto(2, "Mouse", 50.00m, 0);
            Produto p3 = new Produto(3, "Teclado");

            // Exibindo os produtos
            Console.WriteLine("Produtos cadastrados:\n");
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            // Testando validações
            Console.WriteLine("\n--- Testes de validação ---");
            Produto invalido = new Produto();
            invalido.Codigo = 4;
            invalido.Nome = "";          // Deve lançar exceção
            invalido.Preco = -100;       // Deve lançar exceção
            invalido.Estoque = -10;      // Deve lançar exceção
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}

