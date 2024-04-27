

namespace MatchPattern;

public class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public double Salario { get; set; }

    // Construtor para inicializar os atributos
    public Funcionario(string nome, string cargo, double salario)
    {
        Nome = nome;
        Cargo = cargo;
        Salario = salario;
    }
}
