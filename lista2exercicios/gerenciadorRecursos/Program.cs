using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Exemplo com using ===");
        using (var conexao = new GerenciadorConexaoBD())
        {
            conexao.ExecutarConsulta("SELECT * FROM Usuarios");
        }

        Console.WriteLine("\n=== Exemplo com try/finally ===");
        GerenciadorConexaoBD conexaoManual = null;
        try
        {
            conexaoManual = new GerenciadorConexaoBD();
            conexaoManual.ExecutarConsulta("SELECT * FROM Produtos");
        }
        finally
        {
            conexaoManual?.Dispose();
        }

        Console.WriteLine("\n=== Exemplo com herança de IDisposable ===");
        using (var recurso = new ArquivoTemporario())
        {
            Console.WriteLine("Usando arquivo temporário...");
        }

        Console.WriteLine("\n=== Exceção dentro do using ===");
        try
        {
            using (var conexaoEx = new GerenciadorConexaoBD())
            {
                conexaoEx.ExecutarConsulta("SELECT * FROM Pedidos");
                throw new Exception("Erro simulado durante a execução!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exceção capturada: {ex.Message}");
        }
    }
}

