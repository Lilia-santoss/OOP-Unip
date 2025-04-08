using System;

public abstract class Pagamento
{
    public decimal Valor { get; set; }
    public DateTime Data { get; set; }
    public string Status { get; protected set; }

    public Pagamento(decimal valor)
    {
        Valor = valor;
        Data = DateTime.Now;
        Status = "Pendente";
    }

    public abstract void Processar();
    public abstract string GerarRecibo();
}
