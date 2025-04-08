using System;

public class NotificadorSMS : INotificador
{
    public string FormatoSuportado => "SMS";

    public void EnviarNotificacao(string destinatario, string mensagem)
    {
        if (ValidarDestinatario(destinatario))
        {
            Console.WriteLine($"[SMS] Para: {destinatario} - Mensagem: {mensagem}");
        }
    }

    public bool ValidarDestinatario(string destinatario)
    {
        return destinatario.Length == 11; // Ex: 11999999999
    }
}
