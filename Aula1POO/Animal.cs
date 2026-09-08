public class Animal
{
    public string Nome { get; set; }
    public string Especie { get; set; }
    public int Idade { get; set; }
    public bool EstaDormindo { get; set; }

    public Animal(string nome, string especie, int idade, bool estadormindo)
    {
        Nome = nome;
        Especie = especie;
        Idade = idade;
        EstaDormindo = estadormindo;
    }

    public void Dormir()
    {
        EstaDormindo = true;
        Console.WriteLine("O animal está dormindo");
    }
    
    public void Acordar()
    {
        EstaDormindo = false;
        Console.WriteLine("O animal acordou");
    }

    public void FazerSom()
    {
        Console.WriteLine("O animal fez um som");
    }

    public void ApresentarSe()
    {
        Console.WriteLine("---Informações do animal---");
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Espécie: " + Especie);
        Console.WriteLine("Idade: " + Idade + " anos");
    }
}