using System.Collections.Generic;

public abstract class RepositorioBase<T>
{
    protected List<T> dados = new List<T>();

    public virtual List<T> ListarTodos()
    {
        return dados;
    }

    public virtual void Create(T entidade)
    {
        Validar(entidade);
        dados.Add(entidade);
    }

    public abstract void Validar(T entidade);
}
