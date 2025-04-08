public class DocumentoPDF : Documento
{
    public string DadosPDF { get; set; }

    public DocumentoPDF(string titulo, string autor, string dadosPDF)
        : base(titulo, autor)
    {
        DadosPDF = dadosPDF;
    }

    public override void Imprimir()
    {
        base.Imprimir();
        Console.WriteLine("Tipo: PDF");
        Console.WriteLine(ConteudoFormatado());
    }

    public override string ConteudoFormatado()
    {
        return $"[PDF] {DadosPDF}";
    }

    public void AdicionarMarcaDagua(string texto)
    {
        DadosPDF += $"\n--- Marca D'água: {texto} ---";
    }
}
