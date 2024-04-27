// See https://aka.ms/new-console-template for more information
using MatchPattern;

Console.WriteLine("Hello, World!");

List<Funcionario> listaFuncionarios = new List<Funcionario>
{
    // Adicionando alguns funcionários à lista
    new Funcionario("João", "Desenvolvedor", 3000),
    new Funcionario("Maria", "Gerente de Projetos", 5000),
    new Funcionario("Pedro", "Analista de Qualidade", 3500),
    new Funcionario("Ana", "Designer", 2800)
};

foreach (var item in listaFuncionarios)
{
    Console.WriteLine(MessageHelper.SayMyName(item));
}