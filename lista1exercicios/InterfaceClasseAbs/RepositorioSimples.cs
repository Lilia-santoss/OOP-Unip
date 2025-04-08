using System.Collections.Generic;

public class RepositorioSimples<T> : IRepositorio<T>
{
    private List<T> dados = new List<T>();

    public void Create(T entidade)
    {
        dados.Add(entidade);
    }

    public T Read(int id)
    {
        return dados.Count > id ? dados[id] : default;
    }

    public void Update(int id, T entidade)
    {
        if (id >= 0 && id < dados.Count)
            dados[id] = entidade;
    }

    public void Delete(int id)
    {
        if (id >= 0 && id < dados.Count)
            dados.RemoveAt(id);
    }

    public List<T> ListarTodos()
    {
        return new List<T>(dados);
    }
}
