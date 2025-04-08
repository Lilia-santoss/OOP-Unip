public class NotificacaoEmail : Notificacao
{
    public NotificacaoEmail(string destinatario, string mensagem)
        : base(destinatario, mensagem) { }

    public override void Enviar()
    {
        Console.WriteLine($"Enviando e-mail para {Destinatario}...");
        Console.WriteLine(FormatarMensagem());
        RegistrarEstatistica();
    }

    public override string FormatarMensagem()
    {
        return $"[EMAIL]\nPara: {Destinatario}\nMensagem: {Mensagem}";
    }

    private void RegistrarEstatistica()
    {
        Console.WriteLine("Estatística: E-mail enviado.");
    }
}
