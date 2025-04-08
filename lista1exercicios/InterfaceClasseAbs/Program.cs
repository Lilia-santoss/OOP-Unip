using System;

class Program
{
    static void Main(string[] args)
    {
        var repoClientes = new RepositorioCliente();
        repoClientes.Create(new Cliente { Id = 1, Nome = "Ana" });
        repoClientes.Create(new Cliente { Id = 2, Nome = "Bruno" });

        var repoProdutos = new RepositorioProduto();
        repoProdutos.Create(new Produto { Id = 1, Descricao = "Mouse" });
        repoProdutos.Create(new Produto { Id = 2, Descricao = "Teclado" });

        var repoSimples = new RepositorioSimples<string>();
        repoSimples.Create("Teste 1");
        repoSimples.Create("Teste 2");

        Console.WriteLine("📋 Clientes:");
        foreach (var c in repoClientes.ListarTodos())
            Console.WriteLine($"- {c.Id}: {c.Nome}");

        Console.WriteLine("\n📦 Produtos:");
        foreach (var p in repoProdutos.ListarTodos())
            Console.WriteLine($"- {p.Id}: {p.Descricao}");

        Console.WriteLine("\n🧪 Repositório Simples:");
        foreach (var item in repoSimples.ListarTodos())
            Console.WriteLine($"- {item}");
    }
}

