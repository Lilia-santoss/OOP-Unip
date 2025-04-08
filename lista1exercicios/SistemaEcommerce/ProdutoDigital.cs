class ProdutoDigital : Produto, IReembolsavel {
    public string UrlDownload { get; set; }

    public ProdutoDigital(string nome, decimal precoBase, string url)
        : base(nome, precoBase) {
        UrlDownload = url;
    }

    public override decimal CalcularPrecoFinal() => PrecoBase;

    public void Reembolsar() => Console.WriteLine($"Reembolsando {Nome}");

    public override void ExibirDetalhes() {
        Console.WriteLine($"Produto Digital: {Nome}, Download: {UrlDownload}");
    }
}
