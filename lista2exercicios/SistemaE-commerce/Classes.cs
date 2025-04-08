public class ItemCarrinho
{
    public Produto Produto { get; set; }
    public int Quantidade { get; set; }

    public decimal Subtotal => Produto.CalcularPrecoFinal() * Quantidade;
}

public class CarrinhoCompras : ISerializable
{
    private List<ItemCarrinho> _itens = new();

    public void AdicionarItem(Produto produto, int quantidade)
    {
        _itens.Add(new ItemCarrinho { Produto = produto, Quantidade = quantidade });
    }

    public decimal CalcularTotal() => _itens.Sum(i => i.Subtotal);

    public string Serializar()
    {
        return string.Join("\n", _itens.Select(i => $"{i.Quantidade}x {i.Produto.Nome} = R${i.Subtotal:F2}"));
    }
}
