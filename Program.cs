class Program
{
    static void Main()
    {
        Empresa empresa = new Empresa();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Adicionar Funcionário de Tempo Integral");
            Console.WriteLine("2. Adicionar Funcionário de Meio Período");
            Console.WriteLine("3. Remover Funcionário");
            Console.WriteLine("4. Exibir Informações de Todos os Funcionários");
            Console.WriteLine("5. Adicionar Projeto(s) a um Funcionário");
            Console.WriteLine("6. Sair");

            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    AdicionarFuncionarioTempoIntegral(empresa);
                    break;
                case 2:
                    AdicionarFuncionarioMeioPeriodo(empresa);
                    break;
                case 3:
                    RemoverFuncionario(empresa);
                    break;
                case 4:
                    empresa.ExibirFuncionarios();
                    break;
                case 5:
                    AdicionarProjetos(empresa);
                    break;
                case 6:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void AdicionarFuncionarioTempoIntegral(Empresa empresa)
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Matrícula: ");
        int matricula = int.Parse(Console.ReadLine());
        Console.Write("Salário Mensal: ");
        double salarioMensal = double.Parse(Console.ReadLine());

        FuncionarioTempoIntegral funcionario = new FuncionarioTempoIntegral(nome, matricula, salarioMensal);
        empresa.AdicionarFuncionario(funcionario);
    }

    static void AdicionarFuncionarioMeioPeriodo(Empresa empresa)
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Matrícula: ");
        int matricula = int.Parse(Console.ReadLine());
        Console.Write("Salário por Hora: ");
        double salarioPorHora = double.Parse(Console.ReadLine());
        Console.Write("Horas Trabalhadas: ");
        int horasTrabalhadas = int.Parse(Console.ReadLine());

        FuncionarioMeioPeriodo funcionario = new FuncionarioMeioPeriodo(nome, matricula, salarioPorHora, horasTrabalhadas);
        empresa.AdicionarFuncionario(funcionario);
    }

    static void RemoverFuncionario(Empresa empresa)
    {
        Console.Write("Matrícula do Funcionário a ser removido: ");
        int matricula = int.Parse(Console.ReadLine());
        empresa.RemoverFuncionario(matricula);
    }

    static void AdicionarProjetos(Empresa empresa)
    {
        Console.Write("Matrícula do Funcionário: ");
        int matricula = int.Parse(Console.ReadLine());

        foreach (var funcionario in empresa.funcionarios)
        {
            if (funcionario.Matricula == matricula)
            {
                Console.Write("Quantos projetos deseja adicionar? ");
                int quantidade = int.Parse(Console.ReadLine());
                for (int i = 0; i < quantidade; i++)
                {
                    Console.Write($"Nome do Projeto {i + 1}: ");
                    string projeto = Console.ReadLine();
                    funcionario.AdicionarProjeto(projeto);
                }
            }
        }
    }
}