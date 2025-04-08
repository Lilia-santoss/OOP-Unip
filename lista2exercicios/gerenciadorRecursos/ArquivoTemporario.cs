using System;

public class ArquivoTemporario : RecursoBase
{
    private bool _disposed = false;

    public ArquivoTemporario()
    {
        Console.WriteLine("Criando arquivo temporário...");
    }

    protected override void Dispose(bool disposing)
    {
        if (_disposed) return;

        if (disposing)
        {
            Console.WriteLine("Fechando e removendo o arquivo temporário...");
        }

        _disposed = true;
        base.Dispose(disposing);
    }
}
