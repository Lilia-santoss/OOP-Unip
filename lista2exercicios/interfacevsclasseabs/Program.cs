using System;
using System.Text;

class Program
{
    static void Main()
    {
        var local = new ArmazenamentoLocal();
        var nuvem = new ArmazenamentoNuvem();
        var memoria = new ArmazenamentoMemoria();

        TestarArmazenamento("Local", local);
        TestarArmazenamento("Nuvem", nuvem);
        TestarArmazenamento("Memória", memoria);
    }

    static void TestarArmazenamento(string nome, IArmazenamento armazenamento)
    {
        Console.WriteLine($"\n== Testando Armazenamento {nome} ==");

        string nomeArquivo = $"arquivo_{nome}.txt";
        byte[] dados = Encoding.UTF8.GetBytes($"Conteúdo armazenado em {nome}");

        armazenamento.Salvar(nomeArquivo, dados);

        byte[] recuperado = armazenamento.Carregar(nomeArquivo);
        Console.WriteLine("Conteúdo carregado: " + Encoding.UTF8.GetString(recuperado));

        Console.WriteLine("Arquivos disponíveis:");
        foreach (var arq in armazenamento.Listar())
        {
            Console.WriteLine($" - {arq}");
        }

        armazenamento.Excluir(nomeArquivo);
        Console.WriteLine("Arquivo excluído.");
    }
}

