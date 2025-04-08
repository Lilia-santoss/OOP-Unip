namespace ECommerceRefatorado.Interfaces {
    public interface IProduto {
        string Nome { get; }
        decimal CalcularPrecoFinal();
        void Exibir();
    }
}
