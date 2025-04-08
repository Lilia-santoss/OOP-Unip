using System;

public class GerenciadorConexaoBD : IDisposable
{
    private bool _disposed = false;

    public GerenciadorConexaoBD()
    {
        Console.WriteLine("Conexão com banco de dados aberta.");
    }

    public void ExecutarConsulta(string sql)
    {
        if (_disposed)
            throw new ObjectDisposedException(nameof(GerenciadorConexaoBD));

        Console.WriteLine($"Executando SQL: {sql}");
    }

    // Método Dispose público
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    // Método Dispose protegido
    protected virtual void Dispose(bool disposing)
    {
        if (_disposed) return;

        if (disposing)
        {
            // Liberação de recursos gerenciados
            Console.WriteLine("Fechando conexão (recursos gerenciados)...");
        }

        // Liberação de recursos não gerenciados (se houver)
        Console.WriteLine("Limpando recursos não gerenciados (simulado).");

        _disposed = true;
    }

    // Finalizador
    ~GerenciadorConexaoBD()
    {
        Dispose(false);
    }
}
