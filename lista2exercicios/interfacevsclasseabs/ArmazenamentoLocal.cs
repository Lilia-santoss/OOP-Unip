using System;
using System.IO;

public class ArmazenamentoLocal : ArmazenamentoBase
{
    private string diretorioBase = "dados/";

    public ArmazenamentoLocal()
    {
        Directory.CreateDirectory(diretorioBase);
    }

    protected override void SalvarInterno(string arquivo, byte[] dados)
    {
        File.WriteAllBytes(diretorioBase + arquivo, dados);
    }

    protected override byte[] CarregarInterno(string arquivo)
    {
        return File.Exists(diretorioBase + arquivo) 
            ? File.ReadAllBytes(diretorioBase + arquivo)
            : Array.Empty<byte>();
    }

    protected override void ExcluirInterno(string arquivo)
    {
        File.Delete(diretorioBase + arquivo);
    }
}
