using System;
using System.Collections.Generic;
using System.IO;

public abstract class ArmazenamentoBase : IArmazenamento
{
    protected List<string> arquivos = new List<string>();

    public virtual void Salvar(string arquivo, byte[] dados)
    {
        Console.WriteLine($"[Base] Salvando {arquivo}");
        arquivos.Add(arquivo);
        SalvarInterno(arquivo, dados);
    }

    public virtual byte[] Carregar(string arquivo)
    {
        Console.WriteLine($"[Base] Carregando {arquivo}");
        return CarregarInterno(arquivo);
    }

    public virtual void Excluir(string arquivo)
    {
        Console.WriteLine($"[Base] Excluindo {arquivo}");
        arquivos.Remove(arquivo);
        ExcluirInterno(arquivo);
    }

    public List<string> Listar()
    {
        return arquivos;
    }

    // Métodos que devem ser implementados nas classes concretas
    protected abstract void SalvarInterno(string arquivo, byte[] dados);
    protected abstract byte[] CarregarInterno(string arquivo);
    protected abstract void ExcluirInterno(string arquivo);
}
