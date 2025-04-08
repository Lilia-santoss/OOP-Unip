using System;

public class Funcionario
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public DateTime DataAdmissao { get; set; }
    public decimal SalarioBase { get; set; }

    public Funcionario(string nome, string cpf, DateTime dataAdmissao, decimal salarioBase)
    {
        Nome = nome;
        CPF = cpf;
        DataAdmissao = dataAdmissao;
        SalarioBase = salarioBase;
    }

    public virtual decimal CalcularSalario()
    {
        return SalarioBase;
    }

    public virtual void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"CPF: {CPF}");
        Console.WriteLine($"Data de Admissão: {DataAdmissao:dd/MM/yyyy}");
        Console.WriteLine($"Salário Base: R${SalarioBase:F2}");
    }
}
