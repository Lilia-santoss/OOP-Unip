using System;

public abstract class RecursoBase : IDisposable
{
    private bool _disposed = false;

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_disposed) return;

        if (disposing)
        {
            Console.WriteLine("Liberando recursos da classe base...");
        }

        _disposed = true;
    }

    ~RecursoBase()
    {
        Dispose(false);
    }
}
