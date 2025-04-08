using System;

public class ServicoNotificacao : IServicoEmail, IServicoSMS
{
    // Implementação explícita de IServicoEmail
    void IServicoEmail.Enviar(string destinatario, string assunto, string corpo)
    {
        Console.WriteLine("📧 Enviando EMAIL");
        Console.WriteLine($"Para: {destinatario}");
        Console.WriteLine($"Assunto: {assunto}");
        Console.WriteLine($"Corpo: {corpo}");
    }

    // Implementação explícita de IServicoSMS
    void IServicoSMS.Enviar(string numero, string mensagem)
    {
        Console.WriteLine("📱 Enviando SMS");
        Console.WriteLine($"Número: {numero}");
        Console.WriteLine($"Mensagem: {mensagem}");
    }
}
