public class PagamentoPix : Pagamento
{
    public string ChavePix { get; set; }
    public string QrCode { get; set; }

    public PagamentoPix(decimal valor, string chavePix, string qrCode)
        : base(valor)
    {
        ChavePix = chavePix;
        QrCode = qrCode;
    }

    public override void Processar()
    {
        Status = "Pago com Pix";
        Console.WriteLine("Processando pagamento com Pix...");
    }

    public override string GerarRecibo()
    {
        return $"Recibo - Pix para {ChavePix} - Valor: R${Valor:F2} - Status: {Status}";
    }
}
