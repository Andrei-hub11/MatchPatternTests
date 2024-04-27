

namespace MatchPattern;

public static class MessageHelper
{

    public static string SayMyName(Funcionario funcionario)
    {
        return (funcionario.Cargo, funcionario.Salario) switch
        {
            ("Desenvolvedor", 2000) => $"Meu nome é {funcionario.Nome}",
            ("Gerente de Projetos", 2000) => $"Meu nome é {funcionario.Nome}",
            ("Designer", 2800) => $"Meu nome é {funcionario.Nome}",
            _ => "Nada a dizer."
        };
    }
}
