void Main()
{
    int opcao = 0;
    List<Usuario> usuarios = new List<Usuario>();
    List<Livro> livros = new List<Livro>();
    List<Emprestimo> emprestimos = new List<Emprestimo>();

    do
    {
        Console.Clear(); // Limpa a tela do console
        Console.WriteLine("---Menu---");
        Console.WriteLine("1 - Cadastrar usuário");
        Console.WriteLine("2 - Cadastrar livro");
        Console.WriteLine("3 - Realizar empréstimo");
        Console.WriteLine("4 - Devolver livro");
        Console.WriteLine("S - Sair");
        try
        {
            opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Usuario usuario = new Usuario();
                    usuario.Cadastrar();
                    usuarios.Add(usuario);
                    break;
                case 2:
                    Livro livro = new Livro();
                    livro.Cadastrar();
                    livros.Add(livro);
                    break;
                case 3:
                    Emprestimo emprestimo = new Emprestimo();
                    emprestimo.Cadastrar();
                    break;
                case 4:
                    // Lógica para devolver livro
                    break;
                case 5:
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    Console.ReadKey();
                    break;
            }
        }
        catch (System.Exception)
        {
            Console.WriteLine("Opção inválida. Tente novamente.");
            Console.ReadKey();
        }
    } while (opcao != 5);
}

Main();