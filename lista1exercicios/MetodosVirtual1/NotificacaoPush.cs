public class NotificacaoPush : Notificacao
{
    public NotificacaoPush(string destinatario, string mensagem)
        : base(destinatario, mensagem) { }

    public override void Enviar()
    {
        Console.WriteLine($"Enviando push para {Destinatario}...");
        Console.WriteLine(FormatarMensagem());
        RegistrarEstatistica();
    }

    public override string FormatarMensagem()
    {
        return $"[PUSH] {Mensagem}";
    }

    private void RegistrarEstatistica()
    {
        Console.WriteLine("Estatística: Notificação push enviada.");
    }
}
