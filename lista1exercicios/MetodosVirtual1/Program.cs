public class Program
{
    public static void Main()
    {
        List<Notificacao> notificacoes = new List<Notificacao>
        {
            new NotificacaoEmail("ana@email.com", "Seu relatório está pronto."),
            new NotificacaoSMS("+55999999999", "Seu código de verificação é 1234."),
            new NotificacaoPush("Usuário123", "Você recebeu uma nova mensagem.")
        };

        foreach (var notificacao in notificacoes)
        {
            Console.WriteLine("\n--------------------------");
            notificacao.Enviar(); // Polimorfismo: chama o método correto automaticamente
        }
    }
}
