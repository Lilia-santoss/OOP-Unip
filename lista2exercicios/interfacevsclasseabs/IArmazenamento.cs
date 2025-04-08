using System.Collections.Generic;

public interface IArmazenamento
{
    void Salvar(string arquivo, byte[] dados);
    byte[] Carregar(string arquivo);
    void Excluir(string arquivo);
    List<string> Listar();
}
