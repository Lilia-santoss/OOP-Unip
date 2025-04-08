public class PagamentoCartao : Pagamento
{
    public string Bandeira { get; set; }
    public string NumeroCartao { get; set; }
    public int Parcelas { get; set; }

    public PagamentoCartao(decimal valor, string bandeira, string numeroCartao, int parcelas)
        : base(valor)
    {
        Bandeira = bandeira;
        NumeroCartao = numeroCartao;
        Parcelas = parcelas;
    }

    public override void Processar()
    {
        Status = "Pago com Cartão";
        Console.WriteLine("Processando pagamento com cartão...");
    }

    public override string GerarRecibo()
    {
        return $"Recibo - Cartão {Bandeira} - Valor: R${Valor:F2} - Parcelas: {Parcelas} - Status: {Status}";
    }
}
