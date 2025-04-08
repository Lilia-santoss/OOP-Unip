using System;

public class ProcessadorPagamento
{
    // Polimorfismo em tempo de execução
    public void ProcessarPagamento(Pagamento pagamento)
    {
        Console.WriteLine("Iniciando processamento...");
        pagamento.Processar();
        Console.WriteLine(pagamento.GerarRecibo());
        RegistrarAuditoria(pagamento);
        Console.WriteLine();
    }

    // Sobrecarga (polimorfismo em tempo de compilação)
    public void ProcessarPagamento(Pagamento pagamento, string operador)
    {
        Console.WriteLine($"Operador: {operador}");
        ProcessarPagamento(pagamento);
    }

    private void RegistrarAuditoria(Pagamento pagamento)
    {
        Console.WriteLine($"[AUDITORIA] Pagamento de R${pagamento.Valor:F2} realizado em {pagamento.Data:dd/MM/yyyy HH:mm} com status '{pagamento.Status}'.");
    }
}
