public abstract class Produto
{
    public string Nome { get; set; }
    public decimal PrecoBase { get; set; }

    public Produto(string nome, decimal precoBase)
    {
        Nome = nome;
        PrecoBase = precoBase;
    }

    public abstract decimal CalcularPrecoFinal();
    public abstract decimal CalcularImposto();
}
