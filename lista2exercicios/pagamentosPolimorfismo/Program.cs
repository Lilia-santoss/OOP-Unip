using System;

class Program
{
    static void Main()
    {
        var pagamentos = new Pagamento[]
        {
            new PagamentoCartao(120.00m, "Visa", "1234.5678.9012.3456", 3),
            new PagamentoBoleto(350.00m, "23791234567890123456789012345678901234567890", DateTime.Now.AddDays(5)),
            new PagamentoPix(89.90m, "email@cliente.com", "QRCodeExemplo123")
        };

        var processador = new ProcessadorPagamento();

        Console.WriteLine("==== Sistema de Pagamentos ====\n");

        foreach (var pagamento in pagamentos)
        {
            // polimorfismo em tempo de execução
            processador.ProcessarPagamento(pagamento);

            // polimorfismo em tempo de compilação (sobrecarga)
            // processador.ProcessarPagamento(pagamento, "Caixa 01");
        }
    }
}
