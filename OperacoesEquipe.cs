class OperacoesEquipe {

    public static void FuncionariosQueAtingiramAMeta(List<Funcionario> listaFuncionarios) {

        Console.Clear();

        Console.WriteLine("FUNCIONÁRIOS QUE ATINGIRAM A META");

        if(listaFuncionarios != null && listaFuncionarios.Count > 0) {
            foreach(Funcionario funcionario in listaFuncionarios) {
                funcionario.MetaAtingida();
                if(funcionario.AtingiuMeta) {
                    Console.WriteLine(funcionario);
                    Console.WriteLine($"Vendas no mês: {funcionario.VendasFeitas}");
                }
            }
        } else {
            Cadastros.SemCadastroFuncionarios(listaFuncionarios, "Não é possível informar os funcionários que atingiram a meta pois não há registro de funcionários");
        }

        Console.WriteLine("\nAperte qualquer tecla para voltar ao menu principal");
        Console.ReadKey();

    }

    public static void FuncionariosQueNaoAtingiramAMeta(List<Funcionario> listaFuncionarios) {

        Console.Clear();

        Console.WriteLine("FUNCIONÁRIOS QUE NÃO ATINGIRAM A META");

        if(listaFuncionarios != null && listaFuncionarios.Count > 0) {
            foreach(Funcionario funcionario in listaFuncionarios) {
                funcionario.MetaAtingida();
                if(!funcionario.AtingiuMeta) {
                    Console.WriteLine(funcionario);
                    Console.WriteLine($"Vendas no mês: {funcionario.VendasFeitas}");
                }
            }

        } else {
            Cadastros.SemCadastroFuncionarios(listaFuncionarios, "Não é possível informar os funcionários que atingiram a meta pois não há registro de funcionários");
        }

        Console.WriteLine("\nAperte qualquer tecla para voltar ao menu principal");
        Console.ReadKey();

    }

    public static void MediaDesempenhoEquipe(List<Funcionario> listaFuncionarios) {

        Console.Clear();

        Console.WriteLine("MÉDIA DE DESEMPENHO DA EQUIPE");
    
        int soma = 0;

        if(listaFuncionarios != null && listaFuncionarios.Count > 0) {
            foreach(Funcionario funcionario in listaFuncionarios) {
                soma += funcionario.VendasFeitas;
            }
        } else {
            Cadastros.SemCadastroFuncionarios(listaFuncionarios, "Não é possível informar a média de desempenho da equipe pois não há registro de funcionários");
        }

        Console.WriteLine(soma/listaFuncionarios.Count);

        Console.WriteLine("\nAperte qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
    }

}