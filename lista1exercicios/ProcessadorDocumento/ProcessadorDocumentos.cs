public class ProcessadorDocumentos
{
    public void ProcessarLote(List<Documento> documentos)
    {
        foreach (var doc in documentos)
        {
            Console.WriteLine("\n--- Documento ---");
            doc.Imprimir();  // Polimorfismo em ação!
        }
    }
}
