public class Atendente : Funcionario
{
    public int Atendimentos { get; set; }
    public decimal ComissaoPorAtendimento { get; set; }

    public Atendente(string nome, string cpf, DateTime dataAdmissao, decimal salarioBase, int atendimentos, decimal comissao)
        : base(nome, cpf, dataAdmissao, salarioBase)
    {
        Atendimentos = atendimentos;
        ComissaoPorAtendimento = comissao;
    }

    public override decimal CalcularSalario()
    {
        return base.CalcularSalario() + (Atendimentos * ComissaoPorAtendimento);
    }

    public override void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($"Atendimentos: {Atendimentos}");
        Console.WriteLine($"Comissão por Atendimento: R${ComissaoPorAtendimento:F2}");
        Console.WriteLine($"Salário Final: R${CalcularSalario():F2}");
    }
}
