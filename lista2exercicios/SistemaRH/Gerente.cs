public class Gerente : Funcionario
{
    public int TamanhoEquipe { get; set; }
    public decimal Bonus { get; set; }

    public Gerente(string nome, string cpf, DateTime dataAdmissao, decimal salarioBase, int tamanhoEquipe, decimal bonus)
        : base(nome, cpf, dataAdmissao, salarioBase)
    {
        TamanhoEquipe = tamanhoEquipe;
        Bonus = bonus;
    }

    public override decimal CalcularSalario()
    {
        return base.CalcularSalario() + Bonus;
    }

    public override void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($"Equipe: {TamanhoEquipe} pessoas");
        Console.WriteLine($"Bônus: R${Bonus:F2}");
        Console.WriteLine($"Salário Final: R${CalcularSalario():F2}");
    }
}
