public abstract class Funcionario
{
    public string Nome { get; set; }
    public int Matricula { get; set; }
    public List<string> Projetos { get; set; }

    public Funcionario(string nome, int matricula)
    {
        Nome = nome;
        Matricula = matricula;
        Projetos = new List<string>();
    }

    public abstract double CalcularSalario();
    public abstract void ExibirInformacoes();

    public void AdicionarProjeto(string projeto)
    {
        Projetos.Add(projeto);
    }

    public void AdicionarProjeto(List<string> projetos)
    {
        Projetos.AddRange(projetos);
    }
}