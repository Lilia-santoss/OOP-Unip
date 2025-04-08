class Program
{
    static void Main()
    {
        Console.WriteLine("== Início ==");

        using (var conexao = new GerenciadorConexao())
        {
            conexao.Executar("SELECT * FROM Produtos");
        }

        Console.WriteLine("== Fim do using ==");

        // Apenas para ver o finalizador em ação (se Dispose não for chamado)
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("== Fim do programa ==");
    }
}
