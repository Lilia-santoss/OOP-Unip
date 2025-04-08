interface IProcessadorPagamento : IDisposable {
    void ProcessarPagamento(decimal valor);
}

class ProcessadorCartaoCredito : IProcessadorPagamento {
    public void ProcessarPagamento(decimal valor) {
        Console.WriteLine($"Pagando {valor:C} com Cartão de Crédito.");
    }

    public void Dispose() {
        Console.WriteLine("Fechando conexão com gateway de cartão...");
    }
}
