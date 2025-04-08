using System;

public class NotificadorEmail : INotificador
{
    public string FormatoSuportado => "Email";

    public void EnviarNotificacao(string destinatario, string mensagem)
    {
        if (ValidarDestinatario(destinatario))
        {
            Console.WriteLine($"[EMAIL] Para: {destinatario} - Mensagem: {mensagem}");
        }
    }

    public bool ValidarDestinatario(string destinatario)
    {
        return destinatario.Contains("@");
    }
}
