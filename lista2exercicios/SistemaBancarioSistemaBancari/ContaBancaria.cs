using System;
using System.Collections.Generic;

public class ContaBancaria
{
    private decimal _saldo;
    private string _numeroConta;
    private string _titular;
    private List<Transacao> _transacoes;

    public string NumeroConta => _numeroConta;
    public string Titular => _titular;
    public decimal Saldo => _saldo;

    public ContaBancaria(string numeroConta, string titular)
    {
        _numeroConta = numeroConta;
        _titular = titular;
        _saldo = 0;
        _transacoes = new List<Transacao>();
    }

    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor de depósito deve ser positivo.");
            return;
        }

        _saldo += valor;
        _transacoes.Add(new Transacao(TipoTransacao.Deposito, valor, "Depósito realizado"));
    }

    public void Sacar(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor de saque deve ser positivo.");
            return;
        }

        if (valor > _saldo)
        {
            Console.WriteLine("Saldo insuficiente.");
            return;
        }

        _saldo -= valor;
        _transacoes.Add(new Transacao(TipoTransacao.Saque, valor, "Saque realizado"));
    }

    public List<Transacao> VerExtrato()
    {
        return new List<Transacao>(_transacoes); // Cópia da lista
    }
}
