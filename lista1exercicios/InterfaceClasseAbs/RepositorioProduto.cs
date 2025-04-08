using System;
using System.Linq;

public class RepositorioProduto : RepositorioBase<Produto>, IRepositorio<Produto>
{
    public void Delete(int id)
    {
        var produto = Read(id);
        if (produto != null)
            dados.Remove(produto);
    }

    public Produto Read(int id)
    {
        return dados.FirstOrDefault(p => p.Id == id);
    }

    public void Update(int id, Produto entidade)
    {
        var index = dados.FindIndex(p => p.Id == id);
        if (index >= 0)
        {
            Validar(entidade);
            dados[index] = entidade;
        }
    }

    public override void Validar(Produto entidade)
    {
        if (string.IsNullOrEmpty(entidade.Descricao))
            throw new ArgumentException("Produto precisa ter uma descrição.");
    }
}
