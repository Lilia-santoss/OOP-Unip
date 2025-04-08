using System;
using System.Collections.Generic;

public class GerenciadorNotificacoes
{
    private List<INotificador> notificadores = new List<INotificador>();

    public void RegistrarNotificador(INotificador notificador)
    {
        notificadores.Add(notificador);
    }

    public void EnviarParaTodos(string destinatario, string mensagem)
    {
        foreach (var notificador in notificadores)
        {
            notificador.EnviarNotificacao(destinatario, mensagem);
        }
    }

    public void EnviarPorFormato(string formato, string destinatario, string mensagem)
    {
        foreach (var notificador in notificadores)
        {
            if (notificador.FormatoSuportado == formato)
            {
                notificador.EnviarNotificacao(destinatario, mensagem);
            }
        }
    }
}
