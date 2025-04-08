public class RecursoBancoDados : RecursoBase
{
    private bool _disposed = false;

    public RecursoBancoDados()
    {
        Console.WriteLine("[RecursoBancoDados] Conexão aberta.");
    }

    public void ExecutarConsulta()
    {
        Console.WriteLine("[RecursoBancoDados] Executando consulta...");
    }

    protected override void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
                Console.WriteLine("[RecursoBancoDados] Liberando recursos gerenciados.");

            Console.WriteLine("[RecursoBancoDados] Liberando recursos não gerenciados.");
            _disposed = true;
        }

        base.Dispose(disposing);
    }

    ~RecursoBancoDados()
    {
        Console.WriteLine("[RecursoBancoDados] Finalizador chamado.");
        Dispose(false);
    }
}
