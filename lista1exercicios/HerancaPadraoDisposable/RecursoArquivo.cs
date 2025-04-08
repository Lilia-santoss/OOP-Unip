public class RecursoArquivo : RecursoBase
{
    private bool _disposed = false;

    public RecursoArquivo()
    {
        Console.WriteLine("[RecursoArquivo] Arquivo aberto.");
    }

    public void Ler()
    {
        Console.WriteLine("[RecursoArquivo] Lendo dados do arquivo...");
    }

    protected override void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
                Console.WriteLine("[RecursoArquivo] Liberando recursos gerenciados.");

            Console.WriteLine("[RecursoArquivo] Liberando recursos não gerenciados.");
            _disposed = true;
        }

        base.Dispose(disposing); // chama Dispose da base
    }

    ~RecursoArquivo()
    {
        Console.WriteLine("[RecursoArquivo] Finalizador chamado.");
        Dispose(false);
    }
}
