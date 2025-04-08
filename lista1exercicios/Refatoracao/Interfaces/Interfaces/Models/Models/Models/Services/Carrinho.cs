using ECommerceRefatorado.Interfaces;

namespace ECommerceRefatorado.Services {
    public class Carrinho {
        private List<IProduto> produtos = new();

        public void AdicionarProduto(IProduto produto) => produtos.Add(produto);

        public decimal CalcularTotal() {
            return produtos.Sum(p => p.CalcularPrecoFinal());
        }

        public void ExibirResumo() {
            foreach (var produto in produtos) {
                produto.Exibir();
            }

            Console.WriteLine($"Total do carrinho: {CalcularTotal():C}");
        }
    }
}
