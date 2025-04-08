public class DocumentoHTML : Documento
{
    public string Html { get; set; }

    public DocumentoHTML(string titulo, string autor, string html)
        : base(titulo, autor)
    {
        Html = html;
    }

    public override void Imprimir()
    {
        base.Imprimir();
        Console.WriteLine("Tipo: HTML");
        Console.WriteLine(ConteudoFormatado());
    }

    public override string ConteudoFormatado()
    {
        return $"<html><body>{Html}</body></html>";
    }

    public void AdicionarEstilo(string css)
    {
        Html = $"<style>{css}</style>\n" + Html;
    }
}
