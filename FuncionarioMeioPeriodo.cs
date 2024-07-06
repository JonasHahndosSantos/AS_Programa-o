public class FuncionarioMeioPeriodo : Funcionario, IBonus
{
    private double SalarioPorHora;
    private int HorasTrabalhadas;
    private double salarioTotal;

    public FuncionarioMeioPeriodo(string nome, int matricula, double salarioPorHora, int horasTrabalhadas)
        : base(nome, matricula)
    {
        SalarioPorHora = salarioPorHora;
        HorasTrabalhadas = horasTrabalhadas;
    }

    public override double CalcularSalario()
    {
        return SalarioPorHora * HorasTrabalhadas;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, Matrícula: {Matricula}, Salário por Hora: {SalarioPorHora}, Horas Trabalhadas: {HorasTrabalhadas}, Salario total: {CalcularSalario()}");
        Console.WriteLine("Projetos: " + string.Join(", ", Projetos));
    }

    public double CalcularBonus()
    {
        return CalcularSalario() * 0.05;
    }
}