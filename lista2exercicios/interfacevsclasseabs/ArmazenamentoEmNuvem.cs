using System;
using System.Collections.Generic;

public class ArmazenamentoNuvem : ArmazenamentoBase
{
    private Dictionary<string, byte[]> nuvemFake = new Dictionary<string, byte[]>();

    protected override void SalvarInterno(string arquivo, byte[] dados)
    {
        Console.WriteLine($"[Nuvem] Enviando {arquivo} para a nuvem...");
        nuvemFake[arquivo] = dados;
    }

    protected override byte[] CarregarInterno(string arquivo)
    {
        return nuvemFake.ContainsKey(arquivo) ? nuvemFake[arquivo] : Array.Empty<byte>();
    }

    protected override void ExcluirInterno(string arquivo)
    {
        nuvemFake.Remove(arquivo);
    }
}
