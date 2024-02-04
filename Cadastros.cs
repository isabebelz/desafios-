class Cadastros {

    public static void CadastrarFuncionarios(List<Funcionario> listaFuncionarios) {

        Console.Clear();

        Funcionario funcionario;

        Console.WriteLine("CADASTRO DE FUNCIONÁRIOS");
        Console.Write("\nQuantos funcionários deseja cadastrar: ");
        int qtdFuncionarios = int.Parse(Console.ReadLine()!);

        for(int i = 0; i < qtdFuncionarios; i++) {
            Console.Write("\nNome: ");
            string nome = Console.ReadLine()!;
            int numeroIdentificacao = 0;
            bool idJaExiste;
            do {
                
                Console.Write("Número de identificação: ");
                numeroIdentificacao = int.Parse(Console.ReadLine()!);

                idJaExiste = listaFuncionarios.Any(funcionario => funcionario.NumeroIdentificacao == numeroIdentificacao);
                
                if(idJaExiste) {
                    Console.WriteLine("ID já existente. Por favor escolha outro número de identificação");
                }

            } while(idJaExiste);

            Console.Write("Meta mensal de vendas: ");
            int metaMensalVendas = int.Parse(Console.ReadLine()!);
            funcionario = new Funcionario(nome, numeroIdentificacao, metaMensalVendas);
            listaFuncionarios.Add(funcionario);
        }

        if(qtdFuncionarios == 1) {
            Console.WriteLine("\nFuncionário cadastrado...");
        } else {
            Console.WriteLine("\nFuncionários cadastados...");
            Thread.Sleep(2000);
        }


    }

    public static void MostrarFuncionariosCadastrados(List<Funcionario> listaFuncionarios) {

        Console.Clear();

        Console.WriteLine("FUNCIONÁRIOS");

        if(listaFuncionarios != null && listaFuncionarios.Count > 0) {
            foreach(var funcionario in listaFuncionarios) {
                Console.WriteLine(funcionario);
            }
        } else {
            SemCadastroFuncionarios(listaFuncionarios, "Não há registro de funcionários");
        }

        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
    }

    public static void CadastrarVendasFeitas(List<Funcionario> listaFuncionarios) {

        Console.Clear();

        Console.WriteLine("CADASTRO DE VENDAS DO MÊS");

        if(listaFuncionarios != null && listaFuncionarios.Count > 0) {
            Console.WriteLine("\nQuantos cadastros serão feitos: ");
            int qtdCadastros = int.Parse(Console.ReadLine()!);

            for(int i = 0; i < qtdCadastros; i++) {
                Console.Write("\nDigite o ID do funcionário: ");
                int numeroIdentificacao = int.Parse(Console.ReadLine()!);

                foreach(var funcionario in listaFuncionarios) {
                    if(numeroIdentificacao.Equals(funcionario.NumeroIdentificacao)) {
                        Console.WriteLine(funcionario);
                        Console.Write("\nVendas feitas no mês: ");
                        funcionario.VendasFeitas = int.Parse(Console.ReadLine()!);
                        
                    }
                }
            }

            if(qtdCadastros == 1) {
                Console.WriteLine("\nVenda cadastrada...");
            } else {
                Console.WriteLine("\nVendas cadastradas...");
            }
            Thread.Sleep(2000);

        } else {
            SemCadastroFuncionarios(listaFuncionarios, "Não é possível cadastras as vendas do mês pois não há registros de funcionários");
        }
    
    }

    public static void SemCadastroFuncionarios(List<Funcionario> listaFuncionarios, string mensagem) {
    Console.WriteLine(mensagem);
    Console.WriteLine("\n\n1 - Cadastrar novos funcionários");
    Console.WriteLine("2 - Sair");

    int escolha = int.Parse(Console.ReadLine()!);

    switch(escolha) {
        case 1: Cadastros.CadastrarFuncionarios(listaFuncionarios);
        break;
        case 2: Environment.Exit(0);
        break;
    }
}



    
}