class CarrinhoCompra {
    private List<Produto> produtos = new List<Produto>();

    public void AdicionarProduto(Produto produto) => produtos.Add(produto);

    public decimal CalcularTotal() {
        decimal total = 0;
        foreach (var produto in produtos)
            total += produto.CalcularPrecoFinal();
        return total;
    }

    public void ExibirResumo() {
        foreach (var produto in produtos)
            produto.ExibirDetalhes();
        Console.WriteLine($"Total: {CalcularTotal():C}");
    }
}
