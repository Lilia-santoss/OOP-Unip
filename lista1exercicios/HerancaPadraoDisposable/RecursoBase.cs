using System;

public abstract class RecursoBase : IDisposable
{
    private bool _disposed = false;

    public RecursoBase()
    {
        Console.WriteLine("[RecursoBase] Inicializado.");
    }

    public void Dispose()
    {
        Console.WriteLine("[RecursoBase] Dispose chamado.");
        Dispose(true);
        GC.SuppressFinalize(this); // evita que o finalizador rode
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                Console.WriteLine("[RecursoBase] Liberando recursos gerenciados.");
            }

            Console.WriteLine("[RecursoBase] Liberando recursos não gerenciados.");
            _disposed = true;
        }
    }

    ~RecursoBase()
    {
        Console.WriteLine("[RecursoBase] Finalizador chamado.");
        Dispose(false);
    }
}
