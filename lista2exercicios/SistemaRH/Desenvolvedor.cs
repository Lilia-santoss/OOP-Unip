public class Desenvolvedor : Funcionario
{
    public string Especialidade { get; set; }
    public string Nivel { get; set; }

    public Desenvolvedor(string nome, string cpf, DateTime dataAdmissao, decimal salarioBase, string especialidade, string nivel)
        : base(nome, cpf, dataAdmissao, salarioBase)
    {
        Especialidade = especialidade;
        Nivel = nivel;
    }

    public override decimal CalcularSalario()
    {
        decimal adicional = Nivel switch
        {
            "Junior" => 500,
            "Pleno" => 1000,
            "Senior" => 2000,
            _ => 0
        };

        return base.CalcularSalario() + adicional;
    }

    public override void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($"Especialidade: {Especialidade}");
        Console.WriteLine($"Nível: {Nivel}");
        Console.WriteLine($"Salário Final: R${CalcularSalario():F2}");
    }
}
