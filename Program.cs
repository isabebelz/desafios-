class Program {
    static void Main() {
        List<Funcionario> listaFuncionarios = new List<Funcionario>();
        MenuPrincipal(listaFuncionarios);
    }

    static void MenuPrincipal(List<Funcionario> listaFuncionarios) {

        Console.Clear();

        Console.WriteLine("\n1 - Funcionários cadastrados");
        Console.WriteLine("2 - Cadastrar novos funcionários");
        Console.WriteLine("3 - Cadastrar vendas dos funcionários");
        Console.WriteLine("4 - Média de desempenho da equipe");
        Console.WriteLine("5 - Funcionários que atingiram ou superaram as metas");
        Console.WriteLine("6 - Funcionários que não atingiram as metas");
        Console.WriteLine("7 - Sair");

        int escolha = int.Parse(Console.ReadLine()!);

        switch(escolha){
            case 1: Cadastros.MostrarFuncionariosCadastrados(listaFuncionarios);
            MenuPrincipal(listaFuncionarios);
            break;
            case 2: Cadastros.CadastrarFuncionarios(listaFuncionarios);
            MenuPrincipal(listaFuncionarios);
            break;
            case 3: Cadastros.CadastrarVendasFeitas(listaFuncionarios);
            MenuPrincipal(listaFuncionarios);
            break;
            case 4: OperacoesEquipe.MediaDesempenhoEquipe(listaFuncionarios);
            MenuPrincipal(listaFuncionarios);
            break;
            case 5: OperacoesEquipe.FuncionariosQueAtingiramAMeta(listaFuncionarios);
            MenuPrincipal(listaFuncionarios);
            break;
            case 6: OperacoesEquipe.FuncionariosQueNaoAtingiramAMeta(listaFuncionarios);
            MenuPrincipal(listaFuncionarios);
            break;
            case 7: Environment.Exit(0);
            break;
            default: Console.Clear();
            MenuPrincipal(listaFuncionarios);
            break;
        }
    }

}



    
