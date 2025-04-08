public class Documento
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public DateTime DataCriacao { get; set; }

    public Documento(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
        DataCriacao = DateTime.Now;
    }

    public virtual void Imprimir()
    {
        Console.WriteLine($"Título: {Titulo}\nAutor: {Autor}\nData: {DataCriacao}");
    }

    public virtual string ConteudoFormatado()
    {
        return $"Documento: {Titulo} por {Autor}";
    }
}
