using System;

public class LoggerAlerta : ILog, IAlerta
{
    void ILog.Registrar(string mensagem)
    {
        Console.WriteLine("[LOG] " + mensagem);
    }

    void IAlerta.Registrar(string mensagem)
    {
        Console.WriteLine("[ALERTA] " + mensagem);
    }
}
