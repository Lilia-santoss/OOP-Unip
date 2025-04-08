class Program
{
    static void Main(string[] args)
    {
        var notificacao = new ServicoNotificacao();

        // Acessando via IServicoEmail
        IServicoEmail email = notificacao;
        email.Enviar("ana@email.com", "Boas-vindas", "Olá Ana, seja bem-vinda!");

        Console.WriteLine();

        // Acessando via IServicoSMS
        IServicoSMS sms = notificacao;
        sms.Enviar("+5511988887777", "Olá Ana! Sua conta foi criada.");
    }
}

