class Program
{
    static void Main()
    {
        Console.WriteLine("=== USO NORMAL ===");

        using (var arquivo = new RecursoArquivo())
        using (var banco = new RecursoBancoDados())
        {
            arquivo.Ler();
            banco.ExecutarConsulta();
        }

        Console.WriteLine("\n=== USO COM EXCEÇÃO ===");

        try
        {
            using (var arquivo = new RecursoArquivo())
            using (var banco = new RecursoBancoDados())
            {
                banco.ExecutarConsulta();
                throw new Exception("Erro durante operação!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[Exceção capturada]: {ex.Message}");
        }

        Console.WriteLine("\n=== FIM ===");

        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}

