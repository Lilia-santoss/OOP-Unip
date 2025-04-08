using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Funcionario> funcionarios = new List<Funcionario>();

        funcionarios.Add(new Desenvolvedor("Ana", "123.456.789-00", DateTime.Parse("2020-01-15"), 4000, "C#", "Senior"));
        funcionarios.Add(new Gerente("Carlos", "987.654.321-00", DateTime.Parse("2019-08-10"), 6000, 12, 2000));
        funcionarios.Add(new Atendente("João", "111.222.333-44", DateTime.Parse("2021-03-10"), 2000, 150, 5));

        Console.WriteLine("Folha de Pagamento:\n");

        foreach (var f in funcionarios)
        {
            f.ExibirDados();
            Console.WriteLine(new string('-', 40));
        }
    }
}
