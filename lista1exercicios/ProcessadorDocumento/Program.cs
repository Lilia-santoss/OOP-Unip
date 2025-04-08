using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var docTexto = new DocumentoTexto("Relatório", "Alice", "Este é o conteúdo do relatório.");
        var docHTML = new DocumentoHTML("Página Web", "Bob", "<h1>Olá Mundo!</h1>");
        var docPDF = new DocumentoPDF("Contrato", "Carlos", "Conteúdo do contrato.");

        // Chamando métodos específicos
        Console.WriteLine($"Palavras no texto: {docTexto.ContarPalavras()}");
        docHTML.AdicionarEstilo("body { font-family: Arial; }");
        docPDF.AdicionarMarcaDagua("Confidencial");

        // Criar lista e processar
        var documentos = new List<Documento> { docTexto, docHTML, docPDF };

        var processador = new ProcessadorDocumentos();
        processador.ProcessarLote(documentos);
    }
}
