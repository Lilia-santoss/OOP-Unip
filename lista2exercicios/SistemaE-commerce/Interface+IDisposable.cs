public interface IProcessadorPagamento : IDisposable
{
    bool ProcessarPagamento(decimal valor);
}
