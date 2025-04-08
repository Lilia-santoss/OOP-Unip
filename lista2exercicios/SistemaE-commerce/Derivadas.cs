public class ProdutoEletronico : Produto
{
    public ProdutoEletronico(string nome, decimal preco) : base(nome, preco) {}

    public override decimal CalcularPrecoFinal() => PrecoBase * 1.15m;
    public override decimal CalcularImposto() => PrecoBase * 0.10m;
}
