public interface INotificador
{
    string FormatoSuportado { get; }
    void EnviarNotificacao(string destinatario, string mensagem);
    bool ValidarDestinatario(string destinatario);
}
