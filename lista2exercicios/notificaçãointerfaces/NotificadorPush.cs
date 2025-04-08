using System;

public class NotificadorPush : INotificador
{
    public string FormatoSuportado => "Push";

    public void EnviarNotificacao(string destinatario, string mensagem)
    {
        Console.WriteLine($"[PUSH] Para dispositivo: {destinatario} - Mensagem: {mensagem}");
    }

    public bool ValidarDestinatario(string destinatario)
    {
        return !string.IsNullOrWhiteSpace(destinatario);
    }
}
