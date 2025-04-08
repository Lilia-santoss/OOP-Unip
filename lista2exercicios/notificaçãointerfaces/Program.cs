using System;

class Program
{
    static void Main()
    {
        var email = new NotificadorEmail();
        var sms = new NotificadorSMS();
        var push = new NotificadorPush();

        var gerenciador = new GerenciadorNotificacoes();
        gerenciador.RegistrarNotificador(email);
        gerenciador.RegistrarNotificador(sms);
        gerenciador.RegistrarNotificador(push);

        Console.WriteLine("== Enviando para todos os canais ==\n");
        gerenciador.EnviarParaTodos("cliente@email.com", "Sua compra foi aprovada!");
        gerenciador.EnviarParaTodos("11988887777", "Seu código de segurança é 1234");
        gerenciador.EnviarParaTodos("DispositivoXYZ", "Você recebeu um push");

        Console.WriteLine("\n== Enviando somente por SMS ==\n");
        gerenciador.EnviarPorFormato("SMS", "11999998888", "Mensagem exclusiva para SMS.");

        Console.WriteLine("\n== Usando interfaces com mesmo nome ==\n");

        var logger = new LoggerAlerta();

        ((ILog)logger).Registrar("Sistema inicializado com sucesso.");
        ((IAlerta)logger).Registrar("Alerta de falha crítica!");
    }
}

