public class NotificacaoSMS : Notificacao
{
    public NotificacaoSMS(string destinatario, string mensagem)
        : base(destinatario, mensagem) { }

    public override void Enviar()
    {
        Console.WriteLine($"Enviando SMS para {Destinatario}...");
        Console.WriteLine(FormatarMensagem());
        RegistrarEstatistica();
    }

    public override string FormatarMensagem()
    {
        return $"[SMS] {Mensagem}";
    }

    private void RegistrarEstatistica()
    {
        Console.WriteLine("Estatística: SMS enviado.");
    }
}
