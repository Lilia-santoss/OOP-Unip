using System;

public enum TipoTransacao
{
    Deposito,
    Saque,
    Transferencia
}

public class Transacao
{
    public DateTime DataHora { get; }
    public TipoTransacao Tipo { get; }
    public decimal Valor { get; }
    public string Descricao { get; }

    public Transacao(TipoTransacao tipo, decimal valor, string descricao)
    {
        DataHora = DateTime.Now;
        Tipo = tipo;
        Valor = valor;
        Descricao = descricao;
    }

    public override string ToString()
    {
        return $"{DataHora:G} - {Tipo} - R${Valor:F2} - {Descricao}";
    }
}
