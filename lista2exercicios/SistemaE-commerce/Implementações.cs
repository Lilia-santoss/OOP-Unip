public class NotificadorEmail : INotificador
{
    public void EnviarNotificacao(string destinatario, string mensagem)
    {
        Console.WriteLine($"[EMAIL] Para: {destinatario} - {mensagem}");
    }
}
