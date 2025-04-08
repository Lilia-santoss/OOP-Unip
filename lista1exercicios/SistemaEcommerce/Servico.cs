class Servico : Produto, ITributavel {
    public int Horas { get; set; }

    public Servico(string nome, decimal precoBase, int horas)
        : base(nome, precoBase) {
        Horas = horas;
    }

    public override decimal CalcularPrecoFinal() => PrecoBase + CalcularImposto();

    public decimal CalcularImposto() => PrecoBase * 0.15m;

    public override void ExibirDetalhes() {
        Console.WriteLine($"Serviço: {Nome}, Horas: {Horas}");
    }
}


