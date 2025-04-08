public class PagamentoBoleto : Pagamento
{
    public string CodigoBarras { get; set; }
    public DateTime DataVencimento { get; set; }

    public PagamentoBoleto(decimal valor, string codigoBarras, DateTime vencimento)
        : base(valor)
    {
        CodigoBarras = codigoBarras;
        DataVencimento = vencimento;
    }

    public override void Processar()
    {
        Status = "Pago com Boleto";
        Console.WriteLine("Processando pagamento com boleto...");
    }

    public override string GerarRecibo()
    {
        return $"Recibo - Boleto {CodigoBarras} - Vencimento: {DataVencimento:dd/MM/yyyy} - Valor: R${Valor:F2} - Status: {Status}";
    }
}
