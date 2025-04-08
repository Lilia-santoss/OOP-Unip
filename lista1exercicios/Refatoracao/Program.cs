using ECommerceRefatorado.Models;
using ECommerceRefatorado.Services;
using ECommerceRefatorado.Interfaces;

class Program {
    static void Main() {
        var carrinho = new Carrinho();

        var livro = new ProdutoFisico("Livro C#", 120, 15);
        var curso = new ProdutoDigital("Curso .NET", 200, "http://cursos.com/dotnet");

        carrinho.AdicionarProduto(livro);
        carrinho.AdicionarProduto(curso);

        carrinho.ExibirResumo();

        // Entrega
        if (livro is IEntregavel entregavel) {
            entregavel.Entregar();
        }

        // Pagamento
        using (var pagamento = new ProcessadorPagamento()) {
            pagamento.Processar(carrinho.CalcularTotal());
        }
    }
}
