using System;

public class Produto
{
    // ✅ Autoimplementadas
    public int Codigo { get; set; }

    // ✅ Propriedade com validação (Nome)
    private string _nome;
    public string Nome
    {
        get => _nome;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Nome não pode ser vazio.");
            _nome = value;
        }
    }

    // ✅ Propriedade com validação (Preço)
    private decimal _preco;
    public decimal Preco
    {
        get => _preco;
        set
        {
            if (value < 0)
                throw new ArgumentException("Preço não pode ser negativo.");
            _preco = value;
        }
    }

    // ✅ Propriedade com validação (Estoque)
    private int _estoque;
    public int Estoque
    {
        get => _estoque;
        set
        {
            if (value < 0)
                throw new ArgumentException("Estoque não pode ser negativo.");
            _estoque = value;
        }
    }

    // ✅ Somente leitura
    public DateTime DataCadastro { get; }

    // ✅ Calculadas
    public decimal ValorEmEstoque => Preco * Estoque;

    public string Status => Estoque > 0 ? "Disponível" : "Indisponível";

    // ✅ Construtor completo
    public Produto(int codigo, string nome, decimal preco, int estoque)
    {
        Codigo = codigo;
        Nome = nome;
        Preco = preco;
        Estoque = estoque;
        DataCadastro = DateTime.Now;
    }

    // ✅ Construtor com atributos essenciais
    public Produto(int codigo, string nome)
    {
        Codigo = codigo;
        Nome = nome;
        Preco = 0;
        Estoque = 0;
        DataCadastro = DateTime.Now;
    }

    // ✅ Construtor padrão (opcional)
    public Produto()
    {
        DataCadastro = DateTime.Now;
    }

    // ✅ Exibir informações formatadas
    public override string ToString()
    {
        return $"Código: {Codigo}, Nome: {Nome}, Preço: R${Preco:F2}, Estoque: {Estoque}, Valor Total: R${ValorEmEstoque:F2}, Status: {Status}, Cadastrado em: {DataCadastro:G}";
    }
}
