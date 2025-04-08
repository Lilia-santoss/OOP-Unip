using ECommerceRefatorado.Interfaces;

namespace ECommerceRefatorado.Models {
    public abstract class Produto : IProduto {
        public string Nome { get; protected set; }
        public decimal Preco { get; protected set; }

        public Produto(string nome, decimal preco) {
            Nome = nome;
            Preco = preco;
        }

        public virtual decimal CalcularPrecoFinal() => Preco;

        public virtual void Exibir() {
            Console.WriteLine($"{Nome} - {Preco:C}");
        }
    }
}
