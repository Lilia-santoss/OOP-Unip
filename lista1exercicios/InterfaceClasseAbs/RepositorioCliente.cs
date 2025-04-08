using System;
using System.Linq;

public class RepositorioCliente : RepositorioBase<Cliente>, IRepositorio<Cliente>
{
    public void Delete(int id)
    {
        var cliente = Read(id);
        if (cliente != null)
            dados.Remove(cliente);
    }

    public Cliente Read(int id)
    {
        return dados.FirstOrDefault(c => c.Id == id);
    }

    public void Update(int id, Cliente entidade)
    {
        var index = dados.FindIndex(c => c.Id == id);
        if (index >= 0)
        {
            Validar(entidade);
            dados[index] = entidade;
        }
    }

    public override void Validar(Cliente entidade)
    {
        if (string.IsNullOrEmpty(entidade.Nome))
            throw new ArgumentException("Cliente precisa ter um nome.");
    }
}
