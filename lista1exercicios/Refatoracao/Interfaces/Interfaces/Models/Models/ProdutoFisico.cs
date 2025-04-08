using ECommerceRefatorado.Interfaces;

namespace ECommerceRefatorado.Models {
    public class ProdutoFisico : Produto, IEntregavel {
        public decimal Frete { get; private set; }

        public ProdutoFisico(string nome, decimal preco, decimal frete)
            : base(nome, preco) {
            Frete = frete;
        }

        public override decimal CalcularPrecoFinal() => Preco + Frete;

        public override void Exibir() {
            Console.WriteLine($"{Nome} (Físico): Preço base {Preco:C}, Frete {Frete:C}, Total {CalcularPrecoFinal():C}");
        }

        public void Entregar() {
            Console.WriteLine($"Entregando {Nome} via transportadora...");
        }
    }
}
