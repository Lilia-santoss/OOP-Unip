public class PagamentoCartao : IProcessadorPagamento
{
    public bool ProcessarPagamento(decimal valor)
    {
        Console.WriteLine($"Pagamento de R${valor} processado via Cartão.");
        return true;
    }

    public void Dispose()
    {
        Console.WriteLine("Liberação de recursos de cartão.");
    }
}
