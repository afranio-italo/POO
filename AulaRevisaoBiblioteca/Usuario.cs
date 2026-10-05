public class Usuario
{   
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }

    public void Cadastrar()
    {
        Console.WriteLine("Cadastro de usuário...");
        Console.Write("Digite o nome:");
        Nome = Console.ReadLine();
        Console.Write("Digite o email:");
        Email = Console.ReadLine();
        Console.Write("Digite a senha:");
        Senha = Console.ReadLine();
    }
}