public class Emprestimo
{   
    public int IdEmprestimo { get; set; }
    public int IdLivro { get; set; }
    public int IdUsuario { get; set; }
    public Livro Livro { get; set; }
    public Usuario Usuario { get; set; }
    public DateTime DataEmprestimo { get; set; }
    public DateTime DataDevolucao { get; set; }

    public Emprestimo(Livro livro, Usuario usuario)
    {
    }

    internal void Cadastrar()
    {
        Console.WriteLine("Realizando o empréstimo...");
        Console.Write("Digite o Email do usuário:");
        string emailUsuario = Console.ReadLine();
        //Checar se existe na lista de usuários:
        var ObjUsuario = usuarios.Find(u => u.Email == emailUsuario);
        if (ObjUsuario == null)
        {
            Console.WriteLine("Usuário não encontrado.");
            Console.ReadKey();
            return;
        }

        
    }
}