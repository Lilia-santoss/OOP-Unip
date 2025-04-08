class Program {
    static void Main() {
        var carrinho = new CarrinhoCompra();

        carrinho.AdicionarProduto(new ProdutoFisico("Livro", 100, 1));
        carrinho.AdicionarProduto(new ProdutoDigital("Curso", 150, "http://curso.com"));
        carrinho.AdicionarProduto(new Servico("Consultoria", 200, 2));

        carrinho.ExibirResumo();

        using (IProcessadorPagamento pagamento = new ProcessadorCartaoCredito()) {
            pagamento.ProcessarPagamento(carrinho.CalcularTotal());
        }
    }
}

