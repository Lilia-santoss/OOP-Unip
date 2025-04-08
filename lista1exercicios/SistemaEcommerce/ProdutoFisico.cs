class ProdutoFisico : Produto, IEntregavel, ITributavel, IReembolsavel {
    public decimal Peso { get; set; }

    public ProdutoFisico(string nome, decimal precoBase, decimal peso)
        : base(nome, precoBase) {
        Peso = peso;
    }

    public override decimal CalcularPrecoFinal() {
        return PrecoBase + CalcularImposto();
    }

    public decimal CalcularImposto() => PrecoBase * 0.1m;

    public void Entregar() => Console.WriteLine($"Entregando {Nome}");

    public void Reembolsar() => Console.WriteLine($"Reembolsando {Nome}");

    public override void ExibirDetalhes() {
        Console.WriteLine($"Produto Físico: {Nome}, R${PrecoBase}, Peso: {Peso}kg");
    }
}
