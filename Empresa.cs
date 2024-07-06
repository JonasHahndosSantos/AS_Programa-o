public class Empresa
{
    public List<Funcionario> funcionarios;

    public Empresa()
    {
        funcionarios = new List<Funcionario>();
    }

    public void AdicionarFuncionario(Funcionario funcionario)
    {
        funcionarios.Add(funcionario);
    }

    public void RemoverFuncionario(int matricula)
    {
        funcionarios.RemoveAll(f => f.Matricula == matricula);
    }

    public void ExibirFuncionarios()
    {
        foreach (var funcionario in funcionarios)
        {
            funcionario.ExibirInformacoes();
        }
    }
}