public class DocumentoTexto : Documento
{
    public string Conteudo { get; set; }

    public DocumentoTexto(string titulo, string autor, string conteudo)
        : base(titulo, autor)
    {
        Conteudo = conteudo;
    }

    public override void Imprimir()
    {
        base.Imprimir();
        Console.WriteLine("Tipo: Texto");
        Console.WriteLine(ConteudoFormatado());
    }

    public override string ConteudoFormatado()
    {
        return Conteudo;
    }

    public int ContarPalavras()
    {
        return Conteudo.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}
