class Program
{
    static void Main()
    {
        var carrinho = new CarrinhoCompras();
        carrinho.AdicionarItem(new ProdutoEletronico("Notebook", 4000), 1);

        Console.WriteLine("Itens do carrinho:");
        Console.WriteLine(carrinho.Serializar());

        decimal total = carrinho.CalcularTotal();
        Console.WriteLine($"\nTotal da compra: R${total:F2}");

        using IProcessadorPagamento pagamento = new PagamentoCartao();
        if (pagamento.ProcessarPagamento(total))
        {
            INotificador notificador = new NotificadorEmail();
            notificador.EnviarNotificacao("cliente@email.com", "Seu pedido foi processado com sucesso!");
        }
    }
}
