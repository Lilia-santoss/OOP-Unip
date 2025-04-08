using System;
using System.Collections.Generic;

public class ArmazenamentoMemoria : IArmazenamento
{
    private Dictionary<string, byte[]> dados = new Dictionary<string, byte[]>();

    public void Salvar(string arquivo, byte[] conteudo)
    {
        Console.WriteLine($"[Memória] Salvando {arquivo}");
        dados[arquivo] = conteudo;
    }

    public byte[] Carregar(string arquivo)
    {
        return dados.ContainsKey(arquivo) ? dados[arquivo] : Array.Empty<byte>();
    }

    public void Excluir(string arquivo)
    {
        Console.WriteLine($"[Memória] Excluindo {arquivo}");
        dados.Remove(arquivo);
    }

    public List<string> Listar()
    {
        return new List<string>(dados.Keys);
    }
}
