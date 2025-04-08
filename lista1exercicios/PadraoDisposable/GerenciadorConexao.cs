using System;

public class GerenciadorConexao : IDisposable
{
    private bool _disposed = false; // Flag para evitar múltiplos Dispose
    private IntPtr _recursoNaoGerenciado; // Simulação de recurso nativo

    public GerenciadorConexao()
    {
        Console.WriteLine("[LOG] Conexão criada.");
        _recursoNaoGerenciado = new IntPtr(123); // Simulação
    }

    public void Executar(string comando)
    {
        if (_disposed)
            throw new ObjectDisposedException(nameof(GerenciadorConexao));

        Console.WriteLine($"[LOG] Executando: {comando}");
    }

    public void Dispose()
    {
        Console.WriteLine("[LOG] Dispose() chamado manualmente.");
        Dispose(true);
        GC.SuppressFinalize(this); // evita chamada do finalizador
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                Console.WriteLine("[LOG] Liberando recursos gerenciados...");
            }

            Console.WriteLine("[LOG] Liberando recurso não gerenciado...");
            _recursoNaoGerenciado = IntPtr.Zero;

            _disposed = true;
        }
    }

    ~GerenciadorConexao()
    {
        Console.WriteLine("[LOG] Finalizador chamado!");
        Dispose(false);
    }
}
